using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;


namespace WindowsFormsApplicationAlex
{
    public partial class Form_Tests : Form
    {
        string webAppConnection_string = "server=mysql101.1gb.ru;user ID=gb_56132;Password=e26ca36ba;database=gb_56132;";
        MySqlConnection conn;
        
        ToolStripLabel infoLabel;
        public Form_goout f_goout = new Form_goout();
        public Form_Tests()
        {
            InitializeComponent();
        }



        private void button_goout_Click(object sender, EventArgs e)
        {
            Form_goout f_goout = new Form_goout();
            f_goout.ShowDialog();
            this.Hide();
            infoLabel = new ToolStripLabel();
            statusStrip_Tests.Items.Clear();
            infoLabel.Text = "Выход из приложения";
            statusStrip_Tests.Items.Add(infoLabel);
        }

        private void button_testfirst_Click(object sender, EventArgs e)
        {
            
            conn = new MySqlConnection(webAppConnection_string);
            MySqlCommand cmd = conn.CreateCommand();
            infoLabel = new ToolStripLabel();
            statusStrip_Tests.Items.Clear();
            infoLabel.Text = "Прохождение опредлительного теста";
            statusStrip_Tests.Items.Add(infoLabel);
            cmd.CommandText = "SELECT TestsLink FROM gb_56132.Tests WHERE idTests = '" + 0 + "'";
            string abc;
            try
            {
                conn.Open();
                MySqlDataReader reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {

                    //button_gocourse_html.Text = "Курс по языку программирования:"+reader1.GetValue(0).ToString();
                    abc = reader1.GetValue(0).ToString();
                     System.Diagnostics.Process.Start('"'+abc+'"');

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro);
               
                this.Close();
            }
       
        }

        private void button_htmltest_Click(object sender, EventArgs e)
        {
            if (listBox_OfTests.SelectedItem != null)
            {
                string selectedlangid = listBox_OfTests.SelectedItem.ToString();
                selectedlangid = selectedlangid.Substring(0, selectedlangid.LastIndexOf(' '));
                MessageBox.Show(selectedlangid);
                infoLabel = new ToolStripLabel();
                statusStrip_Tests.Items.Clear();
                infoLabel.Text = "Переход на страницу теста";
                statusStrip_Tests.Items.Add(infoLabel);
                conn = new MySqlConnection(webAppConnection_string);
                MySqlCommand cmd = conn.CreateCommand();

                try
                {
                    conn.Open();
                    cmd.CommandText = "SELECT TestsLink FROM gb_56132.Tests WHERE idTests = '" + selectedlangid + "'";

                    MySqlDataReader reader2 = cmd.ExecuteReader();
                    while (reader2.Read())
                    {
                        //button_gocourse_html.Text = "Курс по языку программирования:"+reader1.GetValue(0).ToString();
                        System.Diagnostics.Process.Start('"' + reader2.GetValue(0).ToString()+'"' );
                      
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro" + erro);
                    this.Close();
                }
              
            }
        }

        private void listBox_OfTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            infoLabel = new ToolStripLabel();
            statusStrip_Tests.Items.Clear();
            infoLabel.Text = "Выбор теста";
            statusStrip_Tests.Items.Add(infoLabel);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
