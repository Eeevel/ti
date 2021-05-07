using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba4
{
    public partial class Form1 : Form
    {
        private Lfsr lfsr;

        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик нажатия на кнопку "Зашифровать"
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                lfsr = new Lfsr(ulong.Parse(textBoxKey.Text));
            }
            catch
            {
                lbResult.Text = "Ошибка создания ключа";
                return;
            }

            try
            {
                lfsr.Treatment("./input.txt", "./output.txt");
            }
            catch
            {
                lbResult.Text = "Ошибка шифрования";
                return;
            }

            lbResult.Text = "Шифрование прошло успешно";
        }

        // Обработчик нажатия на кнопку "Расшифровать"
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                lfsr = new Lfsr(ulong.Parse(textBoxKey.Text));
            }
            catch
            {
                lbResult.Text = "Ошибка создания ключа";
                return;
            }

            try
            {
                lfsr.Treatment("./output.txt", "./input.txt");
            }
            catch
            {
                lbResult.Text = "Ошибка расшифровки";
                return;
            }

            lbResult.Text = "Расшифровка прошла успешно";
        }
    }
}
