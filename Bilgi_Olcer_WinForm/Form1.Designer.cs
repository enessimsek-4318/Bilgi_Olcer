namespace Bilgi_Olcer_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.question_list = new System.Windows.Forms.ListView();
            this.Sınıf = new System.Windows.Forms.ColumnHeader();
            this.Ders = new System.Windows.Forms.ColumnHeader();
            this.Konu = new System.Windows.Forms.ColumnHeader();
            this.Soru = new System.Windows.Forms.ColumnHeader();
            this.Cevap = new System.Windows.Forms.ColumnHeader();
            this.Grade_combobox = new System.Windows.Forms.ComboBox();
            this.Lesson_combobox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // question_list
            // 
            this.question_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sınıf,
            this.Ders,
            this.Konu,
            this.Soru,
            this.Cevap});
            this.question_list.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.question_list.Location = new System.Drawing.Point(12, 51);
            this.question_list.Name = "question_list";
            this.question_list.Size = new System.Drawing.Size(1229, 387);
            this.question_list.TabIndex = 0;
            this.question_list.TileSize = new System.Drawing.Size(300, 50);
            this.question_list.UseCompatibleStateImageBehavior = false;
            this.question_list.View = System.Windows.Forms.View.Details;
            this.question_list.VirtualListSize = 1;
            this.question_list.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Sınıf
            // 
            this.Sınıf.Text = "Sınıf";
            // 
            // Ders
            // 
            this.Ders.Text = "Ders";
            // 
            // Konu
            // 
            this.Konu.Text = "Konu";
            // 
            // Soru
            // 
            this.Soru.Text = "Soru";
            // 
            // Cevap
            // 
            this.Cevap.Text = "Cevap";
            // 
            // Grade_combobox
            // 
            this.Grade_combobox.FormattingEnabled = true;
            this.Grade_combobox.Location = new System.Drawing.Point(175, 22);
            this.Grade_combobox.Name = "Grade_combobox";
            this.Grade_combobox.Size = new System.Drawing.Size(121, 23);
            this.Grade_combobox.TabIndex = 1;
            // 
            // Lesson_combobox
            // 
            this.Lesson_combobox.FormattingEnabled = true;
            this.Lesson_combobox.Location = new System.Drawing.Point(302, 22);
            this.Lesson_combobox.Name = "Lesson_combobox";
            this.Lesson_combobox.Size = new System.Drawing.Size(121, 23);
            this.Lesson_combobox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(510, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(591, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(672, 22);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(75, 23);
            this.btn_list.TabIndex = 6;
            this.btn_list.Text = "Listele";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 450);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lesson_combobox);
            this.Controls.Add(this.Grade_combobox);
            this.Controls.Add(this.question_list);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView question_list;
        private ComboBox Grade_combobox;
        private ComboBox Lesson_combobox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btn_list;
        private ColumnHeader Sınıf;
        private ColumnHeader Ders;
        private ColumnHeader Konu;
        private ColumnHeader Soru;
        private ColumnHeader Cevap;
    }
}