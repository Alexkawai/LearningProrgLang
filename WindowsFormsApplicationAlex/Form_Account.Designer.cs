namespace WindowsFormsApplicationAlex
{
    partial class Form_Account
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
            this.button_gocourse_html = new System.Windows.Forms.Button();
            this.label_List = new System.Windows.Forms.Label();
            this.button_goout = new System.Windows.Forms.Button();
            this.statusStrip_account = new System.Windows.Forms.StatusStrip();
            this.button_hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_gocourse_html
            // 
            this.button_gocourse_html.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_gocourse_html.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_gocourse_html.Location = new System.Drawing.Point(62, 214);
            this.button_gocourse_html.Name = "button_gocourse_html";
            this.button_gocourse_html.Size = new System.Drawing.Size(535, 43);
            this.button_gocourse_html.TabIndex = 12;
            this.button_gocourse_html.Text = "Курс по языку программирования";
            this.button_gocourse_html.UseVisualStyleBackColor = false;
            this.button_gocourse_html.Click += new System.EventHandler(this.button_gocourse_html_Click);
            // 
            // label_List
            // 
            this.label_List.AutoSize = true;
            this.label_List.Font = new System.Drawing.Font("Century", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_List.Location = new System.Drawing.Point(253, 162);
            this.label_List.Name = "label_List";
            this.label_List.Size = new System.Drawing.Size(161, 16);
            this.label_List.TabIndex = 11;
            this.label_List.Text = "Ваш выбранный курс";
            // 
            // button_goout
            // 
            this.button_goout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_goout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_goout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_goout.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_goout.Location = new System.Drawing.Point(559, 14);
            this.button_goout.Name = "button_goout";
            this.button_goout.Size = new System.Drawing.Size(76, 27);
            this.button_goout.TabIndex = 8;
            this.button_goout.Text = "Выход";
            this.button_goout.UseVisualStyleBackColor = false;
            this.button_goout.Click += new System.EventHandler(this.button_goout_Click);
            // 
            // statusStrip_account
            // 
            this.statusStrip_account.Location = new System.Drawing.Point(0, 421);
            this.statusStrip_account.Name = "statusStrip_account";
            this.statusStrip_account.Size = new System.Drawing.Size(658, 22);
            this.statusStrip_account.TabIndex = 13;
            this.statusStrip_account.Text = "statusStrip1";
            // 
            // button_hide
            // 
            this.button_hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hide.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_hide.Location = new System.Drawing.Point(27, 14);
            this.button_hide.Name = "button_hide";
            this.button_hide.Size = new System.Drawing.Size(76, 27);
            this.button_hide.TabIndex = 14;
            this.button_hide.Text = "Назад";
            this.button_hide.UseVisualStyleBackColor = false;
            this.button_hide.Click += new System.EventHandler(this.button_hide_Click);
            // 
            // Form_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(658, 443);
            this.Controls.Add(this.button_hide);
            this.Controls.Add(this.statusStrip_account);
            this.Controls.Add(this.button_gocourse_html);
            this.Controls.Add(this.label_List);
            this.Controls.Add(this.button_goout);
            this.Name = "Form_Account";
            this.Text = "Form_Account";
            this.Load += new System.EventHandler(this.Form_Account_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Account_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_gocourse_html;
        private System.Windows.Forms.Label label_List;
        private System.Windows.Forms.Button button_goout;
        private System.Windows.Forms.StatusStrip statusStrip_account;
        private System.Windows.Forms.Button button_hide;
    }
}