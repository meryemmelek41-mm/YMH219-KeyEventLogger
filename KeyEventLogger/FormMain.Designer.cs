namespace KeyEventLogger
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlStatusIndicator = new System.Windows.Forms.Panel();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.pnlTypingArea = new System.Windows.Forms.Panel();
            this.lblTypingInfo = new System.Windows.Forms.Label();
            this.txtTestInput = new System.Windows.Forms.TextBox();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblTopKeys = new System.Windows.Forms.Label();
            this.lblSessionTime = new System.Windows.Forms.Label();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.timerStats = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlStatusIndicator.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlTypingArea.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.pnlStatusIndicator);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(920, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(430, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "⌨ Key Event Logger (Eğitsel Keylogger)";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(205)))));
            this.lblSubtitle.Location = new System.Drawing.Point(24, 48);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(445, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "YMH 219 Nesne Tabanlı Programlama · Yalnızca Form İçi Klavye Olayları İzlenir";
            // 
            // pnlStatusIndicator
            // 
            this.pnlStatusIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatusIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.pnlStatusIndicator.Controls.Add(this.lblStatusText);
            this.pnlStatusIndicator.Location = new System.Drawing.Point(670, 20);
            this.pnlStatusIndicator.Name = "pnlStatusIndicator";
            this.pnlStatusIndicator.Size = new System.Drawing.Size(230, 40);
            this.pnlStatusIndicator.TabIndex = 2;
            // 
            // lblStatusText
            // 
            this.lblStatusText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatusText.ForeColor = System.Drawing.Color.White;
            this.lblStatusText.Location = new System.Drawing.Point(0, 0);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(230, 40);
            this.lblStatusText.TabIndex = 0;
            this.lblStatusText.Text = "🔴 KAYIT DURDURULDU";
            this.lblStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlControls.Controls.Add(this.btnStart);
            this.pnlControls.Controls.Add(this.btnStop);
            this.pnlControls.Controls.Add(this.btnClear);
            this.pnlControls.Controls.Add(this.btnSave);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 80);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlControls.Size = new System.Drawing.Size(920, 56);
            this.pnlControls.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(20, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 36);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "▶ Kaydı Başlat";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(180, 10);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(150, 36);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "⏹ Kaydı Durdur";
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(340, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 36);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "🗑 Temizle";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(710, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(190, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "💾 Dosyaya Kaydet (.txt)";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.lblFilter);
            this.pnlFilter.Controls.Add(this.txtFilter);
            this.pnlFilter.Controls.Add(this.btnResetFilter);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 136);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.pnlFilter.Size = new System.Drawing.Size(920, 45);
            this.pnlFilter.TabIndex = 2;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFilter.Location = new System.Drawing.Point(20, 13);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(126, 17);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "🔍 Kayıtları Filtrele:";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFilter.Location = new System.Drawing.Point(155, 10);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PlaceholderText = "Tuş adı veya olay türü yazın (örn: Enter, Space, KeyDown)...";
            this.txtFilter.Size = new System.Drawing.Size(350, 24);
            this.txtFilter.TabIndex = 1;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilter.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResetFilter.Location = new System.Drawing.Point(515, 9);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(110, 26);
            this.btnResetFilter.TabIndex = 2;
            this.btnResetFilter.Text = "Filtreyi Sıfırla";
            this.btnResetFilter.UseVisualStyleBackColor = false;
            // 
            // pnlTypingArea
            // 
            this.pnlTypingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.pnlTypingArea.Controls.Add(this.lblTypingInfo);
            this.pnlTypingArea.Controls.Add(this.txtTestInput);
            this.pnlTypingArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTypingArea.Location = new System.Drawing.Point(0, 181);
            this.pnlTypingArea.Name = "pnlTypingArea";
            this.pnlTypingArea.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.pnlTypingArea.Size = new System.Drawing.Size(920, 60);
            this.pnlTypingArea.TabIndex = 3;
            // 
            // lblTypingInfo
            // 
            this.lblTypingInfo.AutoSize = true;
            this.lblTypingInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTypingInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(145)))));
            this.lblTypingInfo.Location = new System.Drawing.Point(20, 8);
            this.lblTypingInfo.Name = "lblTypingInfo";
            this.lblTypingInfo.Size = new System.Drawing.Size(434, 15);
            this.lblTypingInfo.TabIndex = 0;
            this.lblTypingInfo.Text = "✍ Klavyeyi test etmek için aşağıdaki kutuya tıklayıp serbestçe yazı yazabilirsiniz:";
            // 
            // txtTestInput
            // 
            this.txtTestInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTestInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTestInput.Location = new System.Drawing.Point(20, 27);
            this.txtTestInput.Name = "txtTestInput";
            this.txtTestInput.PlaceholderText = "Tuş vuruşlarını denemek için buraya bir şeyler yazın...";
            this.txtTestInput.Size = new System.Drawing.Size(880, 25);
            this.txtTestInput.TabIndex = 1;
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.pnlStats.Controls.Add(this.lblTotalCount);
            this.pnlStats.Controls.Add(this.lblTopKeys);
            this.pnlStats.Controls.Add(this.lblSessionTime);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStats.Location = new System.Drawing.Point(0, 570);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(920, 45);
            this.pnlStats.TabIndex = 5;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.lblTotalCount.Location = new System.Drawing.Point(20, 14);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(125, 17);
            this.lblTotalCount.TabIndex = 0;
            this.lblTotalCount.Text = "Toplam Olay: 0";
            // 
            // lblTopKeys
            // 
            this.lblTopKeys.AutoSize = true;
            this.lblTopKeys.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTopKeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.lblTopKeys.Location = new System.Drawing.Point(220, 15);
            this.lblTopKeys.Name = "lblTopKeys";
            this.lblTopKeys.Size = new System.Drawing.Size(164, 15);
            this.lblTopKeys.TabIndex = 1;
            this.lblTopKeys.Text = "En Çok Basılan Tuşlar: Henüz yok";
            // 
            // lblSessionTime
            // 
            this.lblSessionTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSessionTime.AutoSize = true;
            this.lblSessionTime.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSessionTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.lblSessionTime.Location = new System.Drawing.Point(750, 14);
            this.lblSessionTime.Name = "lblSessionTime";
            this.lblSessionTime.Size = new System.Drawing.Size(130, 17);
            this.lblSessionTime.TabIndex = 2;
            this.lblSessionTime.Text = "⏱ Oturum: 00:00:00";
            // 
            // lstEvents
            // 
            this.lstEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.lstEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEvents.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lstEvents.ItemHeight = 15;
            this.lstEvents.Location = new System.Drawing.Point(0, 241);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(920, 329);
            this.lstEvents.TabIndex = 4;
            // 
            // timerStats
            // 
            this.timerStats.Interval = 1000;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 615);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlTypingArea);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlHeader);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YMH219 - Key Event Logger";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlStatusIndicator.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlTypingArea.ResumeLayout(false);
            this.pnlTypingArea.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlStatusIndicator;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Panel pnlTypingArea;
        private System.Windows.Forms.Label lblTypingInfo;
        private System.Windows.Forms.TextBox txtTestInput;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblTopKeys;
        private System.Windows.Forms.Label lblSessionTime;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.Timer timerStats;
    }
}
