using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            string text = TbText.Text;
            string key = TbKey.Text;

            if (RbRailFence.Checked)
                TbResult.Text = RailFence.Encrypt(text, int.Parse(key));
            if (RbGrille.Checked)
                TbResult.Text = PivotingGrille.Encrypt(text, key);
            if (RbColumn.Checked)
                TbResult.Text = Column.Encrypt(text, key);
            if (RbCaesar.Checked)
                TbResult.Text = CaesarCipher.Encrypt(text, int.Parse(key));
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            string text = TbText.Text;
            string key = TbKey.Text;

            if (RbRailFence.Checked)
                TbResult.Text = RailFence.Decrypt(text, int.Parse(key));
            if (RbGrille.Checked)
                TbResult.Text = PivotingGrille.Decrypt(text, key);
            if (RbColumn.Checked)
                TbResult.Text = Column.Decrypt(text, key);
            if (RbCaesar.Checked)
                TbResult.Text = CaesarCipher.Decrypt(text, int.Parse(key));
        }
    }
}
