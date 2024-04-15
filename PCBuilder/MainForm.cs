using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PCBuilder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MaimForm_Load(object sender, EventArgs e)
        {

        }

        private void Guide_label_Click(object sender, EventArgs e)
        {
            // Открыть ссылку в браузере по умолчанию
            System.Diagnostics.Process.Start("https://youtu.be/LlNcMxZ06uc?si=ng9xp9tJu8WO1iaE");
        }

        private void New_build_button_Click(object sender, EventArgs e)
        {
          newBuildPc form1 = new newBuildPc();
            form1.ShowDialog();
        }

        private void Upgrade_button_Click(object sender, EventArgs e)
        {
           
        }

        private void Periphery_button_Click(object sender, EventArgs e)
        {
           
        }

        private void Templates_button_Click(object sender, EventArgs e)
        {
            FormShablon form3 = new FormShablon();
            form3.ShowDialog();
        }
    }
    
}
