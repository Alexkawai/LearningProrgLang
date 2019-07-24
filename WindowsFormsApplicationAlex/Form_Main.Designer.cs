namespace WindowsFormsApplicationAlex
{
    partial class Form_Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_account = new System.Windows.Forms.Button();
            this.button_tests = new System.Windows.Forms.Button();
            this.label_text = new System.Windows.Forms.Label();
            this.button_get = new System.Windows.Forms.Button();
            this.listBox_SearchOfLang = new System.Windows.Forms.ListBox();
            this.statusStrip_main = new System.Windows.Forms.StatusStrip();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_vvod = new System.Windows.Forms.Button();
            this.label_vvedite = new System.Windows.Forms.Label();
            this.dataGridView_lang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lang)).BeginInit();
            this.SuspendLayout();
            // 
            // button_account
            // 
            this.button_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_account.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_account.Location = new System.Drawing.Point(37, 14);
            this.button_account.Name = "button_account";
            this.button_account.Size = new System.Drawing.Size(76, 27);
            this.button_account.TabIndex = 1;
            this.button_account.Text = "Аккаунт";
            this.button_account.UseVisualStyleBackColor = false;
            this.button_account.Click += new System.EventHandler(this.button_account_Click);
            // 
            // button_tests
            // 
            this.button_tests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_tests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_tests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tests.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tests.Location = new System.Drawing.Point(137, 14);
            this.button_tests.Name = "button_tests";
            this.button_tests.Size = new System.Drawing.Size(76, 27);
            this.button_tests.TabIndex = 3;
            this.button_tests.Text = "Тесты";
            this.button_tests.UseVisualStyleBackColor = false;
            this.button_tests.Click += new System.EventHandler(this.button_tests_Click);
            // 
            // label_text
            // 
            this.label_text.AutoEllipsis = true;
            this.label_text.AutoSize = true;
            this.label_text.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_text.Location = new System.Drawing.Point(22, 288);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(249, 16);
            this.label_text.TabIndex = 7;
            this.label_text.Text = "Текс об этом языке программирования";
            // 
            // button_get
            // 
            this.button_get.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_get.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_get.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_get.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_get.Location = new System.Drawing.Point(86, 347);
            this.button_get.Name = "button_get";
            this.button_get.Size = new System.Drawing.Size(104, 27);
            this.button_get.TabIndex = 8;
            this.button_get.Text = "ПОЛУЧИТЬ";
            this.button_get.UseVisualStyleBackColor = false;
            this.button_get.Click += new System.EventHandler(this.button_get_Click);
            // 
            // listBox_SearchOfLang
            // 
            this.listBox_SearchOfLang.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_SearchOfLang.FormattingEnabled = true;
            this.listBox_SearchOfLang.ItemHeight = 16;
            this.listBox_SearchOfLang.Items.AddRange(new object[] {
            "1 HTML",
            "2 CSS",
            "3 JavaScript",
            "4 Java",
            "5 Python",
            "6 Ruby",
            "7 C#",
            "8 C++",
            "9 SQL",
            "10 Swift"});
            this.listBox_SearchOfLang.Location = new System.Drawing.Point(86, 84);
            this.listBox_SearchOfLang.Name = "listBox_SearchOfLang";
            this.listBox_SearchOfLang.Size = new System.Drawing.Size(104, 164);
            this.listBox_SearchOfLang.TabIndex = 9;
            this.listBox_SearchOfLang.SelectedIndexChanged += new System.EventHandler(this.listBox_SearchOfLang_SelectedIndexChanged);
            // 
            // statusStrip_main
            // 
            this.statusStrip_main.Location = new System.Drawing.Point(0, 421);
            this.statusStrip_main.Name = "statusStrip_main";
            this.statusStrip_main.Size = new System.Drawing.Size(658, 22);
            this.statusStrip_main.TabIndex = 10;
            this.statusStrip_main.Text = "statusStrip1";
            // 
            // textBox_search
            // 
            this.textBox_search.AutoCompleteCustomSource.AddRange(new string[] {
            "Введите название курса"});
            this.textBox_search.Location = new System.Drawing.Point(377, 305);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(198, 20);
            this.textBox_search.TabIndex = 11;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // button_vvod
            // 
            this.button_vvod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_vvod.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_vvod.Location = new System.Drawing.Point(420, 347);
            this.button_vvod.Name = "button_vvod";
            this.button_vvod.Size = new System.Drawing.Size(108, 27);
            this.button_vvod.TabIndex = 12;
            this.button_vvod.Text = "Поиск";
            this.button_vvod.UseVisualStyleBackColor = false;
            this.button_vvod.Click += new System.EventHandler(this.button_vvod_Click);
            // 
            // label_vvedite
            // 
            this.label_vvedite.AutoSize = true;
            this.label_vvedite.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_vvedite.Location = new System.Drawing.Point(285, 19);
            this.label_vvedite.Name = "label_vvedite";
            this.label_vvedite.Size = new System.Drawing.Size(361, 16);
            this.label_vvedite.TabIndex = 13;
            this.label_vvedite.Text = "Введите название языка, чтобы посмотреть информацию";
            // 
            // dataGridView_lang
            // 
            this.dataGridView_lang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(167)))));
            this.dataGridView_lang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_lang.Location = new System.Drawing.Point(316, 46);
            this.dataGridView_lang.Name = "dataGridView_lang";
            this.dataGridView_lang.Size = new System.Drawing.Size(309, 237);
            this.dataGridView_lang.TabIndex = 14;
            this.dataGridView_lang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_lang_CellContentClick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(177)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(658, 443);
            this.Controls.Add(this.dataGridView_lang);
            this.Controls.Add(this.label_vvedite);
            this.Controls.Add(this.button_vvod);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.statusStrip_main);
            this.Controls.Add(this.listBox_SearchOfLang);
            this.Controls.Add(this.button_get);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.button_tests);
            this.Controls.Add(this.button_account);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_account;
        private System.Windows.Forms.Button button_tests;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.Button button_get;
        private System.Windows.Forms.ListBox listBox_SearchOfLang;
        private System.Windows.Forms.StatusStrip statusStrip_main;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_vvod;
        private System.Windows.Forms.Label label_vvedite;
        private System.Windows.Forms.DataGridView dataGridView_lang;
    }
}

