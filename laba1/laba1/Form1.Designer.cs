
namespace laba1
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
            this.LbRailFenceEncrypt = new System.Windows.Forms.Label();
            this.BtnRailFenceEncrypt = new System.Windows.Forms.Button();
            this.BtnRailFenceDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbRailFenceEncrypt
            // 
            this.LbRailFenceEncrypt.AutoSize = true;
            this.LbRailFenceEncrypt.Location = new System.Drawing.Point(23, 13);
            this.LbRailFenceEncrypt.Name = "LbRailFenceEncrypt";
            this.LbRailFenceEncrypt.Size = new System.Drawing.Size(35, 13);
            this.LbRailFenceEncrypt.TabIndex = 0;
            this.LbRailFenceEncrypt.Text = "label1";
            // 
            // BtnRailFenceEncrypt
            // 
            this.BtnRailFenceEncrypt.Location = new System.Drawing.Point(26, 49);
            this.BtnRailFenceEncrypt.Name = "BtnRailFenceEncrypt";
            this.BtnRailFenceEncrypt.Size = new System.Drawing.Size(75, 23);
            this.BtnRailFenceEncrypt.TabIndex = 1;
            this.BtnRailFenceEncrypt.Text = "button1";
            this.BtnRailFenceEncrypt.UseVisualStyleBackColor = true;
            this.BtnRailFenceEncrypt.Click += new System.EventHandler(this.BtnRailFenceEncrypt_Click);
            // 
            // BtnRailFenceDecrypt
            // 
            this.BtnRailFenceDecrypt.Location = new System.Drawing.Point(26, 79);
            this.BtnRailFenceDecrypt.Name = "BtnRailFenceDecrypt";
            this.BtnRailFenceDecrypt.Size = new System.Drawing.Size(75, 23);
            this.BtnRailFenceDecrypt.TabIndex = 2;
            this.BtnRailFenceDecrypt.Text = "button1";
            this.BtnRailFenceDecrypt.UseVisualStyleBackColor = true;
            this.BtnRailFenceDecrypt.Click += new System.EventHandler(this.BtnRailFenceDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRailFenceDecrypt);
            this.Controls.Add(this.BtnRailFenceEncrypt);
            this.Controls.Add(this.LbRailFenceEncrypt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbRailFenceEncrypt;
        private System.Windows.Forms.Button BtnRailFenceEncrypt;
        private System.Windows.Forms.Button BtnRailFenceDecrypt;
    }
}

