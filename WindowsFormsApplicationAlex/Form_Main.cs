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
    public partial class Form_Main : Form
    {
        string webAppConnection_string = "server=mysql101.1gb.ru;user ID=gb_56132;Password=e26ca36ba;database=gb_56132;";
        ToolStripLabel infoLabel;
        MySqlConnection conn;
     //   MySqlCommand cmd;
        public Form_Account f_account = new Form_Account();
        public Form_Tests f_tests = new Form_Tests();
        public Form_Main()
        {
            InitializeComponent();
        }

       
        private void button_account_Click(object sender, EventArgs e)
        {
            Form_Account f_account = new Form_Account();
            if (f_account.ShowDialog(this) == DialogResult.OK)
            {
               
                infoLabel = new ToolStripLabel();
                statusStrip_main.Items.Clear();
                infoLabel.Text = "Переход на страницу аккаунта";
                statusStrip_main.Items.Add(infoLabel);
            }
            
           
        }

        private void button_tests_Click(object sender, EventArgs e)
        {
            Form_Tests f_tests = new Form_Tests();
            if (f_tests.ShowDialog(this) == DialogResult.OK)
            {
                
                infoLabel = new ToolStripLabel();
                statusStrip_main.Items.Clear();
                infoLabel.Text = "Переход на страницу тестов";
                statusStrip_main.Items.Add(infoLabel);
            }
            
        }

        private void listBox_SearchOfLang_SelectedIndexChanged(object sender, EventArgs e)
        {
           string selectedlangid = listBox_SearchOfLang.SelectedItem.ToString();
           selectedlangid = selectedlangid.Substring(0, selectedlangid.LastIndexOf(' ') );
             conn = new MySqlConnection(webAppConnection_string);
             infoLabel = new ToolStripLabel();
             statusStrip_main.Items.Clear();
             infoLabel.Text = "Выбор языка программирования";
             statusStrip_main.Items.Add(infoLabel);

             MySqlCommand cmd = conn.CreateCommand();
             cmd.CommandText = "SELECT ShortDiscript FROM gb_56132.Courses WHERE idCourses = '" + selectedlangid + "'";

             try
             {
                 conn.Open();
                 MySqlDataReader reader = cmd.ExecuteReader();

                 while (reader.Read())
                 {
                     label_text.Text = reader.GetValue(0).ToString();
                 }
             }
             catch (Exception erro)
             {
                 MessageBox.Show("Erro" + erro);
                 this.Close();
             }

        
        }
        

        private void button_get_Click(object sender, EventArgs e)
        {
            if (listBox_SearchOfLang.SelectedItem != null)
            {
                string selectedlangid = listBox_SearchOfLang.SelectedItem.ToString();
                selectedlangid = selectedlangid.Substring(0, selectedlangid.LastIndexOf(' '));
                Form_Account.getdata = selectedlangid;
                f_account.ShowDialog(this);
                infoLabel = new ToolStripLabel();
                statusStrip_main.Items.Clear();
                infoLabel.Text = "Переход на страницу аккаунта для прохождения курса";
                statusStrip_main.Items.Add(infoLabel);
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            infoLabel = new ToolStripLabel();
            statusStrip_main.Items.Clear();
            infoLabel.Text = "Ввод языка программирования";
            statusStrip_main.Items.Add(infoLabel);
        }

        private void button_vvod_Click(object sender, EventArgs e)
        { 
                    
             string podstroka = textBox_search.Text;
             conn = new MySqlConnection(webAppConnection_string);           
            MySqlCommand cmd = conn.CreateCommand();
            infoLabel = new ToolStripLabel();
            statusStrip_main.Items.Clear();
            infoLabel.Text = "Просмотр информации языка";
            statusStrip_main.Items.Add(infoLabel);
           
             MySqlDataAdapter select_adapter = new MySqlDataAdapter();
             string select_string = "SELECT idCourses,CoursesName,ShortDiscript,Coursesimage FROM gb_56132.Courses WHERE CoursesName Like '%" + podstroka + "%'";
             select_adapter.SelectCommand = new MySqlCommand(select_string, conn);

             DataTable table = new DataTable();
             select_adapter.Fill(table);

             BindingSource bSource = new BindingSource();
             bSource.DataSource = table;
             dataGridView_lang.DataSource = table;
        }

        private void dataGridView_lang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        }
       
    }

