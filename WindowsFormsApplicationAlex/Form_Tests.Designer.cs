namespace WindowsFormsApplicationAlex
{
    partial class Form_Tests
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
            this.button_testfirst = new System.Windows.Forms.Button();
            this.button_htmltest = new System.Windows.Forms.Button();
            this.button_goout = new System.Windows.Forms.Button();
            this.listBox_OfTests = new System.Windows.Forms.ListBox();
            this.label_quest = new System.Windows.Forms.Label();
            this.statusStrip_Tests = new System.Windows.Forms.StatusStrip();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_testfirst
            // 
            this.button_testfirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_testfirst.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_testfirst.Location = new System.Drawing.Point(426, 141);
            this.button_testfirst.Name = "button_testfirst";
            this.button_testfirst.Size = new System.Drawing.Size(142, 134);
            this.button_testfirst.TabIndex = 13;
            this.button_testfirst.Text = "Определительный тест";
            this.button_testfirst.UseVisualStyleBackColor = false;
            this.button_testfirst.Click += new System.EventHandler(this.button_testfirst_Click);
            // 
            // button_htmltest
            // 
            this.button_htmltest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_htmltest.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_htmltest.Location = new System.Drawing.Point(71, 308);
            this.button_htmltest.Name = "button_htmltest";
            this.button_htmltest.Size = new System.Drawing.Size(240, 41);
            this.button_htmltest.TabIndex = 14;
            this.button_htmltest.Text = "Начать тест";
            this.button_htmltest.UseVisualStyleBackColor = false;
            this.button_htmltest.Click += new System.EventHandler(this.button_htmltest_Click);
            // 
            // button_goout
            // 
            this.button_goout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_goout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_goout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_goout.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_goout.Location = new System.Drawing.Point(570, 12);
            this.button_goout.Name = "button_goout";
            this.button_goout.Size = new System.Drawing.Size(76, 27);
            this.button_goout.TabIndex = 15;
            this.button_goout.Text = "Выход";
            this.button_goout.UseVisualStyleBackColor = false;
            this.button_goout.Click += new System.EventHandler(this.button_goout_Click);
            // 
            // listBox_OfTests
            // 
            this.listBox_OfTests.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_OfTests.FormattingEnabled = true;
            this.listBox_OfTests.ItemHeight = 16;
            this.listBox_OfTests.Items.AddRange(new object[] {
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
            this.listBox_OfTests.Location = new System.Drawing.Point(151, 138);
            this.listBox_OfTests.Name = "listBox_OfTests";
            this.listBox_OfTests.Size = new System.Drawing.Size(95, 164);
            this.listBox_OfTests.TabIndex = 16;
            this.listBox_OfTests.SelectedIndexChanged += new System.EventHandler(this.listBox_OfTests_SelectedIndexChanged);
            // 
            // label_quest
            // 
            this.label_quest.AutoSize = true;
            this.label_quest.Font = new System.Drawing.Font("Century", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_quest.Location = new System.Drawing.Point(68, 99);
            this.label_quest.Name = "label_quest";
            this.label_quest.Size = new System.Drawing.Size(300, 16);
            this.label_quest.TabIndex = 17;
            this.label_quest.Text = "Какой тест выжелаете пройти сегодня? :)";
            // 
            // statusStrip_Tests
            // 
            this.statusStrip_Tests.Location = new System.Drawing.Point(0, 421);
            this.statusStrip_Tests.Name = "statusStrip_Tests";
            this.statusStrip_Tests.Size = new System.Drawing.Size(658, 22);
            this.statusStrip_Tests.TabIndex = 18;
            this.statusStrip_Tests.Text = "statusStrip1";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.Location = new System.Drawing.Point(39, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(76, 27);
            this.button_back.TabIndex = 19;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Form_Tests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(658, 443);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.statusStrip_Tests);
            this.Controls.Add(this.label_quest);
            this.Controls.Add(this.listBox_OfTests);
            this.Controls.Add(this.button_goout);
            this.Controls.Add(this.button_htmltest);
            this.Controls.Add(this.button_testfirst);
            this.Name = "Form_Tests";
            this.Text = "Form_Tests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_testfirst;
        private System.Windows.Forms.Button button_htmltest;
        private System.Windows.Forms.Button button_goout;
        private System.Windows.Forms.ListBox listBox_OfTests;
        private System.Windows.Forms.Label label_quest;
        private System.Windows.Forms.StatusStrip statusStrip_Tests;
        private System.Windows.Forms.Button button_back;
    }
}