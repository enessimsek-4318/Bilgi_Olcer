namespace Bilgi_Olcer_WinForm
{
    partial class Form3
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
            this.txt_Text = new System.Windows.Forms.RichTextBox();
            this.txt_E = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.txt_D = new System.Windows.Forms.TextBox();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.txt_C = new System.Windows.Forms.TextBox();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.txt_Lesson = new System.Windows.Forms.TextBox();
            this.txt_Grade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Text
            // 
            this.txt_Text.Location = new System.Drawing.Point(12, 103);
            this.txt_Text.Name = "txt_Text";
            this.txt_Text.Size = new System.Drawing.Size(344, 96);
            this.txt_Text.TabIndex = 24;
            this.txt_Text.Text = "";
            // 
            // txt_E
            // 
            this.txt_E.Location = new System.Drawing.Point(12, 321);
            this.txt_E.Name = "txt_E";
            this.txt_E.Size = new System.Drawing.Size(344, 23);
            this.txt_E.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Dosya Seç";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_Answer
            // 
            this.txt_Answer.Location = new System.Drawing.Point(12, 350);
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.Size = new System.Drawing.Size(344, 23);
            this.txt_Answer.TabIndex = 20;
            // 
            // txt_D
            // 
            this.txt_D.Location = new System.Drawing.Point(12, 292);
            this.txt_D.Name = "txt_D";
            this.txt_D.Size = new System.Drawing.Size(344, 23);
            this.txt_D.TabIndex = 19;
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(12, 234);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(344, 23);
            this.txt_B.TabIndex = 18;
            // 
            // txt_C
            // 
            this.txt_C.Location = new System.Drawing.Point(12, 263);
            this.txt_C.Name = "txt_C";
            this.txt_C.Size = new System.Drawing.Size(344, 23);
            this.txt_C.TabIndex = 17;
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(12, 205);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(344, 23);
            this.txt_A.TabIndex = 16;
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(12, 74);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(344, 23);
            this.txt_Subject.TabIndex = 15;
            // 
            // txt_Lesson
            // 
            this.txt_Lesson.Location = new System.Drawing.Point(12, 45);
            this.txt_Lesson.Name = "txt_Lesson";
            this.txt_Lesson.Size = new System.Drawing.Size(344, 23);
            this.txt_Lesson.TabIndex = 25;
            // 
            // txt_Grade
            // 
            this.txt_Grade.Location = new System.Drawing.Point(12, 16);
            this.txt_Grade.Name = "txt_Grade";
            this.txt_Grade.Size = new System.Drawing.Size(344, 23);
            this.txt_Grade.TabIndex = 26;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.txt_Grade);
            this.Controls.Add(this.txt_Lesson);
            this.Controls.Add(this.txt_Text);
            this.Controls.Add(this.txt_E);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Answer);
            this.Controls.Add(this.txt_D);
            this.Controls.Add(this.txt_B);
            this.Controls.Add(this.txt_C);
            this.Controls.Add(this.txt_A);
            this.Controls.Add(this.txt_Subject);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox txt_Text;
        private TextBox txt_E;
        private Button button2;
        private Button button1;
        private TextBox txt_Answer;
        private TextBox txt_D;
        private TextBox txt_B;
        private TextBox txt_C;
        private TextBox txt_A;
        private TextBox txt_Subject;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox txt_Lesson;
        private TextBox txt_Grade;
    }
}