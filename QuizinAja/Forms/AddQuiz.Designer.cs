namespace QuizinAja.Forms
{
    partial class AddQuiz
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_quizname = new TextBox();
            txt_quizcode = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_description = new TextBox();
            groupBox1 = new GroupBox();
            btn_add = new Button();
            label7 = new Label();
            panel1 = new Panel();
            txt_d = new TextBox();
            txt_c = new TextBox();
            txt_b = new TextBox();
            text_a = new TextBox();
            rb_d = new RadioButton();
            rb_c = new RadioButton();
            rb_b = new RadioButton();
            rb_a = new RadioButton();
            text_question = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            btn_save = new Button();
            btn_cancel = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.75F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 0;
            label1.Text = "Add New Quiz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(173, 19);
            label2.TabIndex = 1;
            label2.Text = "Fill in the quiz detail bellow";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(77, 19);
            label3.TabIndex = 2;
            label3.Text = "Quiz Name";
            // 
            // txt_quizname
            // 
            txt_quizname.Location = new Point(12, 110);
            txt_quizname.Name = "txt_quizname";
            txt_quizname.Size = new Size(255, 23);
            txt_quizname.TabIndex = 3;
            // 
            // txt_quizcode
            // 
            txt_quizcode.Location = new Point(12, 171);
            txt_quizcode.Name = "txt_quizcode";
            txt_quizcode.Size = new Size(255, 23);
            txt_quizcode.TabIndex = 5;
            txt_quizcode.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(12, 149);
            label4.Name = "label4";
            label4.Size = new Size(73, 19);
            label4.TabIndex = 4;
            label4.Text = "Quiz Code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(293, 88);
            label5.Name = "label5";
            label5.Size = new Size(110, 19);
            label5.TabIndex = 6;
            label5.Text = "Quiz Description";
            // 
            // txt_description
            // 
            txt_description.Font = new Font("Segoe UI", 10F);
            txt_description.Location = new Point(293, 110);
            txt_description.Multiline = true;
            txt_description.Name = "txt_description";
            txt_description.ScrollBars = ScrollBars.Vertical;
            txt_description.Size = new Size(579, 84);
            txt_description.TabIndex = 7;
            txt_description.TextChanged += txt_description_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(text_question);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(12, 215);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(860, 397);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Question Data";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(620, 53);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(131, 36);
            btn_add.TabIndex = 5;
            btn_add.Text = "Add Question";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(315, 31);
            label7.Name = "label7";
            label7.Size = new Size(54, 19);
            label7.TabIndex = 4;
            label7.Text = "Awnser";
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_d);
            panel1.Controls.Add(txt_c);
            panel1.Controls.Add(txt_b);
            panel1.Controls.Add(text_a);
            panel1.Controls.Add(rb_d);
            panel1.Controls.Add(rb_c);
            panel1.Controls.Add(rb_b);
            panel1.Controls.Add(rb_a);
            panel1.Location = new Point(315, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 114);
            panel1.TabIndex = 3;
            // 
            // txt_d
            // 
            txt_d.Location = new Point(23, 89);
            txt_d.Name = "txt_d";
            txt_d.Size = new Size(236, 25);
            txt_d.TabIndex = 7;
            // 
            // txt_c
            // 
            txt_c.Location = new Point(23, 58);
            txt_c.Name = "txt_c";
            txt_c.Size = new Size(236, 25);
            txt_c.TabIndex = 6;
            // 
            // txt_b
            // 
            txt_b.Location = new Point(23, 27);
            txt_b.Name = "txt_b";
            txt_b.Size = new Size(236, 25);
            txt_b.TabIndex = 5;
            // 
            // text_a
            // 
            text_a.Location = new Point(23, -2);
            text_a.Name = "text_a";
            text_a.Size = new Size(236, 25);
            text_a.TabIndex = 4;
            // 
            // rb_d
            // 
            rb_d.AutoSize = true;
            rb_d.Location = new Point(3, 91);
            rb_d.Name = "rb_d";
            rb_d.Size = new Size(14, 13);
            rb_d.TabIndex = 3;
            rb_d.TabStop = true;
            rb_d.UseVisualStyleBackColor = true;
            // 
            // rb_c
            // 
            rb_c.AutoSize = true;
            rb_c.Location = new Point(3, 61);
            rb_c.Name = "rb_c";
            rb_c.Size = new Size(14, 13);
            rb_c.TabIndex = 2;
            rb_c.TabStop = true;
            rb_c.UseVisualStyleBackColor = true;
            // 
            // rb_b
            // 
            rb_b.AutoSize = true;
            rb_b.Location = new Point(3, 32);
            rb_b.Name = "rb_b";
            rb_b.Size = new Size(14, 13);
            rb_b.TabIndex = 1;
            rb_b.TabStop = true;
            rb_b.UseVisualStyleBackColor = true;
            // 
            // rb_a
            // 
            rb_a.AutoSize = true;
            rb_a.Location = new Point(3, 3);
            rb_a.Name = "rb_a";
            rb_a.Size = new Size(14, 13);
            rb_a.TabIndex = 0;
            rb_a.TabStop = true;
            rb_a.UseVisualStyleBackColor = true;
            // 
            // text_question
            // 
            text_question.Location = new Point(12, 53);
            text_question.Multiline = true;
            text_question.Name = "text_question";
            text_question.ScrollBars = ScrollBars.Vertical;
            text_question.Size = new Size(269, 114);
            text_question.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 31);
            label6.Name = "label6";
            label6.Size = new Size(65, 19);
            label6.TabIndex = 1;
            label6.Text = "Question";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(832, 188);
            dataGridView1.TabIndex = 0;
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Segoe UI", 10F);
            btn_save.Location = new Point(632, 618);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(117, 31);
            btn_save.TabIndex = 9;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            btn_cancel.Font = new Font("Segoe UI", 10F);
            btn_cancel.Location = new Point(755, 618);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(117, 31);
            btn_cancel.TabIndex = 10;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // AddQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 661);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(groupBox1);
            Controls.Add(txt_description);
            Controls.Add(label5);
            Controls.Add(txt_quizcode);
            Controls.Add(label4);
            Controls.Add(txt_quizname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddQuiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuizinAja - Online Quiz Platform";
            Load += AddQuiz_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_quizname;
        private TextBox txt_quizcode;
        private Label label4;
        private Label label5;
        private TextBox txt_description;
        private GroupBox groupBox1;
        private Button btn_save;
        private Button btn_cancel;
        private TextBox text_question;
        private Label label6;
        private DataGridView dataGridView1;
        private Button btn_add;
        private Label label7;
        private Panel panel1;
        private TextBox txt_d;
        private TextBox txt_c;
        private TextBox txt_b;
        private TextBox text_a;
        private RadioButton rb_d;
        private RadioButton rb_c;
        private RadioButton rb_b;
        private RadioButton rb_a;
    }
}