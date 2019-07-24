using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplicationAlex
{
    public partial class Form_Account : Form
    {
        string webAppConnection_string = "server=mysql101.1gb.ru;user ID=gb_56132;Password=e26ca36ba;database=gb_56132;";
        MySqlConnection conn;
        ToolStripLabel infoLabel;
        public Form_goout f_goout = new Form_goout();
        public Form_Account()
        {
            InitializeComponent();
            
        }
        public static string getdata;
        public static string getdata1;
        private void Form_Account_Load(object sender, EventArgs e)
        {
            label_List.Text += getdata1 + ":";
        }
        
        private void button_goout_Click(object sender, EventArgs e)
        {
            Form_goout f_goout = new Form_goout();
            f_goout.ShowDialog();
            this.Hide();
            infoLabel = new ToolStripLabel();
            statusStrip_account.Items.Clear();
            infoLabel.Text = "Выход из программы";
            statusStrip_account.Items.Add(infoLabel);
        }

        private void button_gocourse_html_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(webAppConnection_string);           
            MySqlCommand cmd = conn.CreateCommand();
            infoLabel = new ToolStripLabel();
            statusStrip_account.Items.Clear();
            infoLabel.Text = "Переход для прохождения курсов";
            statusStrip_account.Items.Add(infoLabel);
            cmd.CommandText = "SELECT CoursesLink FROM gb_56132.Courses WHERE idCourses = '" + getdata + "'";
            try
            {
                conn.Open();
                

                MySqlDataReader reader2 = cmd.ExecuteReader();
                while (reader2.Read())
                {
                    //button_gocourse_html.Text = "Курс по языку программирования:"+reader1.GetValue(0).ToString();
                   
                    System.Diagnostics.Process.Start('"'+reader2.GetValue(0).ToString()+'"');

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro);
                this.Close();
            }
           
        }

        private void Form_Account_MouseMove(object sender, MouseEventArgs e)
        {
            conn = new MySqlConnection(webAppConnection_string);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT CoursesName FROM gb_56132.Courses WHERE idCourses = '" + getdata + "'";
            
            try
            {
                conn.Open();
                MySqlDataReader reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    button_gocourse_html.Text = "Курс по языку программирования:" + reader1.GetValue(0).ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro);
                this.Close();
            }
            
            
         
        }

        private void button_hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        }

       
    }

