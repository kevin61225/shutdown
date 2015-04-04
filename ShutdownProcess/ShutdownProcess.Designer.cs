namespace ShutdownProcess
{
    partial class ShutdownProcess
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShutdownProcess));
            this._cancelButton = new System.Windows.Forms.Button();
            this._setTimeLabel = new System.Windows.Forms.Label();
            this._okayButton = new System.Windows.Forms.Button();
            this._dayComboBox = new System.Windows.Forms.ComboBox();
            this._hourComboBox = new System.Windows.Forms.ComboBox();
            this._minComboBox = new System.Windows.Forms.ComboBox();
            this._secComboBox = new System.Windows.Forms.ComboBox();
            this._dayLabel = new System.Windows.Forms.Label();
            this._hourLabel = new System.Windows.Forms.Label();
            this._minLabel = new System.Windows.Forms.Label();
            this._secLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _cancelButton
            // 
            this._cancelButton.Location = new System.Drawing.Point(258, 75);
            this._cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(87, 31);
            this._cancelButton.TabIndex = 0;
            this._cancelButton.Text = "取消關機";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this.ClickCancelButton);
            // 
            // _setTimeLabel
            // 
            this._setTimeLabel.AutoSize = true;
            this._setTimeLabel.Location = new System.Drawing.Point(12, 26);
            this._setTimeLabel.Name = "_setTimeLabel";
            this._setTimeLabel.Size = new System.Drawing.Size(56, 16);
            this._setTimeLabel.TabIndex = 1;
            this._setTimeLabel.Text = "設定時間";
            // 
            // _okayButton
            // 
            this._okayButton.Location = new System.Drawing.Point(81, 75);
            this._okayButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._okayButton.Name = "_okayButton";
            this._okayButton.Size = new System.Drawing.Size(87, 31);
            this._okayButton.TabIndex = 0;
            this._okayButton.Text = "確定";
            this._okayButton.UseVisualStyleBackColor = true;
            this._okayButton.Click += new System.EventHandler(this.ClickOkButton);
            // 
            // _dayComboBox
            // 
            this._dayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._dayComboBox.FormattingEnabled = true;
            this._dayComboBox.Location = new System.Drawing.Point(81, 22);
            this._dayComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._dayComboBox.Name = "_dayComboBox";
            this._dayComboBox.Size = new System.Drawing.Size(47, 24);
            this._dayComboBox.TabIndex = 2;
            this._dayComboBox.SelectedIndexChanged += new System.EventHandler(this.ChangeDayCombobox);
            // 
            // _hourComboBox
            // 
            this._hourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._hourComboBox.FormattingEnabled = true;
            this._hourComboBox.Location = new System.Drawing.Point(162, 22);
            this._hourComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._hourComboBox.Name = "_hourComboBox";
            this._hourComboBox.Size = new System.Drawing.Size(47, 24);
            this._hourComboBox.TabIndex = 2;
            this._hourComboBox.SelectedIndexChanged += new System.EventHandler(this.ChangeHourCombobox);
            // 
            // _minComboBox
            // 
            this._minComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._minComboBox.FormattingEnabled = true;
            this._minComboBox.Location = new System.Drawing.Point(258, 22);
            this._minComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._minComboBox.Name = "_minComboBox";
            this._minComboBox.Size = new System.Drawing.Size(47, 24);
            this._minComboBox.TabIndex = 2;
            this._minComboBox.SelectedIndexChanged += new System.EventHandler(this.ChangeMinCombobox);
            // 
            // _secComboBox
            // 
            this._secComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._secComboBox.FormattingEnabled = true;
            this._secComboBox.Location = new System.Drawing.Point(340, 22);
            this._secComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._secComboBox.Name = "_secComboBox";
            this._secComboBox.Size = new System.Drawing.Size(47, 24);
            this._secComboBox.TabIndex = 2;
            this._secComboBox.SelectedIndexChanged += new System.EventHandler(this.ChangeSecCombobox);
            // 
            // _dayLabel
            // 
            this._dayLabel.AutoSize = true;
            this._dayLabel.Location = new System.Drawing.Point(136, 26);
            this._dayLabel.Name = "_dayLabel";
            this._dayLabel.Size = new System.Drawing.Size(20, 16);
            this._dayLabel.TabIndex = 3;
            this._dayLabel.Text = "天";
            // 
            // _hourLabel
            // 
            this._hourLabel.AutoSize = true;
            this._hourLabel.Location = new System.Drawing.Point(217, 26);
            this._hourLabel.Name = "_hourLabel";
            this._hourLabel.Size = new System.Drawing.Size(32, 16);
            this._hourLabel.TabIndex = 3;
            this._hourLabel.Text = "小時";
            // 
            // _minLabel
            // 
            this._minLabel.AutoSize = true;
            this._minLabel.Location = new System.Drawing.Point(313, 26);
            this._minLabel.Name = "_minLabel";
            this._minLabel.Size = new System.Drawing.Size(20, 16);
            this._minLabel.TabIndex = 3;
            this._minLabel.Text = "分";
            // 
            // _secLabel
            // 
            this._secLabel.AutoSize = true;
            this._secLabel.Location = new System.Drawing.Point(395, 26);
            this._secLabel.Name = "_secLabel";
            this._secLabel.Size = new System.Drawing.Size(20, 16);
            this._secLabel.TabIndex = 3;
            this._secLabel.Text = "秒";
            // 
            // ShutdownProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(433, 124);
            this.Controls.Add(this._secLabel);
            this.Controls.Add(this._minLabel);
            this.Controls.Add(this._hourLabel);
            this.Controls.Add(this._dayLabel);
            this.Controls.Add(this._secComboBox);
            this.Controls.Add(this._minComboBox);
            this.Controls.Add(this._hourComboBox);
            this.Controls.Add(this._dayComboBox);
            this.Controls.Add(this._setTimeLabel);
            this.Controls.Add(this._okayButton);
            this.Controls.Add(this._cancelButton);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShutdownProcess";
            this.Text = "關機程式";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckExiting);
            this.Load += new System.EventHandler(this.ShutdownProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label _setTimeLabel;
        private System.Windows.Forms.Button _okayButton;
        private System.Windows.Forms.ComboBox _dayComboBox;
        private System.Windows.Forms.ComboBox _hourComboBox;
        private System.Windows.Forms.ComboBox _minComboBox;
        private System.Windows.Forms.ComboBox _secComboBox;
        private System.Windows.Forms.Label _dayLabel;
        private System.Windows.Forms.Label _hourLabel;
        private System.Windows.Forms.Label _minLabel;
        private System.Windows.Forms.Label _secLabel;
    }
}

