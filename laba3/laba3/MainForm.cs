using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;


namespace laba3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private RSA rsa;

        // Генерация ЭЦП
        private void Generate(object sender, EventArgs ea)
        {
            rsa = new RSA();

            textBoxP.Text = rsa.p.ToString();
            textBoxQ.Text = rsa.q.ToString();
            textBoxE.Text = rsa.e.ToString();
            textBoxD.Text = rsa.d.ToString();
            textBoxN.Text = rsa.n.ToString();

            var hash = Hash.GetHash(textBoxText.Text, rsa.n, 100);
            textBoxHash.Text = hash.ToString();

            var signature = RSA.FastExponentiation(hash, rsa.d, rsa.n);

            textBoxSignature.Text = signature.ToString();
        }

        // Проверка ЭЦП
        private void Check(object sender, EventArgs ea)
        {
            var hash = Hash.GetHash(textBoxText.Text, rsa.n, 100);

            BigInteger e = Convert.ToInt64(textBoxE.Text);
            BigInteger n = Convert.ToInt64(textBoxN.Text);
            BigInteger signature = Convert.ToInt64(textBoxSignature.Text);
            var resultHash = RSA.FastExponentiation(signature, e, n);

            if (hash == resultHash)
            {
                textBoxResult.Text = "Подпись подлинная";
            }
            else
            {
                textBoxResult.Text = $"Ошибка проверки подлинности." + 
                                     Environment.NewLine +
                                     $"Хэш сообщения: {hash}" +
                                     Environment.NewLine + 
                                     $"Хэш, полученный из подписи: {resultHash}";
            }
        }
    }
}
