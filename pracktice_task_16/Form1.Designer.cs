namespace pracktice_task_16
{
    partial class Partickles
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
            this.StartButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.updTimer = new System.Windows.Forms.Timer(this.components);
            this.numberOfDots = new System.Windows.Forms.NumericUpDown();
            this.lineLenght = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ApplieButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(825, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(82, 28);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsButton.Location = new System.Drawing.Point(913, 12);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(80, 28);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // updTimer
            // 
            this.updTimer.Interval = 16;
            this.updTimer.Tick += new System.EventHandler(this.updTimer_Tick);
            // 
            // numberOfDots
            // 
            this.numberOfDots.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numberOfDots.Location = new System.Drawing.Point(872, 47);
            this.numberOfDots.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numberOfDots.Name = "numberOfDots";
            this.numberOfDots.Size = new System.Drawing.Size(120, 26);
            this.numberOfDots.TabIndex = 2;
            this.numberOfDots.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numberOfDots.Visible = false;
            // 
            // lineLenght
            // 
            this.lineLenght.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineLenght.Location = new System.Drawing.Point(872, 79);
            this.lineLenght.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lineLenght.Name = "lineLenght";
            this.lineLenght.Size = new System.Drawing.Size(120, 26);
            this.lineLenght.TabIndex = 3;
            this.lineLenght.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.lineLenght.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(736, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "number of dots:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(736, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "line lenght:";
            this.label2.Visible = false;
            // 
            // ApplieButton
            // 
            this.ApplieButton.Location = new System.Drawing.Point(900, 112);
            this.ApplieButton.Name = "ApplieButton";
            this.ApplieButton.Size = new System.Drawing.Size(91, 28);
            this.ApplieButton.TabIndex = 6;
            this.ApplieButton.Text = "Applie";
            this.ApplieButton.UseVisualStyleBackColor = true;
            this.ApplieButton.Visible = false;
            this.ApplieButton.Click += new System.EventHandler(this.ApplieButton_Click);
            // 
            // Partickles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 531);
            this.Controls.Add(this.ApplieButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lineLenght);
            this.Controls.Add(this.numberOfDots);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.StartButton);
            this.Name = "Partickles";
            this.Text = "Partickles";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineLenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Timer updTimer;
        private System.Windows.Forms.NumericUpDown numberOfDots;
        private System.Windows.Forms.NumericUpDown lineLenght;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ApplieButton;
    }
}

