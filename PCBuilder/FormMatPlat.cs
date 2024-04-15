using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PCBuilder
{
    public partial class FormMatPlat : Form
    {
        string nameBd = "";
        int lenght = 0;
        public FormMatPlat(string _name, int len)
        {
            lenght = len;
            nameBd = _name;
            InitializeComponent();
            dataGridViewHar.AutoGenerateColumns = true;
            dataGridViewHar.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewHar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            addRows();
        }
        void addRows() {
            DB db = new DB();
            using (SqlConnection connection = db.getConnection())
            {
                connection.Open();
                string query = "SELECT Model, Manufacturer, Price FROM " + nameBd;
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[lenght]);
                    for (int j = 0; j < lenght; j++)
                    {
                        data[data.Count - 1][j] = reader[j].ToString();

                    }
                }
                //   "C:\\Users\\facec\\Downloads\\qq.jpg"
                reader.Close();
                connection.Close();
                foreach (string[] s in data)
                    dataGridViewHar.Rows.Add(s);
            }
        }
        private void dataGridViewHar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewHar.CurrentCell.RowIndex;
            if (index >= 0)
            {
                string name = dataGridViewHar.Rows[index].Cells[0].Value.ToString();

                DB db = new DB();

                using (SqlConnection connection = db.getConnection())
                {
                    int i = 0;
                    connection.Open();
                    string query = "SELECT Manufacturer FROM " + nameBd + " WHERE Model=@name"; //+ " AND" + " COLUMN_NAME NOT IN (Модель, Производитель, Цена)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);
                    String zxc = command.ExecuteScalar().ToString();
                    labelInfo.Text = null;
                    labelInfo.Text = zxc;
                    //  string quary1 = "SELECT Picture FROM " + nameBd + " WHERE Model=@name";
                    //  SqlCommand command1 = new SqlCommand(quary1, connection);
                    //  command1.Parameters.AddWithValue("@name", name);
                    // string qq = command1.ExecuteScalar().ToString();
                    //  pictureBoxDetails.Image = null;
                    //   pictureBoxDetails.Image = Image.FromFile(qq);
                    //C:\\Users\\facec\\Downloads\\qq.jpg
                }
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            string model = "";
            int index = dataGridViewHar.CurrentCell.RowIndex;
            if (index >= 0)
            {
                DB db = new DB();

                using (SqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    string selQuar = nameBd + "ID";
                     model = dataGridViewHar.Rows[index].Cells[0].Value.ToString();
                    string query = " UPDATE SessionTable SET " + nameBd + " = @newName WHERE SessionID = 1";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@newName", model);
                    command.ExecuteNonQuery();
                }
               
                newBuildPc form = new newBuildPc();
                this.Hide();
                form.ShowDialog();
            }
        } 
        private void dataGridViewHar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}