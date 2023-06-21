using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caeser_Ciphere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Encrypt(string text, int shift)
        {
            string EncryptText = "";

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char shiftChar = (char)(((int)char.ToUpper(c) + shift - 65) % 26 + 65);
                    EncryptText += char.IsLower(c) ? char.ToLower(shiftChar) : shiftChar;
                }
                else
                {
                    EncryptText += c;
                }
            }
            return EncryptText;
        }
        private string Decrypt(string text, int shift)
        {
            return Encrypt(text, 26 - shift);
        }
        private void b_del_Click(object sender, EventArgs e)
        {
            t_cipher.Text = "";
            t_key.Text = "";
            t_plain.Text = "";
        }
        private void b_Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                int shift = Convert.ToInt32(t_key.Text);
                string plainText = t_plain.Text;
                string encryptText = Encrypt(plainText, shift);
                t_cipher.Text = encryptText;
            }
            catch { }
        }
        private void b_Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                int shift = Convert.ToInt32(t_key.Text);
                string cipherText = t_plain.Text;
                string decryptText = Decrypt(cipherText, shift);
                t_cipher.Text = decryptText;
            }
            catch { }
        }
    }
}
