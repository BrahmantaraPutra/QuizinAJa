namespace QuizinAja.Forms
{
    partial class CreateAccount
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
            txtfullname = new TextBox();
            label5 = new Label();
            txtretypepassword = new TextBox();
            label6 = new Label();
            label7 = new Label();
            birth = new DateTimePicker();
            btn_create = new Button();
            label8 = new Label();
            link_login = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 30.75F, FontStyle.Bold);
            label1.Location = new Point(31, 35);
            label1.Name = "label1";
            label1.Size = new Size(308, 55);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(42, 90);
            label2.Name = "label2";
            label2.Size = new Size(389, 21);
            label2.TabIndex = 1;
            label2.Text = "Fill in bellow information to complete your registration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(42, 161);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI", 13F);
            txtusername.Location = new Point(42, 186);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(375, 31);
            txtusername.TabIndex = 3;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 13F);
            txtpassword.Location = new Point(450, 186);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(375, 31);
            txtpassword.TabIndex = 5;
            txtpassword.UseSystemPasswordChar = true;
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(450, 161);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // txtfullname
            // 
            txtfullname.Font = new Font("Segoe UI", 13F);
            txtfullname.Location = new Point(42, 262);
            txtfullname.Name = "txtfullname";
            txtfullname.Size = new Size(375, 31);
            txtfullname.TabIndex = 7;
            txtfullname.TextChanged += txtfullname_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(42, 237);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 6;
            label5.Text = "Full Name";
            // 
            // txtretypepassword
            // 
            txtretypepassword.Font = new Font("Segoe UI", 13F);
            txtretypepassword.Location = new Point(450, 262);
            txtretypepassword.Name = "txtretypepassword";
            txtretypepassword.Size = new Size(375, 31);
            txtretypepassword.TabIndex = 9;
            txtretypepassword.UseSystemPasswordChar = true;
            txtretypepassword.TextChanged += txtretypepassword_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(450, 237);
            label6.Name = "label6";
            label6.Size = new Size(128, 21);
            label6.TabIndex = 8;
            label6.Text = "Retype Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(42, 314);
            label7.Name = "label7";
            label7.Size = new Size(97, 21);
            label7.TabIndex = 10;
            label7.Text = "Date of Birth";
            // 
            // birth
            // 
            birth.CalendarFont = new Font("Segoe UI", 13F);
            birth.Font = new Font("Segoe UI", 13F);
            birth.Location = new Point(42, 338);
            birth.Name = "birth";
            birth.Size = new Size(375, 31);
            birth.TabIndex = 11;
            birth.ValueChanged += birth_ValueChanged;
            // 
            // btn_create
            // 
            btn_create.Font = new Font("Segoe UI", 13F);
            btn_create.Location = new Point(256, 436);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(359, 42);
            btn_create.TabIndex = 12;
            btn_create.Text = "Create Account";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(336, 492);
            label8.Name = "label8";
            label8.Size = new Size(145, 15);
            label8.TabIndex = 13;
            label8.Text = "Already have an account? ";
            // 
            // link_login
            // 
            link_login.AutoSize = true;
            link_login.Location = new Point(477, 492);
            link_login.Name = "link_login";
            link_login.Size = new Size(37, 15);
            link_login.TabIndex = 14;
            link_login.TabStop = true;
            link_login.Text = "Login";
            link_login.LinkClicked += link_login_LinkClicked;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(link_login);
            Controls.Add(label8);
            Controls.Add(btn_create);
            Controls.Add(birth);
            Controls.Add(label7);
            Controls.Add(txtretypepassword);
            Controls.Add(label6);
            Controls.Add(txtfullname);
            Controls.Add(label5);
            Controls.Add(txtpassword);
            Controls.Add(label4);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuizinAja - Online Quiz Platform";
            Load += CreateAccount_Load;
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
        private TextBox txtfullname;
        private Label label5;
        private TextBox txtretypepassword;
        private Label label6;
        private Label label7;
        private DateTimePicker birth;
        private Button btn_create;
        private Label label8;
        private LinkLabel link_login;
    }
}