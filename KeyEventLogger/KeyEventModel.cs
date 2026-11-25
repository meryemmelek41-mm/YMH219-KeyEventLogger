using System;
using System.Windows.Forms;

namespace KeyEventLogger
{
    /// <summary>
    /// Klavyeden yakalanan her bir tuş olayını temsil eden model sınıfı.
    /// Nesne tabanlı tasarım prensiplerine uygun olarak olay ayrıntılarını kapsüller.
    /// </summary>
    public class KeyEventModel
    {
        public DateTime Timestamp { get; }
        public string EventType { get; }      // "KeyDown", "KeyUp", "KeyPress"
        public string KeyName { get; }        // Örneğin "Enter", "Space", "A"
        public int KeyCode { get; }           // Sayısal tuş kodu
        public string Modifiers { get; }      // Shift, Control, Alt bilgisi

        /// <summary>
        /// KeyEventArgs ile KeyDown/KeyUp olayı için model nesnesi oluşturur.
        /// </summary>
        public KeyEventModel(string eventType, KeyEventArgs e)
        {
            Timestamp = DateTime.Now;
            EventType = eventType;
            KeyName = e.KeyCode.ToString();
            KeyCode = e.KeyValue;

            var mod = "";
            if (e.Shift) mod += "Shift ";
            if (e.Control) mod += "Ctrl ";
            if (e.Alt) mod += "Alt ";
            Modifiers = string.IsNullOrWhiteSpace(mod) ? "Yok" : mod.Trim();
        }

        /// <summary>
        /// KeyPressEventArgs ile karakter girişleri için model nesnesi oluşturur.
        /// </summary>
        public KeyEventModel(string eventType, KeyPressEventArgs e)
        {
            Timestamp = DateTime.Now;
            EventType = eventType;
            KeyName = char.IsControl(e.KeyChar) ? $"Control({(int)e.KeyChar})" : e.KeyChar.ToString();
            KeyCode = (int)e.KeyChar;
            Modifiers = "Yok";
        }

        /// <summary>
        /// ListBox veya metin dosyasında görüntülenecek standart log satırı formatı.
        /// </summary>
        public override string ToString()
        {
            return $"[{Timestamp:yyyy-MM-dd HH:mm:ss.fff}] {EventType,-8} | Tuş: {KeyName,-12} | Kod: {KeyCode,4} | Değiştirici: {Modifiers}";
        }

        /// <summary>
        /// CSV veya ayrılmış metin biçiminde dışa aktarım satırı.
        /// </summary>
        public string ToExportString()
        {
            return $"{Timestamp:yyyy-MM-dd HH:mm:ss.fff}\t{EventType}\t{KeyName}\t{KeyCode}\t{Modifiers}";
        }
    }
}
