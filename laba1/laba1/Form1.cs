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

        private void BtnRailFenceEncrypt_Click(object sender, EventArgs e)
        {
            LbRailFenceEncrypt.Text = RailFence.Encrypt("cryptography", 3);
        }

        private void BtnRailFenceDecrypt_Click(object sender, EventArgs e)
        {
            LbRailFenceEncrypt.Text = RailFence.Decrypt(LbRailFenceEncrypt.Text, 3);
        }

        private void BtnColumnEncrypt_Click(object sender, EventArgs e)
        {
            LbRailFenceEncrypt.Text = Column.Encrypt("cryptographyr", "3-1-4-2");
        }

        private void BtnColumnDecrypt_Click(object sender, EventArgs e)
        {
            LbRailFenceEncrypt.Text = Column.Decrypt(LbRailFenceEncrypt.Text, "3-1-4-2");
        }

        private void BtnGrilleEncrypt_Click(object sender, EventArgs e)
        {
            LbRailFenceEncrypt.Text = PivotingGrille.Encrypt("Here Is A Secret Message Write", "0204145650360032065410321");
        }

        private void BtnGrilleDecrypt_Click(object sender, EventArgs e)
        {
            LbRailFenceEncrypt.Text = PivotingGrille.Decrypt(LbRailFenceEncrypt.Text, "0204145650360032065410321");
        }

        private void BtnCaesarEncryp_Click(object sender, EventArgs e)
        {
            LbRailFenceEncrypt.Text = CaesarCipher.Encrypt("HERE IS A SECRET MESSAGE WRITE", 3);
        }

        private void BtnCaesarDecrypt_Click(object sender, EventArgs e)
        {
            LbRailFenceEncrypt.Text = CaesarCipher.Decrypt(LbRailFenceEncrypt.Text, 3);
        }
    }
}
