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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.question_list = new System.Windows.Forms.ListView();
            this.Sınıf = new System.Windows.Forms.ColumnHeader();
            this.Ders = new System.Windows.Forms.ColumnHeader();
            this.Konu = new System.Windows.Forms.ColumnHeader();
            this.Soru = new System.Windows.Forms.ColumnHeader();
            this.Cevap = new System.Windows.Forms.ColumnHeader();
            this.Grade_combobox = new System.Windows.Forms.ComboBox();
            this.Lesson_combobox = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
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
            listViewItem4});
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
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(429, 21);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Ekle";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(510, 22);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Güncelle";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(591, 22);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Sil";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
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
        private Button btn_add;
        private Button btn_edit;
        private Button btn_delete;
        private Button btn_list;
        private ColumnHeader Sınıf;
        private ColumnHeader Ders;
        private ColumnHeader Konu;
        private ColumnHeader Soru;
        private ColumnHeader Cevap;
    }
}