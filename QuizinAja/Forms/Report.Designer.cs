namespace QuizinAja.Forms
{
    partial class Report
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
            combo_quiz = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            time = new Label();
            persen = new Label();
            parti = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 0;
            label1.Text = "View Quiz Report";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(37, 19);
            label2.TabIndex = 1;
            label2.Text = "Quiz";
            // 
            // combo_quiz
            // 
            combo_quiz.FormattingEnabled = true;
            combo_quiz.Location = new Point(55, 47);
            combo_quiz.Name = "combo_quiz";
            combo_quiz.Size = new Size(265, 23);
            combo_quiz.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(374, 48);
            label3.Name = "label3";
            label3.Size = new Size(137, 19);
            label3.TabIndex = 3;
            label3.Text = "Average Time Taken :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(374, 76);
            label4.Name = "label4";
            label4.Size = new Size(186, 19);
            label4.TabIndex = 4;
            label4.Text = "Average Correct Percentage :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(374, 106);
            label5.Name = "label5";
            label5.Size = new Size(114, 19);
            label5.TabIndex = 5;
            label5.Text = "Total Participant :";
            // 
            // time
            // 
            time.AutoSize = true;
            time.Font = new Font("Segoe UI", 10F);
            time.Location = new Point(517, 51);
            time.Name = "time";
            time.Size = new Size(36, 19);
            time.TabIndex = 6;
            time.Text = "time";
            time.Click += label6_Click;
            // 
            // persen
            // 
            persen.AutoSize = true;
            persen.Font = new Font("Segoe UI", 10F);
            persen.Location = new Point(566, 76);
            persen.Name = "persen";
            persen.Size = new Size(50, 19);
            persen.TabIndex = 7;
            persen.Text = "persen";
            // 
            // parti
            // 
            parti.AutoSize = true;
            parti.Font = new Font("Segoe UI", 10F);
            parti.Location = new Point(494, 106);
            parti.Name = "parti";
            parti.Size = new Size(37, 19);
            parti.TabIndex = 8;
            parti.Text = "parti";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(860, 409);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detail Data";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(848, 381);
            dataGridView1.TabIndex = 0;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(groupBox1);
            Controls.Add(parti);
            Controls.Add(persen);
            Controls.Add(time);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(combo_quiz);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Report";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuizinAja - Online Quiz Platform";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox combo_quiz;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label time;
        private Label persen;
        private Label parti;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
    }
}