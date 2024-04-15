using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBuilder
{
    public partial class FormShablon : Form
    {
        public FormShablon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newBuildPc form = new newBuildPc(2);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newBuildPc form = new newBuildPc(3);
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            newBuildPc form = new newBuildPc(4);
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            newBuildPc form = new newBuildPc(5);
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            newBuildPc form = new newBuildPc(6);
            form.ShowDialog();
        }
    }
}
