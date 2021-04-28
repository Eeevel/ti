
namespace laba3
{
    partial class MainForm
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
            this.rBtnAuto = new System.Windows.Forms.RadioButton();
            this.rBtnUser = new System.Windows.Forms.RadioButton();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rBtnAuto
            // 
            this.rBtnAuto.AutoSize = true;
            this.rBtnAuto.Checked = true;
            this.rBtnAuto.Location = new System.Drawing.Point(15, 41);
            this.rBtnAuto.Name = "rBtnAuto";
            this.rBtnAuto.Size = new System.Drawing.Size(199, 17);
            this.rBtnAuto.TabIndex = 7;
            this.rBtnAuto.TabStop = true;
            this.rBtnAuto.Text = "Автоматическая генерация ключа";
            this.rBtnAuto.UseVisualStyleBackColor = true;
            // 
            // rBtnUser
            // 
            this.rBtnUser.AutoSize = true;
            this.rBtnUser.Location = new System.Drawing.Point(15, 64);
            this.rBtnUser.Name = "rBtnUser";
            this.rBtnUser.Size = new System.Drawing.Size(183, 17);
            this.rBtnUser.TabIndex = 8;
            this.rBtnUser.Text = "Пользовательский ввод ключа";
            this.rBtnUser.UseVisualStyleBackColor = true;
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(77, 15);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(521, 20);
            this.textBoxText.TabIndex = 9;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(77, 140);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(521, 20);
            this.textBoxResult.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Текст";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Результат";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "p";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "q";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(235, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "e";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(235, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "d";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(435, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "n";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(31, 87);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(144, 20);
            this.textBoxP.TabIndex = 19;
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(31, 114);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(144, 20);
            this.textBoxQ.TabIndex = 20;
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(254, 87);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(144, 20);
            this.textBoxE.TabIndex = 21;
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(254, 114);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(144, 20);
            this.textBoxD.TabIndex = 22;
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(454, 87);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(144, 20);
            this.textBoxN.TabIndex = 23;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(15, 166);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(241, 23);
            this.btnEncrypt.TabIndex = 24;
            this.btnEncrypt.Text = "Зашифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(397, 166);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(201, 23);
            this.btnDecrypt.TabIndex = 25;
            this.btnDecrypt.Text = "Расшифровать";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(12, 192);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 26;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 214);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.rBtnUser);
            this.Controls.Add(this.rBtnAuto);
            this.Name = "MainForm";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rBtnAuto;
        private System.Windows.Forms.RadioButton rBtnUser;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lbError;
    }

}

