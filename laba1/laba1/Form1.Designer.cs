
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbText = new System.Windows.Forms.TextBox();
            this.TbKey = new System.Windows.Forms.TextBox();
            this.RbRailFence = new System.Windows.Forms.RadioButton();
            this.RbColumn = new System.Windows.Forms.RadioButton();
            this.RbGrille = new System.Windows.Forms.RadioButton();
            this.RbCaesar = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TbResult = new System.Windows.Forms.TextBox();
            this.BtnEncrypt = new System.Windows.Forms.Button();
            this.BtnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ключ";
            // 
            // TbText
            // 
            this.TbText.Location = new System.Drawing.Point(79, 6);
            this.TbText.Name = "TbText";
            this.TbText.Size = new System.Drawing.Size(271, 20);
            this.TbText.TabIndex = 11;
            // 
            // TbKey
            // 
            this.TbKey.Location = new System.Drawing.Point(79, 34);
            this.TbKey.Name = "TbKey";
            this.TbKey.Size = new System.Drawing.Size(271, 20);
            this.TbKey.TabIndex = 12;
            // 
            // RbRailFence
            // 
            this.RbRailFence.AutoSize = true;
            this.RbRailFence.Checked = true;
            this.RbRailFence.Location = new System.Drawing.Point(15, 100);
            this.RbRailFence.Name = "RbRailFence";
            this.RbRailFence.Size = new System.Drawing.Size(172, 17);
            this.RbRailFence.TabIndex = 13;
            this.RbRailFence.TabStop = true;
            this.RbRailFence.Text = "Железнодорожная изгородь";
            this.RbRailFence.UseVisualStyleBackColor = true;
            // 
            // RbColumn
            // 
            this.RbColumn.AutoSize = true;
            this.RbColumn.Location = new System.Drawing.Point(15, 123);
            this.RbColumn.Name = "RbColumn";
            this.RbColumn.Size = new System.Drawing.Size(121, 17);
            this.RbColumn.TabIndex = 14;
            this.RbColumn.Text = "Столбцовый метод";
            this.RbColumn.UseVisualStyleBackColor = true;
            // 
            // RbGrille
            // 
            this.RbGrille.AutoSize = true;
            this.RbGrille.Location = new System.Drawing.Point(15, 146);
            this.RbGrille.Name = "RbGrille";
            this.RbGrille.Size = new System.Drawing.Size(206, 17);
            this.RbGrille.TabIndex = 15;
            this.RbGrille.Text = "Метод поворачивающейся решетки";
            this.RbGrille.UseVisualStyleBackColor = true;
            // 
            // RbCaesar
            // 
            this.RbCaesar.AutoSize = true;
            this.RbCaesar.Location = new System.Drawing.Point(15, 169);
            this.RbCaesar.Name = "RbCaesar";
            this.RbCaesar.Size = new System.Drawing.Size(95, 17);
            this.RbCaesar.TabIndex = 16;
            this.RbCaesar.Text = "Шифр Цезаря";
            this.RbCaesar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Результат";
            // 
            // TbResult
            // 
            this.TbResult.Location = new System.Drawing.Point(79, 64);
            this.TbResult.Name = "TbResult";
            this.TbResult.Size = new System.Drawing.Size(271, 20);
            this.TbResult.TabIndex = 18;
            // 
            // BtnEncrypt
            // 
            this.BtnEncrypt.Location = new System.Drawing.Point(15, 192);
            this.BtnEncrypt.Name = "BtnEncrypt";
            this.BtnEncrypt.Size = new System.Drawing.Size(154, 23);
            this.BtnEncrypt.TabIndex = 19;
            this.BtnEncrypt.Text = "Зашифровать";
            this.BtnEncrypt.UseVisualStyleBackColor = true;
            this.BtnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // BtnDecrypt
            // 
            this.BtnDecrypt.Location = new System.Drawing.Point(196, 192);
            this.BtnDecrypt.Name = "BtnDecrypt";
            this.BtnDecrypt.Size = new System.Drawing.Size(154, 23);
            this.BtnDecrypt.TabIndex = 20;
            this.BtnDecrypt.Text = "Расшифровать";
            this.BtnDecrypt.UseVisualStyleBackColor = true;
            this.BtnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 227);
            this.Controls.Add(this.BtnDecrypt);
            this.Controls.Add(this.BtnEncrypt);
            this.Controls.Add(this.TbResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RbCaesar);
            this.Controls.Add(this.RbGrille);
            this.Controls.Add(this.RbColumn);
            this.Controls.Add(this.RbRailFence);
            this.Controls.Add(this.TbKey);
            this.Controls.Add(this.TbText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Шифрование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbText;
        private System.Windows.Forms.TextBox TbKey;
        private System.Windows.Forms.RadioButton RbRailFence;
        private System.Windows.Forms.RadioButton RbColumn;
        private System.Windows.Forms.RadioButton RbGrille;
        private System.Windows.Forms.RadioButton RbCaesar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbResult;
        private System.Windows.Forms.Button BtnEncrypt;
        private System.Windows.Forms.Button BtnDecrypt;
    }
}

