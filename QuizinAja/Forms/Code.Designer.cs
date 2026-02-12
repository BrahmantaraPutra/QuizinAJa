namespace QuizinAja.Forms
{
    partial class Code
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
            txt_code = new TextBox();
            label2 = new Label();
            txt_nickname = new TextBox();
            btn_join = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(131, 44);
            label1.Name = "label1";
            label1.Size = new Size(221, 37);
            label1.TabIndex = 0;
            label1.Text = "Enter Quiz Code";
            // 
            // txt_code
            // 
            txt_code.Font = new Font("Segoe UI", 13F);
            txt_code.Location = new Point(58, 95);
            txt_code.Name = "txt_code";
            txt_code.Size = new Size(369, 31);
            txt_code.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(159, 177);
            label2.Name = "label2";
            label2.Size = new Size(163, 28);
            label2.TabIndex = 2;
            label2.Text = "Enter Nickname";
            label2.Click += label2_Click;
            // 
            // txt_nickname
            // 
            txt_nickname.Font = new Font("Segoe UI", 13F);
            txt_nickname.Location = new Point(58, 215);
            txt_nickname.Name = "txt_nickname";
            txt_nickname.Size = new Size(369, 31);
            txt_nickname.TabIndex = 3;
            // 
            // btn_join
            // 
            btn_join.Font = new Font("Segoe UI", 13F);
            btn_join.Location = new Point(58, 288);
            btn_join.Name = "btn_join";
            btn_join.Size = new Size(369, 36);
            btn_join.TabIndex = 4;
            btn_join.Text = "Join";
            btn_join.UseVisualStyleBackColor = true;
            // 
            // Code
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(btn_join);
            Controls.Add(txt_nickname);
            Controls.Add(label2);
            Controls.Add(txt_code);
            Controls.Add(label1);
            Name = "Code";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuizinAja - Online Quiz Platform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_code;
        private Label label2;
        private TextBox txt_nickname;
        private Button btn_join;
    }
}