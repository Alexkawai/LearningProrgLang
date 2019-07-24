namespace WindowsFormsApplicationAlex
{
    partial class Form_goout
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
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_going = new System.Windows.Forms.Button();
            this.button_registration = new System.Windows.Forms.Button();
            this.statusStrip_goout = new System.Windows.Forms.StatusStrip();
            this.pictureBox_Preview = new System.Windows.Forms.PictureBox();
            this.button_image = new System.Windows.Forms.Button();
            this.openFileDialog_goout = new System.Windows.Forms.OpenFileDialog();
            this.textBox_Preview = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Preview)).BeginInit();
            this.SuspendLayout();
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.Location = new System.Drawing.Point(126, 105);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(52, 16);
            this.label_login.TabIndex = 16;
            this.label_login.Text = "Логин";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_password.Location = new System.Drawing.Point(126, 153);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(60, 16);
            this.label_password.TabIndex = 17;
            this.label_password.Text = "Пароль";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(205, 103);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(162, 20);
            this.textBox_login.TabIndex = 18;
            this.textBox_login.TextChanged += new System.EventHandler(this.textBox_login_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(206, 148);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(162, 20);
            this.textBox_password.TabIndex = 19;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // button_going
            // 
            this.button_going.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_going.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_going.Location = new System.Drawing.Point(134, 209);
            this.button_going.Name = "button_going";
            this.button_going.Size = new System.Drawing.Size(98, 29);
            this.button_going.TabIndex = 20;
            this.button_going.Text = "Войти";
            this.button_going.UseVisualStyleBackColor = false;
            this.button_going.Click += new System.EventHandler(this.button_going_Click);
            // 
            // button_registration
            // 
            this.button_registration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_registration.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_registration.Location = new System.Drawing.Point(263, 209);
            this.button_registration.Name = "button_registration";
            this.button_registration.Size = new System.Drawing.Size(98, 29);
            this.button_registration.TabIndex = 21;
            this.button_registration.Text = "Регистрация";
            this.button_registration.UseVisualStyleBackColor = false;
            this.button_registration.Click += new System.EventHandler(this.button_registration_Click);
            // 
            // statusStrip_goout
            // 
            this.statusStrip_goout.Location = new System.Drawing.Point(0, 293);
            this.statusStrip_goout.Name = "statusStrip_goout";
            this.statusStrip_goout.Size = new System.Drawing.Size(497, 22);
            this.statusStrip_goout.TabIndex = 22;
            this.statusStrip_goout.Text = "statusStrip1";
            // 
            // pictureBox_Preview
            // 
            this.pictureBox_Preview.Location = new System.Drawing.Point(106, 12);
            this.pictureBox_Preview.Name = "pictureBox_Preview";
            this.pictureBox_Preview.Size = new System.Drawing.Size(294, 28);
            this.pictureBox_Preview.TabIndex = 23;
            this.pictureBox_Preview.TabStop = false;
            this.pictureBox_Preview.Visible = false;
            // 
            // button_image
            // 
            this.button_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(199)))));
            this.button_image.Location = new System.Drawing.Point(270, 46);
            this.button_image.Name = "button_image";
            this.button_image.Size = new System.Drawing.Size(115, 34);
            this.button_image.TabIndex = 24;
            this.button_image.Text = "Добавить изображение";
            this.button_image.UseVisualStyleBackColor = false;
            this.button_image.Visible = false;
            this.button_image.Click += new System.EventHandler(this.button_image_Click);
            // 
            // openFileDialog_goout
            // 
            this.openFileDialog_goout.FileName = "openFileDialog1";
            // 
            // textBox_Preview
            // 
            this.textBox_Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            this.textBox_Preview.Location = new System.Drawing.Point(108, 54);
            this.textBox_Preview.Name = "textBox_Preview";
            this.textBox_Preview.Size = new System.Drawing.Size(136, 20);
            this.textBox_Preview.TabIndex = 25;
            this.textBox_Preview.Visible = false;
            // 
            // Form_goout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(497, 315);
            this.Controls.Add(this.textBox_Preview);
            this.Controls.Add(this.button_image);
            this.Controls.Add(this.pictureBox_Preview);
            this.Controls.Add(this.statusStrip_goout);
            this.Controls.Add(this.button_registration);
            this.Controls.Add(this.button_going);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Name = "Form_goout";
            this.Text = "Form_goout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_going;
        private System.Windows.Forms.Button button_registration;
        private System.Windows.Forms.StatusStrip statusStrip_goout;
        private System.Windows.Forms.PictureBox pictureBox_Preview;
        private System.Windows.Forms.Button button_image;
        private System.Windows.Forms.OpenFileDialog openFileDialog_goout;
        private System.Windows.Forms.TextBox textBox_Preview;
    }
}