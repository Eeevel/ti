using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Обработчик нажатия на кнопку "Зашифровать"
        // Значения p, q и e берутся из соответствующих полей
        private void btnEncrypt_Click(object sender, EventArgs ea)
        {
            lbError.Text = "";

            long p, q, e, n;

            if (rBtnAuto.Checked)
            {
                RSA rsa = new RSA();

                textBoxP.Text = rsa.p.ToString();
                textBoxQ.Text = rsa.q.ToString();
                textBoxE.Text = rsa.e.ToString();
                textBoxD.Text = rsa.d.ToString();
                textBoxN.Text = rsa.n.ToString();
            }
            else
            {
                p = Convert.ToInt64(textBoxP.Text);
                q = Convert.ToInt64(textBoxQ.Text);
                e = Convert.ToInt64(textBoxE.Text);

                try
                {
                    RSA rsa = new RSA(p, q, e);
                    textBoxD.Text = rsa.d.ToString();
                    textBoxN.Text = rsa.n.ToString();
                }
                catch(ArgumentException ex)
                {
                    lbError.Text = ex.Message;
                    return;
                }
            }

            e = Convert.ToInt64(textBoxE.Text);
            n = Convert.ToInt64(textBoxN.Text);

            string chiperText = RSA.Encrypt(textBoxText.Text, e, n);
            textBoxResult.Text = chiperText;
        }

        // Обработчик нажатия на кнопку "Расшифровать"
        // Значения d и n берутся из соответствующих полей
        private void btnDecrypt_Click(object sender, EventArgs ea)
        {
            long d = Convert.ToInt64(textBoxD.Text);
            long n = Convert.ToInt64(textBoxN.Text);

            string plainText = RSA.Decrypt(textBoxText.Text, d, n);
            textBoxResult.Text = plainText;
        }
    }
}
