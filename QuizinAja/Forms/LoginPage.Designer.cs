namespace QuizinAja.Forms
{
    partial class LoginPage
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
            txtusername = new TextBox();
            txtpassword = new TextBox();
            label4 = new Label();
            box_showpw = new CheckBox();
            btn_login = new Button();
            label5 = new Label();
            link_create = new LinkLabel();
            label6 = new Label();
            link_quest = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 61);
            label1.Name = "label1";
            label1.Size = new Size(196, 54);
            label1.TabIndex = 0;
            label1.Text = "QuizinAja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(196, 128);
            label2.Name = "label2";
            label2.Size = new Size(275, 21);
            label2.TabIndex = 1;
            label2.Text = "Infinite Learning, Learn Without Limits";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(112, 212);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI", 13F);
            txtusername.Location = new Point(112, 256);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(445, 31);
            txtusername.TabIndex = 3;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 13F);
            txtpassword.Location = new Point(112, 340);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(445, 31);
            txtpassword.TabIndex = 5;
            txtpassword.UseSystemPasswordChar = true;
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(112, 309);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // box_showpw
            // 
            box_showpw.AutoSize = true;
            box_showpw.Font = new Font("Segoe UI", 12F);
            box_showpw.Location = new Point(419, 388);
            box_showpw.Name = "box_showpw";
            box_showpw.Size = new Size(138, 25);
            box_showpw.TabIndex = 6;
            box_showpw.Text = "Show Password";
            box_showpw.UseVisualStyleBackColor = true;
            box_showpw.CheckedChanged += box_showpw_CheckedChanged;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 13F);
            btn_login.Location = new Point(112, 450);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(445, 43);
            btn_login.TabIndex = 7;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(240, 511);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 8;
            label5.Text = "Don't have account?";
            // 
            // link_create
            // 
            link_create.AutoSize = true;
            link_create.Font = new Font("Segoe UI", 9F);
            link_create.Location = new Point(347, 511);
            link_create.Name = "link_create";
            link_create.Size = new Size(89, 15);
            link_create.TabIndex = 9;
            link_create.TabStop = true;
            link_create.Text = "Create Account";
            link_create.LinkClicked += link_create_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(326, 536);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 10;
            label6.Text = "or";
            // 
            // link_quest
            // 
            link_quest.AutoSize = true;
            link_quest.Font = new Font("Segoe UI", 9F);
            link_quest.Location = new Point(286, 561);
            link_quest.Name = "link_quest";
            link_quest.Size = new Size(99, 15);
            link_quest.TabIndex = 11;
            link_quest.TabStop = true;
            link_quest.Text = "Join quiz as guest";
            link_quest.LinkClicked += link_quest_LinkClicked;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 661);
            Controls.Add(link_quest);
            Controls.Add(label6);
            Controls.Add(link_create);
            Controls.Add(label5);
            Controls.Add(btn_login);
            Controls.Add(box_showpw);
            Controls.Add(txtpassword);
            Controls.Add(label4);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuizinAja - Online Quiz Platform";
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Label label4;
        private CheckBox box_showpw;
        private Button btn_login;
        private Label label5;
        private LinkLabel link_create;
        private Label label6;
        private LinkLabel link_quest;
    }
}