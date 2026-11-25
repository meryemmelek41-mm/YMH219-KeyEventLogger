using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace KeyEventLogger
{
    /// <summary>
    /// Tuş olaylarının kaydedilmesi, filtrelenmesi, istatistiklerinin çıkarılması
    /// ve dosyaya yazılması işlemlerini yöneten servis sınıfı.
    /// </summary>
    public class KeyLoggerService
    {
        private readonly List<KeyEventModel> _allEvents = new();
        public bool IsLoggingActive { get; private set; } = false;
        public DateTime? SessionStartTime { get; private set; }

        public event Action<KeyEventModel>? OnKeyEventLogged;
        public event Action<bool>? OnLoggingStateChanged;

        /// <summary>
        /// Kayıt işlemini başlatır.
        /// </summary>
        public void StartLogging()
        {
            if (!IsLoggingActive)
            {
                IsLoggingActive = true;
                if (SessionStartTime == null)
                    SessionStartTime = DateTime.Now;
                OnLoggingStateChanged?.Invoke(true);
            }
        }

        /// <summary>
        /// Kayıt işlemini duraklatır/durdurur.
        /// </summary>
        public void StopLogging()
        {
            if (IsLoggingActive)
            {
                IsLoggingActive = false;
                OnLoggingStateChanged?.Invoke(false);
            }
        }

        /// <summary>
        /// Yeni bir tuş olayı kaydeder (yalnızca kayıt aktifken).
        /// </summary>
        public void LogEvent(KeyEventModel keyEvent)
        {
            if (!IsLoggingActive) return;

            _allEvents.Add(keyEvent);
            OnKeyEventLogged?.Invoke(keyEvent);
        }

        /// <summary>
        /// Tüm kayıtları temizler.
        /// </summary>
        public void ClearEvents()
        {
            _allEvents.Clear();
            SessionStartTime = IsLoggingActive ? DateTime.Now : null;
        }

        /// <summary>
        /// Kaydedilen tüm olayları salt okunur liste olarak döndürür.
        /// </summary>
        public IReadOnlyList<KeyEventModel> GetAllEvents() => _allEvents.AsReadOnly();

        /// <summary>
        /// Toplam basılan tuş sayısı.
        /// </summary>
        public int TotalKeyCount => _allEvents.Count;

        /// <summary>
        /// En sık basılan ilk N tuşu ve basılma adetlerini döndürür (İsteğe bağlı geliştirme).
        /// </summary>
        public Dictionary<string, int> GetTopKeys(int topCount = 5)
        {
            return _allEvents
                .Where(e => e.EventType == "KeyDown")
                .GroupBy(e => e.KeyName)
                .OrderByDescending(g => g.Count())
                .Take(topCount)
                .ToDictionary(g => g.Key, g => g.Count());
        }

        /// <summary>
        /// Belirli bir tuş adına veya arama kelimesine göre kayıtları filtreler (İsteğe bağlı geliştirme).
        /// </summary>
        public List<KeyEventModel> FilterByKey(string searchKeyword)
        {
            if (string.IsNullOrWhiteSpace(searchKeyword))
                return _allEvents.ToList();

            return _allEvents
                .Where(e => e.KeyName.IndexOf(searchKeyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            e.EventType.IndexOf(searchKeyword, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        /// <summary>
        /// Belirli bir tarih/saat aralığına göre kayıtları filtreler (İsteğe bağlı geliştirme).
        /// </summary>
        public List<KeyEventModel> FilterByDateRange(DateTime start, DateTime end)
        {
            return _allEvents
                .Where(e => e.Timestamp >= start && e.Timestamp <= end)
                .ToList();
        }

        /// <summary>
        /// Kayıtları yerel bir .txt dosyasına yazar (StreamWriter ile).
        /// Hata kontrolleri içerir.
        /// </summary>
        public (bool Success, string Message) SaveToFile(string filePath)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(filePath))
                    return (false, "Geçersiz dosya yolu!");

                if (_allEvents.Count == 0)
                    return (false, "Kaydedilecek herhangi bir tuş olayı bulunmuyor!");

                using (var writer = new StreamWriter(filePath, false, System.Text.Encoding.UTF8))
                {
                    writer.WriteLine("=================================================================================");
                    writer.WriteLine("                    YMH219 KEY EVENT LOGGER RAPORU                              ");
                    writer.WriteLine("=================================================================================");
                    writer.WriteLine($"Oluşturulma Tarihi : {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                    writer.WriteLine($"Toplam Tuş Olayı   : {_allEvents.Count}");
                    writer.WriteLine("---------------------------------------------------------------------------------");
                    writer.WriteLine("ZAMAN               | OLAY TÜRÜ | TUŞ ADI      | TUŞ KODU | DEĞİŞTİRİCİ TUŞLAR");
                    writer.WriteLine("---------------------------------------------------------------------------------");

                    foreach (var evt in _allEvents)
                    {
                        writer.WriteLine(evt.ToString());
                    }

                    writer.WriteLine("---------------------------------------------------------------------------------");
                    writer.WriteLine("EN ÇOK BASILAN TUŞLAR:");
                    foreach (var pair in GetTopKeys(5))
                    {
                        writer.WriteLine($"  - {pair.Key,-12}: {pair.Value} kez");
                    }
                    writer.WriteLine("=================================================================================");
                    writer.WriteLine("NOT: Bu uygulama YMH219 dersi kapsamında yalnızca eğitsel amaçla geliştirilmiştir.");
                }

                return (true, $"{_allEvents.Count} adet tuş olayı başarıyla dosyaya kaydedildi:\n{filePath}");
            }
            catch (UnauthorizedAccessException ex)
            {
                return (false, $"Dosyaya erişim izni yetersiz: {ex.Message}");
            }
            catch (IOException ex)
            {
                return (false, $"Dosya yazma sırasında giriş/çıkış hatası oluştu: {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Beklenmeyen bir hata oluştu: {ex.Message}");
            }
        }
    }
}
