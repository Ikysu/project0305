namespace project0305
{
    partial class student
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
            this.label3 = new System.Windows.Forms.Label();
            this.passwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.authBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Группа";
            // 
            // passwd
            // 
            this.passwd.Location = new System.Drawing.Point(62, 38);
            this.passwd.MaxLength = 100;
            this.passwd.Name = "passwd";
            this.passwd.Size = new System.Drawing.Size(170, 20);
            this.passwd.TabIndex = 7;
            this.passwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwd_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "фио";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(47, 12);
            this.login.MaxLength = 100;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(185, 20);
            this.login.TabIndex = 5;
            this.login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_KeyPress);
            // 
            // authBtn
            // 
            this.authBtn.Enabled = false;
            this.authBtn.Location = new System.Drawing.Point(17, 64);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(215, 28);
            this.authBtn.TabIndex = 9;
            this.authBtn.Text = "Начать тест!";
            this.authBtn.UseVisualStyleBackColor = true;
            this.authBtn.Click += new System.EventHandler(this.authBtn_Click);
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 101);
            this.Controls.Add(this.authBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login);
            this.Name = "student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button authBtn;
    }
}