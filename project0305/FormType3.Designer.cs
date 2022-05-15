namespace project0305
{
    partial class FormType3
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
            this.desc = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(12, 9);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(760, 100);
            this.desc.TabIndex = 0;
            this.desc.Text = "Текст вопроса";
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(651, 138);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(121, 29);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "Далее";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(760, 20);
            this.textBox1.TabIndex = 5;
            // 
            // FormType3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 181);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.desc);
            this.Name = "FormType3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormType1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}