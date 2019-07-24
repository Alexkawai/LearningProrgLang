using System;
using System.IO;
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
    public partial class Form_goout : Form
    {
       public string webAppConnection_string = "server=mysql101.1gb.ru;user ID=gb_56132;Password=e26ca36ba;database=gb_56132;";
        ToolStripLabel infoLabel;
        MySqlConnection conn;
        MySqlCommand cmd;

        public Form_goout()
        {
            InitializeComponent();
        }
        public bool InsertDB(int id_int, string login_string, string password_string)
        {
            conn = new MySqlConnection(webAppConnection_string);
            conn.Open();

            //string query_str = "INSERT INTO gb_host01.gps_software (gps_software_id, gps_software_name) VALUE (13, 'Mio');";
            string query_str = "INSERT INTO gb_56132.Users (	idUsers,UsersName,Password,Recomendation) VALUE (";
            query_str += id_int.ToString() + ",'" + login_string.ToString() + "','" + password_string + "'," + 2 + ");";
            cmd = new MySqlCommand(query_str, conn);

            MySqlDataReader data_reader;
            try
            {
                data_reader = cmd.ExecuteReader();
                return true;
            }
            catch (Exception exp)
            {
                string err_string = "Данные не записаны! Сообщение системы\n\"" + exp.ToString() + "\"";
                MessageBox.Show(err_string, "Ошибка записи", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }



        private void textBox_login_TextChanged(object sender, EventArgs e)
        {
            infoLabel = new ToolStripLabel();
            statusStrip_goout.Items.Clear();
            infoLabel.Text = "Ввод логина";
            statusStrip_goout.Items.Add(infoLabel);
        }

        private void button_registration_Click(object sender, EventArgs e)
        {
            //InsertDB(13, "Mio");
            string login_string = textBox_login.Text;
            string password_string = textBox_password.Text;
            int id_int = 14;


            InsertDB(id_int, login_string, password_string); // пытаемся добавить строку в таблицу вендоров
            infoLabel = new ToolStripLabel();
            statusStrip_goout.Items.Clear();
            infoLabel.Text = "Регистрация пользователя";
            statusStrip_goout.Items.Add(infoLabel);
        }

        private void button_going_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(webAppConnection_string);
            conn.Open();
            infoLabel = new ToolStripLabel();
            statusStrip_goout.Items.Clear();
            infoLabel.Text = "Авторизация пользователя";
            statusStrip_goout.Items.Add(infoLabel);
            conn = new MySqlConnection(webAppConnection_string);
            MySqlCommand cmd = conn.CreateCommand();
            string login_string = textBox_login.Text;
            string passwaord_string = textBox_password.Text;

            Form_Account.getdata1 = login_string;
            cmd.CommandText = "SELECT COUNT(UsersName)+COUNT(Password) FROM gb_56132.Users WHERE UsersName ='" + login_string + "'and Password='" + passwaord_string + "'";
            try
            {
                conn.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro);
                this.Close();
            }
            MySqlDataReader reader2 = cmd.ExecuteReader();
            while (reader2.Read())
            {
                int vot;
                Int32.TryParse(reader2.GetValue(0).ToString(), out vot);

                if (vot == 0)
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
                else
                {
                    Form_Main FM = new Form_Main();
                    FM.Show();
                    this.Hide();
                }
            }
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            infoLabel = new ToolStripLabel();
            statusStrip_goout.Items.Clear();
            infoLabel.Text = "Ввод пароля";
            statusStrip_goout.Items.Add(infoLabel);
        }

        private void button_image_Click(object sender, EventArgs e)
        {
             OpenFileDialog ofd = new OpenFileDialog(); 
             ofd.Filter = "Выберите изображение(*.JPG; *.PNG) |*.jpg; *.png;";
              if(ofd.ShowDialog() == DialogResult.OK) { 
                  string pathfilename = ofd.FileName;
                  pictureBox_Preview.Image = Image.FromFile(pathfilename); 
                  string filename = Path.GetFileNameWithoutExtension(pathfilename); 
                  textBox_Preview.Text = filename;
                  UpdateImage(pathfilename, filename); }
              }
          
          public bool UpdateImage(string str_filename, string str_key_value)
          {
              conn = new MySqlConnection(webAppConnection_string);
              conn.Open();

              try
              {
                  MemoryStream ms = new MemoryStream();
               //   string bmp_name = @"D:\Portable\Images\Garmin eTrex 20x.png";
                  Bitmap im = new Bitmap(str_filename);

                  float scaleHeight = (float)100 / (float)im.Height;
                  float scaleWidth = (float)100 / (float)im.Width;
                  float scale = Math.Min(scaleHeight, scaleWidth);
                  int new_width = (int)(im.Width * scale);
                  int new_height = (int)(im.Height * scale);
                  Image new_im = new Bitmap(im, new Size(new_width, new_height));

                  string tmp_name = "tmp.png";
                  new_im.Save(tmp_name);

                  Bitmap upd_im = new Bitmap(tmp_name);

                  upd_im.Save(ms, upd_im.RawFormat);
                  byte[] img = ms.ToArray();

                  MySqlCommand command = new MySqlCommand("UPDATE Users SET UserImage = @UserImage WHERE idUsers = @idUsers;", conn);
                  command.Parameters.Add("@idUsers", MySqlDbType.VarChar).Value = str_key_value;
                  command.Parameters.Add("@UserImage", MySqlDbType.Blob).Value = img;


                  if (command.ExecuteNonQuery() == 1)
                  {
                      MessageBox.Show("Запрос выполнен");
                  }
                  else
                  {
                      MessageBox.Show("Запрос не выполнен");
                  }

                  conn.Close();
                return true;
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);
                return false;
              }
              finally
              {
                  if (conn.State == ConnectionState.Open)
                  {
                      conn.Close();
                  }
              }
          }

        }
    }

