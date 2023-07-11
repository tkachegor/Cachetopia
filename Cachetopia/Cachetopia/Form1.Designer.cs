namespace Cachetopia
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.clearBrowser = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.standartProgramms = new MaterialSkin.Controls.MaterialButton();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.openCachetopiaStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitCachetopiaStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllCacheStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.clearBrowserStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSystemStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(77, 114);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(134, 41);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Clear  All";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(96, 161);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(96, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Clear ALL";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(70, 216);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(151, 29);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Clear Browser";
            // 
            // clearBrowser
            // 
            this.clearBrowser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBrowser.Depth = 0;
            this.clearBrowser.DrawShadows = true;
            this.clearBrowser.HighEmphasis = true;
            this.clearBrowser.Icon = null;
            this.clearBrowser.Location = new System.Drawing.Point(111, 251);
            this.clearBrowser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clearBrowser.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearBrowser.Name = "clearBrowser";
            this.clearBrowser.Size = new System.Drawing.Size(66, 36);
            this.clearBrowser.TabIndex = 3;
            this.clearBrowser.Text = "Clear";
            this.clearBrowser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.clearBrowser.UseAccentColor = false;
            this.clearBrowser.UseVisualStyleBackColor = true;
            this.clearBrowser.Click += new System.EventHandler(this.clearBrowser_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(70, 309);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(154, 29);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Clear Standart";
            // 
            // standartProgramms
            // 
            this.standartProgramms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.standartProgramms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.standartProgramms.Depth = 0;
            this.standartProgramms.DrawShadows = true;
            this.standartProgramms.HighEmphasis = true;
            this.standartProgramms.Icon = null;
            this.standartProgramms.Location = new System.Drawing.Point(111, 344);
            this.standartProgramms.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.standartProgramms.MouseState = MaterialSkin.MouseState.HOVER;
            this.standartProgramms.Name = "standartProgramms";
            this.standartProgramms.Size = new System.Drawing.Size(66, 36);
            this.standartProgramms.TabIndex = 5;
            this.standartProgramms.Text = "Clear";
            this.standartProgramms.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.standartProgramms.UseAccentColor = false;
            this.standartProgramms.UseVisualStyleBackColor = true;
            this.standartProgramms.Click += new System.EventHandler(this.standartProgramms_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.menuStrip;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Cachetopia";
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuStrip.Depth = 0;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCachetopiaStrip,
            this.exitCachetopiaStrip,
            this.clearAllCacheToolStripMenuItem});
            this.menuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(167, 70);
            // 
            // openCachetopiaStrip
            // 
            this.openCachetopiaStrip.Name = "openCachetopiaStrip";
            this.openCachetopiaStrip.Size = new System.Drawing.Size(166, 22);
            this.openCachetopiaStrip.Text = "Open Cachetopia";
            this.openCachetopiaStrip.Click += new System.EventHandler(this.openCachetopiaStrip_Click);
            this.openCachetopiaStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // exitCachetopiaStrip
            // 
            this.exitCachetopiaStrip.Name = "exitCachetopiaStrip";
            this.exitCachetopiaStrip.Size = new System.Drawing.Size(166, 22);
            this.exitCachetopiaStrip.Text = "Exit Cachetopia";
            this.exitCachetopiaStrip.Click += new System.EventHandler(this.exitCachetopiaStrip_Click);
            // 
            // clearAllCacheToolStripMenuItem
            // 
            this.clearAllCacheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllCacheStrip,
            this.clearBrowserStrip,
            this.clearSystemStrip});
            this.clearAllCacheToolStripMenuItem.Name = "clearAllCacheToolStripMenuItem";
            this.clearAllCacheToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.clearAllCacheToolStripMenuItem.Text = "Clear Cache";
            // 
            // clearAllCacheStrip
            // 
            this.clearAllCacheStrip.Name = "clearAllCacheStrip";
            this.clearAllCacheStrip.Size = new System.Drawing.Size(180, 22);
            this.clearAllCacheStrip.Text = "Clear all cache";
            this.clearAllCacheStrip.Click += new System.EventHandler(this.clearAllCacheStrip_Click);
            // 
            // clearBrowserStrip
            // 
            this.clearBrowserStrip.Name = "clearBrowserStrip";
            this.clearBrowserStrip.Size = new System.Drawing.Size(180, 22);
            this.clearBrowserStrip.Text = "Clear browser cache";
            this.clearBrowserStrip.Click += new System.EventHandler(this.clearBrowserStrip_Click);
            // 
            // clearSystemStrip
            // 
            this.clearSystemStrip.Name = "clearSystemStrip";
            this.clearSystemStrip.Size = new System.Drawing.Size(180, 22);
            this.clearSystemStrip.Text = "Clear system cache";
            this.clearSystemStrip.Click += new System.EventHandler(this.clearSystemStrip_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsButton.Location = new System.Drawing.Point(199, 29);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 28);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 419);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.standartProgramms);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.clearBrowser);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialLabel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Cachetopia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton clearBrowser;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton standartProgramms;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private MaterialSkin.Controls.MaterialContextMenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem openCachetopiaStrip;
        private System.Windows.Forms.ToolStripMenuItem exitCachetopiaStrip;
        private System.Windows.Forms.ToolStripMenuItem clearAllCacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllCacheStrip;
        private System.Windows.Forms.ToolStripMenuItem clearBrowserStrip;
        private System.Windows.Forms.ToolStripMenuItem clearSystemStrip;
        private System.Windows.Forms.Button settingsButton;
    }
}

