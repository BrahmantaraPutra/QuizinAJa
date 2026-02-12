namespace QuizinAja.Forms
{
    partial class MainForm
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
            txtusername = new Label();
            btn_add = new Button();
            btn_view = new Button();
            btn_logout = new Button();
            dg_yourquiz = new DataGridView();
            quiz_name = new DataGridViewTextBoxColumn();
            code = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            number_quest = new DataGridViewTextBoxColumn();
            action = new DataGridViewTextBoxColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg_yourquiz).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // txtusername
            // 
            txtusername.AutoSize = true;
            txtusername.Font = new Font("Segoe UI Semibold", 13.75F, FontStyle.Bold);
            txtusername.Location = new Point(12, 31);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(98, 25);
            txtusername.TabIndex = 1;
            txtusername.Text = "Username";
            txtusername.Click += txtusername_Click;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 12F);
            btn_add.Location = new Point(12, 157);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(208, 36);
            btn_add.TabIndex = 2;
            btn_add.Text = "Add Quiz";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_view
            // 
            btn_view.Font = new Font("Segoe UI", 12F);
            btn_view.Location = new Point(13, 199);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(208, 36);
            btn_view.TabIndex = 3;
            btn_view.Text = "View Quiz Report";
            btn_view.UseVisualStyleBackColor = true;
            btn_view.Click += btn_view_Click;
            // 
            // btn_logout
            // 
            btn_logout.Font = new Font("Segoe UI", 12F);
            btn_logout.Location = new Point(13, 513);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(208, 36);
            btn_logout.TabIndex = 4;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // dg_yourquiz
            // 
            dg_yourquiz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_yourquiz.Columns.AddRange(new DataGridViewColumn[] { quiz_name, code, description, number_quest, action });
            dg_yourquiz.Location = new Point(239, 36);
            dg_yourquiz.Name = "dg_yourquiz";
            dg_yourquiz.RowHeadersVisible = false;
            dg_yourquiz.Size = new Size(633, 513);
            dg_yourquiz.TabIndex = 5;
            // 
            // quiz_name
            // 
            quiz_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quiz_name.DataPropertyName = "QuizName";
            quiz_name.HeaderText = "Quiz Name";
            quiz_name.Name = "quiz_name";
            // 
            // code
            // 
            code.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            code.DataPropertyName = "Code";
            code.HeaderText = "Code";
            code.Name = "code";
            // 
            // description
            // 
            description.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            description.DataPropertyName = "Description";
            description.HeaderText = "Description";
            description.Name = "description";
            description.Width = 92;
            // 
            // number_quest
            // 
            number_quest.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            number_quest.DataPropertyName = "Number";
            number_quest.HeaderText = "NumberOfQuestion";
            number_quest.Name = "number_quest";
            // 
            // action
            // 
            action.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            action.DataPropertyName = "Action";
            action.HeaderText = "";
            action.Name = "action";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(239, 12);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 6;
            label2.Text = "Your quiz";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(label2);
            Controls.Add(dg_yourquiz);
            Controls.Add(btn_logout);
            Controls.Add(btn_view);
            Controls.Add(btn_add);
            Controls.Add(txtusername);
            Controls.Add(label1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuizinAja - Online Quiz Platform";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dg_yourquiz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txtusername;
        private Button btn_add;
        private Button btn_view;
        private Button btn_logout;
        private DataGridView dg_yourquiz;
        private Label label2;
        private DataGridViewTextBoxColumn quiz_name;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn number_quest;
        private DataGridViewTextBoxColumn action;
    }
}