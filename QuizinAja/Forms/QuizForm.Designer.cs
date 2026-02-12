namespace QuizinAja.Forms
{
    partial class QuizForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            btn_prev = new Button();
            btn_next = new Button();
            label2 = new Label();
            timer = new Label();
            label1 = new Label();
            username = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txt_soal = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(timer);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(username);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 561);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_soal);
            panel2.Controls.Add(btn_next);
            panel2.Controls.Add(btn_prev);
            panel2.Location = new Point(308, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(564, 537);
            panel2.TabIndex = 17;
            // 
            // btn_prev
            // 
            btn_prev.Location = new Point(3, 503);
            btn_prev.Name = "btn_prev";
            btn_prev.Size = new Size(120, 31);
            btn_prev.TabIndex = 0;
            btn_prev.Text = "Prev";
            btn_prev.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(441, 503);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(120, 31);
            btn_next.TabIndex = 1;
            btn_next.Text = "Next";
            btn_next.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 111);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 19;
            label2.Text = "Question List";
            // 
            // timer
            // 
            timer.AutoSize = true;
            timer.Location = new Point(90, 35);
            timer.Name = "timer";
            timer.Size = new Size(35, 15);
            timer.TabIndex = 18;
            timer.Text = "timer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 35);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 17;
            label1.Text = "Time Elapse :";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username.Location = new Point(3, 0);
            username.Name = "username";
            username.Size = new Size(106, 30);
            username.TabIndex = 16;
            username.Text = "username";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(8, 129);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(294, 420);
            flowLayoutPanel1.TabIndex = 20;
            // 
            // txt_soal
            // 
            txt_soal.Location = new Point(17, 23);
            txt_soal.Name = "txt_soal";
            txt_soal.ReadOnly = true;
            txt_soal.Size = new Size(544, 107);
            txt_soal.TabIndex = 2;
            txt_soal.Text = "";
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "QuizForm";
            Text = "QuizForm";
            Load += QuizForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label timer;
        private Label label1;
        private Label username;
        private Panel panel2;
        private RichTextBox txt_soal;
        private Button btn_next;
        private Button btn_prev;
    }
}