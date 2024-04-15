namespace PCBuilder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.New_build_button = new System.Windows.Forms.Button();
            this.Upgrade_button = new System.Windows.Forms.Button();
            this.Periphery_button = new System.Windows.Forms.Button();
            this.Sample_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Guide_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(212, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в PC Builder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // New_build_button
            // 
            this.New_build_button.Location = new System.Drawing.Point(87, 101);
            this.New_build_button.Name = "New_build_button";
            this.New_build_button.Size = new System.Drawing.Size(126, 76);
            this.New_build_button.TabIndex = 2;
            this.New_build_button.Text = "Новая сборка";
            this.New_build_button.UseVisualStyleBackColor = true;
            this.New_build_button.Click += new System.EventHandler(this.New_build_button_Click);
            // 
            // Upgrade_button
            // 
            this.Upgrade_button.Location = new System.Drawing.Point(250, 101);
            this.Upgrade_button.Name = "Upgrade_button";
            this.Upgrade_button.Size = new System.Drawing.Size(126, 76);
            this.Upgrade_button.TabIndex = 3;
            this.Upgrade_button.Text = "Апгрейд";
            this.Upgrade_button.UseVisualStyleBackColor = true;
            this.Upgrade_button.Click += new System.EventHandler(this.Upgrade_button_Click);
            // 
            // Periphery_button
            // 
            this.Periphery_button.Location = new System.Drawing.Point(412, 101);
            this.Periphery_button.Name = "Periphery_button";
            this.Periphery_button.Size = new System.Drawing.Size(126, 76);
            this.Periphery_button.TabIndex = 4;
            this.Periphery_button.Text = "Периферия";
            this.Periphery_button.UseVisualStyleBackColor = true;
            this.Periphery_button.Click += new System.EventHandler(this.Periphery_button_Click);
            // 
            // Sample_button
            // 
            this.Sample_button.Location = new System.Drawing.Point(568, 101);
            this.Sample_button.Name = "Sample_button";
            this.Sample_button.Size = new System.Drawing.Size(126, 76);
            this.Sample_button.TabIndex = 5;
            this.Sample_button.Text = "Шаблоны";
            this.Sample_button.UseVisualStyleBackColor = true;
            this.Sample_button.Click += new System.EventHandler(this.Templates_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(234, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Не умеешь собирать компьютер? 0_О";
            // 
            // Guide_label
            // 
            this.Guide_label.AutoSize = true;
            this.Guide_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Guide_label.Location = new System.Drawing.Point(365, 425);
            this.Guide_label.Name = "Guide_label";
            this.Guide_label.Size = new System.Drawing.Size(145, 16);
            this.Guide_label.TabIndex = 7;
            this.Guide_label.Text = "Инструкия по сборке";
            this.Guide_label.Click += new System.EventHandler(this.Guide_label_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Guide_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sample_button);
            this.Controls.Add(this.Periphery_button);
            this.Controls.Add(this.Upgrade_button);
            this.Controls.Add(this.New_build_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "PCBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button New_build_button;
        private System.Windows.Forms.Button Upgrade_button;
        private System.Windows.Forms.Button Periphery_button;
        private System.Windows.Forms.Button Sample_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Guide_label;
    }
}

