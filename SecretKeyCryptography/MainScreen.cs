using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace SecretKeyCryptography
{
    public partial class MainScreen : MetroForm
    {
        public MainScreen()
        {

            InitializeComponent();
            this.StyleManager = msMgr;

        }

        private enum Yontemler
        {
            DES,
            TripleDES,
            AES,
            RC2
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_Algorithms.DataSource = Enum.GetNames(typeof(Yontemler));
            cmb_Algorithms.SelectedIndex = 0;
            metroTextBox2.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        }

        private SymmetricAlgorithm SecilenAlgoritma()
        {
            SymmetricAlgorithm Alg = null;
            if (cmb_Algorithms.SelectedIndex == 0)
                Alg = new DESCryptoServiceProvider();
            else if (cmb_Algorithms.SelectedIndex == 1)
                Alg = new TripleDESCryptoServiceProvider();
            else if (cmb_Algorithms.SelectedIndex == 2)
                Alg = new RijndaelManaged(); //RijndaelManaged: AES Algorithm name in .NET
            else
                Alg = new RC2CryptoServiceProvider();
            return Alg;
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            if (txt_salt.Text.Length < 8)
            {
                MetroMessageBox.Show(this, "Salt must be at least 8 characters", "Salt Key Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txt_salt.Focus();
                return;
            }
            try
            {
                string password = txt_key.Text;
                string salt = txt_salt.Text;
                string plainText = txt_InputText.Text;
                byte[] plainBytes = Encoding.UTF8.GetBytes(plainText); // Byte dizisine kodla

                //Rfc2898DeriveBytes: Used to Generate Strong Keys
                Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(password,
                    Encoding.ASCII.GetBytes(salt)); //Non-English Alfhabets Will not Work on ASCII Encoding

                SymmetricAlgorithm Alg = SecilenAlgoritma();

                Alg.Key = rfc.GetBytes(Alg.KeySize / 8); // 8 bits per byte
                Alg.IV = rfc.GetBytes(Alg.BlockSize / 8);


                MemoryStream strCiphered = new MemoryStream(); //To Store Encrypted Data

                CryptoStream strCrypto = new CryptoStream(strCiphered,
                    Alg.CreateEncryptor(), CryptoStreamMode.Write);

                strCrypto.Write(plainBytes, 0, plainBytes.Length);
                strCrypto.Close();
                txt_Result.Text = Convert.ToBase64String(strCiphered.ToArray());

                strCiphered.Close();
                txt_Result.Focus();
            }
            catch (CryptographicException ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_salt.Text.Length < 8)
                {
                    MetroMessageBox.Show(this, "Salt must be at least 8 characters", "Salt Key Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_salt.Focus();
                    return;
                }
                string password = txt_key.Text;
                string salt = txt_salt.Text;
                string cipheredText = txt_InputText.Text;
                byte[] cipheredBytes = Convert.FromBase64String(cipheredText);

                //Rfc2898DeriveBytes: Used to Generate Strong Keys
                Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(password,
                    Encoding.ASCII.GetBytes(salt)); //Non-English Alfhabets Will not Work on ASCII Encoding

                SymmetricAlgorithm Alg = SecilenAlgoritma();

                Alg.Key = rfc.GetBytes(Alg.KeySize / 8); // 8 bits per byte
                Alg.IV = rfc.GetBytes(Alg.BlockSize / 8); // 8 bits per byte

                MemoryStream strDeciphered = new MemoryStream(); //To Store Decrypted Data

                CryptoStream strCrypto = new CryptoStream(strDeciphered,
                    Alg.CreateDecryptor(), CryptoStreamMode.Write);

                strCrypto.Write(cipheredBytes, 0, cipheredBytes.Length);
                strCrypto.Close();
                txt_Result.Text = Encoding.UTF8.GetString(strDeciphered.ToArray());

                strDeciphered.Close();

                txt_Result.Focus();
            }
            catch (CryptographicException ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool EncryptFile(string inputFile, string outputFile)
        {

            if (txt_salt.Text.Length < 8)
            {
                MetroMessageBox.Show(this, "Salt must be at least 8 characters", "Salt Key Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_salt.Focus();
                return false;
            }
            try
            {
                string password = txt_key.Text;
                string salt = txt_salt.Text;
                //Rfc2898DeriveBytes: Used to Generate Strong Keys
                Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(password, Encoding.ASCII.GetBytes(salt));//Non-English Alfhabets Will not Work on ASCII Encoding
                SymmetricAlgorithm Alg = SecilenAlgoritma();
                Alg.Key = rfc.GetBytes(Alg.KeySize / 8);
                Alg.IV = rfc.GetBytes(Alg.BlockSize / 8);
                string cryptFile = outputFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                CryptoStream strCrypto = new CryptoStream(fsCrypt, Alg.CreateEncryptor(), CryptoStreamMode.Write);
                FileStream fsIn = new FileStream(inputFile, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    strCrypto.WriteByte((byte)data);
                fsIn.Close();
                strCrypto.Close();
                fsCrypt.Close();

                strCrypto.Close();

                txt_Result.Focus();
                return true;
            }
            catch (CryptographicException ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private bool DecryptFile(string inputFile, string outputFile)
        {
            if (txt_salt.Text.Length < 8)
            {
                MetroMessageBox.Show(this, "Salt must be at least 8 characters", "Salt Key Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_salt.Focus();
                return false;
            }
            try
            {
                string password = txt_key.Text;
                string salt = txt_salt.Text;
                //Rfc2898DeriveBytes: Used to Generate Strong Keys
                Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(password, Encoding.ASCII.GetBytes(salt));//Non-English Alfhabets Will not Work on ASCII Encoding
                SymmetricAlgorithm Alg = SecilenAlgoritma();
                Alg.Key = rfc.GetBytes(Alg.KeySize / 8);
                Alg.IV = rfc.GetBytes(Alg.BlockSize / 8);


                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                CryptoStream strCrypto = new CryptoStream(fsCrypt, Alg.CreateDecryptor(), CryptoStreamMode.Read);
                // strCrypto.Write(cipheredBytes, 0, cipheredBytes.Length);
                FileStream fsOut = new FileStream(outputFile, FileMode.Create);
                int data;
                while ((data = strCrypto.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);
                fsOut.Close();
                strCrypto.Close();
                return true;
            }
            catch (CryptographicException ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void ofd_1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                metroTextBox1.Text = file.FileName;
            }
        }

        private void ofd_2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog file = new FolderBrowserDialog();


            if (file.ShowDialog() == DialogResult.OK)
            {
                metroTextBox2.Text = file.SelectedPath;
            }


        }

        private void btn_EncryptFile_Click(object sender, EventArgs e)
        {
            bool status = EncryptFile(metroTextBox1.Text,
                metroTextBox2.Text + "\\" + Path.GetFileName(metroTextBox1.Text) + "." + cmb_Algorithms.Text.ToLower());
            if (status)
            {
                MetroMessageBox.Show(this, "Encryption completed successfully!", "Success", MessageBoxButtons.OK,
           MessageBoxIcon.Asterisk);
            }
        }

        private void btn_DecryptFile_Click(object sender, EventArgs e)
        {
            string destination = Path.ChangeExtension(Path.GetFileName(metroTextBox1.Text), "").TrimEnd(new char[] { '.' });
            bool status = DecryptFile(metroTextBox1.Text, metroTextBox2.Text + "\\" + destination);

            if (status)
            {
                MetroMessageBox.Show(this, "Decryption completed successfully!", "Success", MessageBoxButtons.OK,
           MessageBoxIcon.Asterisk);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                msMgr.Theme = msMgr.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                this.Theme = msMgr.Theme;
                this.Refresh();
            }
            e.Handled = false;
        }

  
    }
}
