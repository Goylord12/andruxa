namespace PCBuilder
{
    partial class CodeForm
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
            this.TimerLabel = new System.Windows.Forms.Label();
            this.RepeatcodeLabel = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.codeBox1 = new System.Windows.Forms.TextBox();
            this.codeBox2 = new System.Windows.Forms.TextBox();
            this.codeBox3 = new System.Windows.Forms.TextBox();
            this.codeBox4 = new System.Windows.Forms.TextBox();
            this.codeBox5 = new System.Windows.Forms.TextBox();
            this.codeBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TimerLabel.Location = new System.Drawing.Point(276, 137);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(27, 20);
            this.TimerLabel.TabIndex = 2;
            this.TimerLabel.Text = "30";
            // 
            // RepeatcodeLabel
            // 
            this.RepeatcodeLabel.AutoSize = true;
            this.RepeatcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatcodeLabel.Location = new System.Drawing.Point(30, 137);
            this.RepeatcodeLabel.Name = "RepeatcodeLabel";
            this.RepeatcodeLabel.Size = new System.Drawing.Size(249, 20);
            this.RepeatcodeLabel.TabIndex = 3;
            this.RepeatcodeLabel.Text = "Отправить код повторно через";
            this.RepeatcodeLabel.Click += new System.EventHandler(this.RepeatcodeLabel_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.Location = new System.Drawing.Point(0, 261);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(372, 31);
            this.EnterButton.TabIndex = 4;
            this.EnterButton.Text = "Завершить регистрацию\r\n";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // codeBox1
            // 
            this.codeBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeBox1.Location = new System.Drawing.Point(78, 73);
            this.codeBox1.Multiline = true;
            this.codeBox1.Name = "codeBox1";
            this.codeBox1.Size = new System.Drawing.Size(30, 30);
            this.codeBox1.TabIndex = 5;
            this.codeBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codeBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseClick);
            this.codeBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeBox_KeyPress);
            // 
            // codeBox2
            // 
            this.codeBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeBox2.Location = new System.Drawing.Point(114, 73);
            this.codeBox2.Multiline = true;
            this.codeBox2.Name = "codeBox2";
            this.codeBox2.Size = new System.Drawing.Size(30, 30);
            this.codeBox2.TabIndex = 6;
            this.codeBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codeBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseClick);
            this.codeBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeBox_KeyPress);
            // 
            // codeBox3
            // 
            this.codeBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeBox3.Location = new System.Drawing.Point(150, 73);
            this.codeBox3.Multiline = true;
            this.codeBox3.Name = "codeBox3";
            this.codeBox3.Size = new System.Drawing.Size(30, 30);
            this.codeBox3.TabIndex = 7;
            this.codeBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codeBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseClick);
            this.codeBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeBox_KeyPress);
            // 
            // codeBox4
            // 
            this.codeBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeBox4.Location = new System.Drawing.Point(186, 73);
            this.codeBox4.Multiline = true;
            this.codeBox4.Name = "codeBox4";
            this.codeBox4.Size = new System.Drawing.Size(30, 30);
            this.codeBox4.TabIndex = 8;
            this.codeBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codeBox4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseClick);
            this.codeBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeBox_KeyPress);
            // 
            // codeBox5
            // 
            this.codeBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeBox5.Location = new System.Drawing.Point(222, 73);
            this.codeBox5.Multiline = true;
            this.codeBox5.Name = "codeBox5";
            this.codeBox5.Size = new System.Drawing.Size(30, 30);
            this.codeBox5.TabIndex = 9;
            this.codeBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codeBox5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseClick);
            this.codeBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeBox_KeyPress);
            // 
            // codeBox6
            // 
            this.codeBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeBox6.Location = new System.Drawing.Point(258, 73);
            this.codeBox6.Multiline = true;
            this.codeBox6.Name = "codeBox6";
            this.codeBox6.Size = new System.Drawing.Size(30, 30);
            this.codeBox6.TabIndex = 10;
            this.codeBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codeBox6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseClick);
            this.codeBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeBox_KeyPress);
            // 
            // CodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 292);
            this.Controls.Add(this.codeBox6);
            this.Controls.Add(this.codeBox5);
            this.Controls.Add(this.codeBox4);
            this.Controls.Add(this.codeBox3);
            this.Controls.Add(this.codeBox2);
            this.Controls.Add(this.codeBox1);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.RepeatcodeLabel);
            this.Controls.Add(this.TimerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodeForm";
            this.Text = "CodeForm";
            this.Load += new System.EventHandler(this.CodeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label RepeatcodeLabel;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.TextBox codeBox1;
        private System.Windows.Forms.TextBox codeBox2;
        private System.Windows.Forms.TextBox codeBox3;
        private System.Windows.Forms.TextBox codeBox4;
        private System.Windows.Forms.TextBox codeBox5;
        private System.Windows.Forms.TextBox codeBox6;
    }
}