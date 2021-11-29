
using System.Windows.Forms;

namespace RFO_Clicker
{
    partial class MainForm
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
            this.startClickingButton = new System.Windows.Forms.Button();
            this.stopClickingButton = new System.Windows.Forms.Button();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.pressButonLabel = new System.Windows.Forms.Label();
            this.pressButtonPicker = new System.Windows.Forms.ListBox();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.interval1Label = new System.Windows.Forms.Label();
            this.intervalMinTimeTextBox = new System.Windows.Forms.TextBox();
            this.interval2Label = new System.Windows.Forms.Label();
            this.intervalMaxTimeTextBox = new System.Windows.Forms.TextBox();
            this.interval3Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startClickingButton
            // 
            this.startClickingButton.Location = new System.Drawing.Point(12, 12);
            this.startClickingButton.Name = "startClickingButton";
            this.startClickingButton.Size = new System.Drawing.Size(283, 44);
            this.startClickingButton.TabIndex = 0;
            this.startClickingButton.Text = "ЗАПУСТИТЬ КЛИКЕР";
            this.startClickingButton.UseVisualStyleBackColor = true;
            this.startClickingButton.Click += new System.EventHandler(this.startClickingButton_Click);
            // 
            // stopClickingButton
            // 
            this.stopClickingButton.Location = new System.Drawing.Point(12, 62);
            this.stopClickingButton.Name = "stopClickingButton";
            this.stopClickingButton.Size = new System.Drawing.Size(283, 42);
            this.stopClickingButton.TabIndex = 1;
            this.stopClickingButton.Text = "ОСТАНОВИТЬ КЛИКЕР";
            this.stopClickingButton.UseVisualStyleBackColor = true;
            this.stopClickingButton.Click += new System.EventHandler(this.stopClickingButton_Click);
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Location = new System.Drawing.Point(117, 131);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(62, 13);
            this.settingsLabel.TabIndex = 2;
            this.settingsLabel.Text = "Настройки";
            // 
            // pressButonLabel
            // 
            this.pressButonLabel.AutoSize = true;
            this.pressButonLabel.Location = new System.Drawing.Point(102, 162);
            this.pressButonLabel.Name = "pressButonLabel";
            this.pressButonLabel.Size = new System.Drawing.Size(90, 13);
            this.pressButonLabel.TabIndex = 3;
            this.pressButonLabel.Text = "Кнопка нажатия";
            // 
            // pressButtonPicker
            // 
            this.pressButtonPicker.FormattingEnabled = true;
            this.pressButtonPicker.Location = new System.Drawing.Point(12, 178);
            this.pressButtonPicker.Name = "pressButtonPicker";
            this.pressButtonPicker.Size = new System.Drawing.Size(272, 56);
            this.pressButtonPicker.TabIndex = 4;
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(9, 255);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(288, 13);
            this.intervalLabel.TabIndex = 5;
            this.intervalLabel.Text = "Время интервала между нажатиями (в миллисекундах)";
            // 
            // interval1Label
            // 
            this.interval1Label.AutoSize = true;
            this.interval1Label.Location = new System.Drawing.Point(12, 280);
            this.interval1Label.Name = "interval1Label";
            this.interval1Label.Size = new System.Drawing.Size(20, 13);
            this.interval1Label.TabIndex = 6;
            this.interval1Label.Text = "От";
            // 
            // intervalMinTimeTextBox
            // 
            this.intervalMinTimeTextBox.Location = new System.Drawing.Point(38, 277);
            this.intervalMinTimeTextBox.Name = "intervalMinTimeTextBox";
            this.intervalMinTimeTextBox.Size = new System.Drawing.Size(86, 20);
            this.intervalMinTimeTextBox.TabIndex = 7;
            this.intervalMinTimeTextBox.TextChanged += new System.EventHandler(this.intervalTimeTextBox_TextChanged);
            // 
            // interval2Label
            // 
            this.interval2Label.AutoSize = true;
            this.interval2Label.Location = new System.Drawing.Point(130, 280);
            this.interval2Label.Name = "interval2Label";
            this.interval2Label.Size = new System.Drawing.Size(36, 13);
            this.interval2Label.TabIndex = 8;
            this.interval2Label.Text = "мс до";
            // 
            // intervalMaxTimeTextBox
            // 
            this.intervalMaxTimeTextBox.Location = new System.Drawing.Point(172, 277);
            this.intervalMaxTimeTextBox.Name = "intervalMaxTimeTextBox";
            this.intervalMaxTimeTextBox.Size = new System.Drawing.Size(85, 20);
            this.intervalMaxTimeTextBox.TabIndex = 9;
            this.intervalMaxTimeTextBox.TextChanged += new System.EventHandler(this.intervalTimeTextBox_TextChanged);
            // 
            // interval3Label
            // 
            this.interval3Label.AutoSize = true;
            this.interval3Label.Location = new System.Drawing.Point(263, 280);
            this.interval3Label.Name = "interval3Label";
            this.interval3Label.Size = new System.Drawing.Size(21, 13);
            this.interval3Label.TabIndex = 10;
            this.interval3Label.Text = "мс";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 321);
            this.Controls.Add(this.interval3Label);
            this.Controls.Add(this.intervalMaxTimeTextBox);
            this.Controls.Add(this.interval2Label);
            this.Controls.Add(this.intervalMinTimeTextBox);
            this.Controls.Add(this.interval1Label);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.pressButtonPicker);
            this.Controls.Add(this.pressButonLabel);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.stopClickingButton);
            this.Controls.Add(this.startClickingButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "RFO Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startClickingButton;
        private System.Windows.Forms.Button stopClickingButton;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label pressButonLabel;
        private System.Windows.Forms.ListBox pressButtonPicker;
        private Label intervalLabel;
        private Label interval1Label;
        private TextBox intervalMinTimeTextBox;
        private Label interval2Label;
        private TextBox intervalMaxTimeTextBox;
        private Label interval3Label;
    }
}

