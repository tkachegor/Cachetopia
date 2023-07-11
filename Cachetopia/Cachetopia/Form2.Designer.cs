namespace Cachetopia
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startupSettings = new System.Windows.Forms.Label();
            this.addStartupLabel = new MaterialSkin.Controls.MaterialLabel();
            this.addToStartup = new MaterialSkin.Controls.MaterialButton();
            this.removeFromStartupLabel = new MaterialSkin.Controls.MaterialLabel();
            this.removeFromStartup = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.applyBtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // startupSettings
            // 
            this.startupSettings.AutoSize = true;
            this.startupSettings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startupSettings.Location = new System.Drawing.Point(12, 85);
            this.startupSettings.Name = "startupSettings";
            this.startupSettings.Size = new System.Drawing.Size(172, 30);
            this.startupSettings.TabIndex = 0;
            this.startupSettings.Text = "Startup Settings";
            // 
            // addStartupLabel
            // 
            this.addStartupLabel.AutoSize = true;
            this.addStartupLabel.Depth = 0;
            this.addStartupLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addStartupLabel.Location = new System.Drawing.Point(30, 139);
            this.addStartupLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.addStartupLabel.Name = "addStartupLabel";
            this.addStartupLabel.Size = new System.Drawing.Size(181, 19);
            this.addStartupLabel.TabIndex = 1;
            this.addStartupLabel.Text = "Add programm to Startup";
            // 
            // addToStartup
            // 
            this.addToStartup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addToStartup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToStartup.Depth = 0;
            this.addToStartup.DrawShadows = true;
            this.addToStartup.HighEmphasis = true;
            this.addToStartup.Icon = null;
            this.addToStartup.Location = new System.Drawing.Point(33, 164);
            this.addToStartup.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addToStartup.MouseState = MaterialSkin.MouseState.HOVER;
            this.addToStartup.Name = "addToStartup";
            this.addToStartup.Size = new System.Drawing.Size(141, 36);
            this.addToStartup.TabIndex = 2;
            this.addToStartup.Text = "Add to startup";
            this.addToStartup.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addToStartup.UseAccentColor = false;
            this.addToStartup.UseVisualStyleBackColor = true;
            this.addToStartup.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // removeFromStartupLabel
            // 
            this.removeFromStartupLabel.AutoSize = true;
            this.removeFromStartupLabel.Depth = 0;
            this.removeFromStartupLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.removeFromStartupLabel.Location = new System.Drawing.Point(30, 244);
            this.removeFromStartupLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeFromStartupLabel.Name = "removeFromStartupLabel";
            this.removeFromStartupLabel.Size = new System.Drawing.Size(228, 19);
            this.removeFromStartupLabel.TabIndex = 3;
            this.removeFromStartupLabel.Text = "Remove programm from startup";
            this.removeFromStartupLabel.Click += new System.EventHandler(this.removeFromStartupLabel_Click);
            // 
            // removeFromStartup
            // 
            this.removeFromStartup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeFromStartup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeFromStartup.Depth = 0;
            this.removeFromStartup.DrawShadows = true;
            this.removeFromStartup.HighEmphasis = true;
            this.removeFromStartup.Icon = null;
            this.removeFromStartup.Location = new System.Drawing.Point(33, 269);
            this.removeFromStartup.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.removeFromStartup.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeFromStartup.Name = "removeFromStartup";
            this.removeFromStartup.Size = new System.Drawing.Size(192, 36);
            this.removeFromStartup.TabIndex = 4;
            this.removeFromStartup.Text = "Remove from startup";
            this.removeFromStartup.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.removeFromStartup.UseAccentColor = false;
            this.removeFromStartup.UseVisualStyleBackColor = true;
            this.removeFromStartup.Click += new System.EventHandler(this.removeFromStartup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(409, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Scheduled Cleaning";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(487, 139);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(101, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "When to clean";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(460, 186);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(128, 20);
            this.datePicker.TabIndex = 7;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(457, 164);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(34, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Date";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(457, 218);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(37, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Time";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(460, 240);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(128, 20);
            this.timePicker.TabIndex = 10;
            this.timePicker.ValueChanged += new System.EventHandler(this.timePicker_ValueChanged);
            // 
            // applyBtn
            // 
            this.applyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.applyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyBtn.Depth = 0;
            this.applyBtn.DrawShadows = true;
            this.applyBtn.HighEmphasis = true;
            this.applyBtn.Icon = null;
            this.applyBtn.Location = new System.Drawing.Point(490, 269);
            this.applyBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.applyBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(67, 36);
            this.applyBtn.TabIndex = 11;
            this.applyBtn.Text = "Apply";
            this.applyBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.applyBtn.UseAccentColor = false;
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 414);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeFromStartup);
            this.Controls.Add(this.removeFromStartupLabel);
            this.Controls.Add(this.addToStartup);
            this.Controls.Add(this.addStartupLabel);
            this.Controls.Add(this.startupSettings);
            this.Name = "Form2";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startupSettings;
        private MaterialSkin.Controls.MaterialLabel addStartupLabel;
        private MaterialSkin.Controls.MaterialButton addToStartup;
        private MaterialSkin.Controls.MaterialLabel removeFromStartupLabel;
        private MaterialSkin.Controls.MaterialButton removeFromStartup;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DateTimePicker timePicker;
        private MaterialSkin.Controls.MaterialButton applyBtn;
    }
}