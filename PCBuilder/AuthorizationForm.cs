using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBuilder
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {

        }

        private void AithorizationButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Login = @uL AND Password = @pU", db.getConnection());
            command.Parameters.Add("@uL", textBox1.Text);
            command.Parameters.Add("@pU", textBox2.Text);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                using (SqlConnection connection = db.getConnection())
                {
                    db.openConnection();
                    String quary = "SELECT userID FROM Users WHERE Login = @login";
                    SqlCommand command1 = new SqlCommand(quary, connection);
                    command1.Parameters.AddWithValue("@login", textBox1.Text);

                    int userId = (int)command1.ExecuteScalar();

                    MainForm form1 = new MainForm();
                    form1.ShowDialog();
                }
            else
                MessageBox.Show("Данные введены некорректно");

        }
        private void RegistrationLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm rf = new RegistrationForm();
            rf.ShowDialog();

        }
    }
 
      
    }

