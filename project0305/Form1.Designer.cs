namespace project0305
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dropMeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dropMeText
            // 
            this.dropMeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dropMeText.Location = new System.Drawing.Point(0, 0);
            this.dropMeText.Name = "dropMeText";
            this.dropMeText.Size = new System.Drawing.Size(249, 226);
            this.dropMeText.TabIndex = 6;
            this.dropMeText.Text = "Перетащите сюда файл с вопросами, для сдачи теста, или файл с ответами, для прове" +
    "рки";
            this.dropMeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 226);
            this.Controls.Add(this.dropMeText);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перетащите файл...";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label dropMeText;
    }
}

