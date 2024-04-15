using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace PCBuilder
{
    public partial class newBuildPc : Form
    {
        decimal countPrice = 0;
        string pictures, names, dbs = "";
        int adm = 0;
        string pMotherboard, pProcessor, pGraphics_Card, pRAM, pCPU_Cooler, pHard_Drive, pSSD_Drive, pPower_Supply, pComputerCase = "";
        public newBuildPc(int admC)
        {
            adm = admC;
            InitializeComponent();
            screenupADM();
            buttonMatPlat.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
           
        }
            public newBuildPc()
            {
           
                InitializeComponent();
                screenup();
            priceScreen("Motherboard", label1.Text);
            priceScreen("Processor", label2.Text);
            priceScreen("Graphics_Card", label3.Text);
            priceScreen("RAM", label4.Text);
            priceScreen("CPU_Cooler", label5.Text);
            priceScreen("Hard_Drive", label6.Text);
            priceScreen("SSD_Drive", label7.Text);
            priceScreen("Power_Supply", label8.Text);
            priceScreen("ComputerCase", label9.Text);
        }
                
        
        public newBuildPc(string picture, string name, string db)
        {
            pictures = picture;
            names = name;
            dbs = db;
            InitializeComponent();
            screenup();
           
        }
       
       

        private void tgMessageButton_Click_1(object sender, EventArgs e)
        {
           
            string message = $"Материнская плата: {label1.Text}\n\n" +
                                             $"Процессор: {label2.Text}\n\n" +
                                             $"Видеокарта: {label3.Text}\n\n" +
                                             $"ОЗУ: {label4.Text}\n" +
                                             $"Кулер: {label5.Text}\n" +
                                             $"Жесткий диск: {label6.Text}\n" +
                                             $"SSD диск: {label7.Text}\n" +
                                             $"Блок питания: {label8.Text}\n" +
                                             $"Корпус: {label9.Text}";

            FormIdTG form2 = new FormIdTG(message);
            form2.ShowDialog();

        }

        void screenupADM()
        {
            DB db = new DB();

            string query = "SELECT * FROM SessionTable WHERE SessionID = @ses and UserID = 2";
            SqlConnection connection = db.getConnection();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@ses",adm);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    pMotherboard = reader.GetString(reader.GetOrdinal("Motherboard"));
                    pProcessor = reader.GetString(reader.GetOrdinal("Processor"));
                    pGraphics_Card = reader.GetString(reader.GetOrdinal("Graphics_Card"));
                    pRAM = reader.GetString(reader.GetOrdinal("RAM"));
                    pCPU_Cooler = reader.GetString(reader.GetOrdinal("CPU_Cooler"));
                    pHard_Drive = reader.GetString(reader.GetOrdinal("Hard_Drive"));
                    pSSD_Drive = reader.GetString(reader.GetOrdinal("SSD_Drive"));
                    pPower_Supply = reader.GetString(reader.GetOrdinal("Power_Supply"));
                    pComputerCase = reader.GetString(reader.GetOrdinal("ComputerCase"));
                }
                reader.Close();
            }

            label1.Text = pMotherboard;
            label2.Text = pProcessor;
            label3.Text = pGraphics_Card;
            label4.Text = pRAM;
            label5.Text = pCPU_Cooler;
            label6.Text = pHard_Drive;
            label7.Text = pSSD_Drive;
            label8.Text = pPower_Supply;
            label9.Text = pComputerCase;

        }
        
        void priceScreen(string name,string model) {
            DB db = new DB();
            string query = "SELECT Price FROM "+ name + " WHERE Model = @mod";
            SqlConnection connection = db.getConnection();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@mod", model);
                connection.Open();
              

                try
                {
                    if (model.Length > 3)
                    {

                        countPrice += (decimal)command.ExecuteScalar();

                        labePrice.Text = countPrice + "";
                    }
                    
                }
                catch { 
                }
            }

        }
        void screenup()
        {
            DB db = new DB();

            string query = "SELECT * FROM SessionTable WHERE SessionID = 1";
            SqlConnection connection = db.getConnection();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    pMotherboard = reader.GetString(reader.GetOrdinal("Motherboard"));
                    pProcessor = reader.GetString(reader.GetOrdinal("Processor"));
                    pGraphics_Card = reader.GetString(reader.GetOrdinal("Graphics_Card"));
                    pRAM = reader.GetString(reader.GetOrdinal("RAM"));
                    pCPU_Cooler = reader.GetString(reader.GetOrdinal("CPU_Cooler"));
                    pHard_Drive = reader.GetString(reader.GetOrdinal("Hard_Drive"));
                    pSSD_Drive = reader.GetString(reader.GetOrdinal("SSD_Drive"));
                    pPower_Supply = reader.GetString(reader.GetOrdinal("Power_Supply"));
                    pComputerCase = reader.GetString(reader.GetOrdinal("ComputerCase"));
                }
                reader.Close();
            }
            
            label1.Text = pMotherboard;
            label2.Text = pProcessor;
            label3.Text = pGraphics_Card;
            label4.Text = pRAM;
            label5.Text = pCPU_Cooler;
            label6.Text = pHard_Drive;
            label7.Text = pSSD_Drive;
            label8.Text = pPower_Supply;
            label9.Text = pComputerCase;

        }

        private void buttonMatPlat_Click(object sender, EventArgs e)
        {
            FormMatPlat form1 = new FormMatPlat("Motherboard", 3);
            this.Hide();
            form1.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMatPlat form1 = new FormMatPlat("Processor", 3);
            this.Hide();
            form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMatPlat form1 = new FormMatPlat("Graphics_Card", 3);
            this.Hide();
            form1.ShowDialog();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormMatPlat form1 = new FormMatPlat("RAM", 3);
            this.Hide();
            form1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormMatPlat form1 = new FormMatPlat("CPU_Cooler", 3);
            this.Hide();
            form1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormMatPlat form1 = new FormMatPlat("Hard_Drive", 3);
            this.Hide();
            form1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormMatPlat form1 = new FormMatPlat("SSD_Drive", 3);
            this.Hide();
            form1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormMatPlat form1 = new FormMatPlat("Power_Supply", 3);
            this.Hide();
            form1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormMatPlat form1 = new FormMatPlat("ComputerCase", 3);
            this.Hide();
            form1.ShowDialog();
        }
    }
}
