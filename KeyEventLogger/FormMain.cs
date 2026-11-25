using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KeyEventLogger
{
    /// <summary>
    /// Key Event Logger ana form sınıfı.
    /// Yalnızca kendi penceresi aktifken klavye olaylarını (KeyDown, KeyUp, KeyPress) dinler.
    /// Güvenlik sınırlarına tam olarak uygundur (Global hook veya arka plan izleme içermez).
    /// </summary>
    public partial class FormMain : Form
    {
        private readonly KeyLoggerService _loggerService;

        public FormMain()
        {
            InitializeComponent();

            _loggerService = new KeyLoggerService();

            // Servis olaylarına abone ol
            _loggerService.OnKeyEventLogged += LoggerService_OnKeyEventLogged;
            _loggerService.OnLoggingStateChanged += LoggerService_OnLoggingStateChanged;

            // Form ve buton olaylarını bağla
            WireEvents();

            // Başlangıç durumunu ayarla
            UpdateStatusIndicator(false);
        }

        private void WireEvents()
        {
            btnStart.Click += (s, e) => _loggerService.StartLogging();
            btnStop.Click += (s, e) => _loggerService.StopLogging();
            btnClear.Click += BtnClear_Click;
            btnSave.Click += BtnSave_Click;

            txtFilter.TextChanged += TxtFilter_TextChanged;
            btnResetFilter.Click += (s, e) => { txtFilter.Text = string.Empty; };

            timerStats.Tick += TimerStats_Tick;

            // Form klavye olayları (KeyPreview = true ile tüm formda dinlenir)
            this.KeyDown += FormMain_KeyDown;
            this.KeyUp += FormMain_KeyUp;
            this.KeyPress += FormMain_KeyPress;
        }

        #region Klavye Olay Yönetimi

        private void FormMain_KeyDown(object? sender, KeyEventArgs e)
        {
            if (!_loggerService.IsLoggingActive) return;

            // İsteğe bağlı: Filtre kutusuna odaklıyken filtre tuşlarını loglamak yerine çalışmasını sağla
            var model = new KeyEventModel("KeyDown", e);
            _loggerService.LogEvent(model);
        }

        private void FormMain_KeyUp(object? sender, KeyEventArgs e)
        {
            if (!_loggerService.IsLoggingActive) return;

            var model = new KeyEventModel("KeyUp", e);
            _loggerService.LogEvent(model);
        }

        private void FormMain_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!_loggerService.IsLoggingActive) return;

            var model = new KeyEventModel("KeyPress", e);
            _loggerService.LogEvent(model);
        }

        #endregion

        #region Servis Olay Dinleyicileri

        private void LoggerService_OnKeyEventLogged(KeyEventModel model)
        {
            // Filtre kontrolü: Eğer arama varsa ve uyuşmuyorsa listeye ekleme
            string filter = txtFilter.Text.Trim();
            if (!string.IsNullOrEmpty(filter))
            {
                if (model.KeyName.IndexOf(filter, StringComparison.OrdinalIgnoreCase) < 0 &&
                    model.EventType.IndexOf(filter, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    return;
                }
            }

            // ListBox'a ekle ve en sona kaydır
            lstEvents.Items.Add(model.ToString());
            lstEvents.TopIndex = lstEvents.Items.Count - 1;

            UpdateStatistics();
        }

        private void LoggerService_OnLoggingStateChanged(bool isActive)
        {
            UpdateStatusIndicator(isActive);

            if (isActive)
            {
                timerStats.Start();
                txtTestInput.Focus();
            }
            else
            {
                timerStats.Stop();
            }
        }

        #endregion

        #region Arayüz Yardımcı Metotları

        private void UpdateStatusIndicator(bool isActive)
        {
            if (isActive)
            {
                pnlStatusIndicator.BackColor = Color.FromArgb(46, 204, 113); // Yeşil
                lblStatusText.Text = "🟢 KAYIT AKTİF (Dinleniyor)";
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
            else
            {
                pnlStatusIndicator.BackColor = Color.FromArgb(231, 76, 60); // Kırmızı
                lblStatusText.Text = "🔴 KAYIT DURDURULDU";
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
        }

        private void UpdateStatistics()
        {
            lblTotalCount.Text = $"Toplam Olay: {_loggerService.TotalKeyCount}";

            var topKeys = _loggerService.GetTopKeys(3);
            if (topKeys.Count > 0)
            {
                var summary = string.Join(", ", topKeys.Select(k => $"{k.Key} ({k.Value})"));
                lblTopKeys.Text = $"En Çok Basılanlar: {summary}";
            }
            else
            {
                lblTopKeys.Text = "En Çok Basılanlar: Henüz veri yok";
            }
        }

        private void TimerStats_Tick(object? sender, EventArgs e)
        {
            if (_loggerService.SessionStartTime.HasValue)
            {
                var duration = DateTime.Now - _loggerService.SessionStartTime.Value;
                lblSessionTime.Text = $"⏱ Oturum: {duration:hh\\:mm\\:ss}";
            }
        }

        private void TxtFilter_TextChanged(object? sender, EventArgs e)
        {
            string keyword = txtFilter.Text.Trim();
            lstEvents.Items.Clear();

            var filtered = _loggerService.FilterByKey(keyword);
            foreach (var evt in filtered)
            {
                lstEvents.Items.Add(evt.ToString());
            }

            if (lstEvents.Items.Count > 0)
                lstEvents.TopIndex = lstEvents.Items.Count - 1;
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Ekrandaki tüm kayıtları temizlemek istediğinize emin misiniz?",
                                "Kayıtları Temizle",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _loggerService.ClearEvents();
                lstEvents.Items.Clear();
                txtTestInput.Clear();
                UpdateStatistics();
                lblSessionTime.Text = "⏱ Oturum: 00:00:00";
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (_loggerService.TotalKeyCount == 0)
            {
                MessageBox.Show("Kaydedilecek herhangi bir tuş olayı bulunmuyor!\nLütfen önce 'Kaydı Başlat' butonuna tıklayıp klavyeyi kullanın.",
                                "Uyarı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = "Klavye Olay Kayıtlarını Kaydet";
                sfd.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
                sfd.FileName = $"KeyEventLog_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var result = _loggerService.SaveToFile(sfd.FileName);
                    if (result.Success)
                    {
                        MessageBox.Show(result.Message, "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(result.Message, "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        #endregion
    }
}
