using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RSAEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }

        }

        static public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }

        }

        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        byte[] plaintext;
        byte[] encryptedtext;

        private void button1_Click(object sender, EventArgs e)
        {
            plaintext = ByteConverter.GetBytes(txtplain.Text);
            encryptedtext = Encryption(plaintext, RSA.ExportParameters(false), false);
            txtencrypt.Text = ByteConverter.GetString(encryptedtext);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            byte[] decryptedtex = Decryption(encryptedtext, RSA.ExportParameters(true), false);
            txtdecrypt.Text = ByteConverter.GetString(decryptedtex);
        }
        public byte[] Base64Decoding(String input)
        {
            return Convert.FromBase64String(input);
        }
        public string Base64Encoding(byte[] input)
        {
            return Convert.ToBase64String(input);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var encoding = Base64Encoding(ByteConverter.GetBytes(txtplain.Text));
            txtencodingto64.Text = encoding;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var decodingto64 = Base64Decoding(txtencodingto64.Text);
            txtdecodingfrombase64.Text = ByteConverter.GetString(decodingto64); ;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}