namespace OnlineStore
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
            txtPassword = new TextBox();
            label1 = new Label();
            btnConnectMSSQL = new Button();
            btnConnectAccess = new Button();
            txtUsername = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(125, 41);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(102, 23);
            txtPassword.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Password";
            // 
            // btnConnectMSSQL
            // 
            btnConnectMSSQL.Location = new Point(125, 70);
            btnConnectMSSQL.Name = "btnConnectMSSQL";
            btnConnectMSSQL.Size = new Size(102, 23);
            btnConnectMSSQL.TabIndex = 2;
            btnConnectMSSQL.Text = "Connect MSSQL";
            btnConnectMSSQL.UseVisualStyleBackColor = true;
            btnConnectMSSQL.Click += btnConnectMSSQL_Click;
            // 
            // btnConnectAccess
            // 
            btnConnectAccess.Location = new Point(12, 70);
            btnConnectAccess.Name = "btnConnectAccess";
            btnConnectAccess.Size = new Size(107, 23);
            btnConnectAccess.TabIndex = 3;
            btnConnectAccess.Text = "Connect Access";
            btnConnectAccess.UseVisualStyleBackColor = true;
            btnConnectAccess.Click += btnConnectAccess_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(125, 8);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(102, 23);
            txtUsername.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 5;
            label2.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(244, 111);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(btnConnectAccess);
            Controls.Add(btnConnectMSSQL);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Connection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label label1;
        private Button btnConnectMSSQL;
        private Button btnConnectAccess;
        private TextBox txtUsername;
        private Label label2;
    }
}
