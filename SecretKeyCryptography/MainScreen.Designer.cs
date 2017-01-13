namespace SecretKeyCryptography
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.txt_InputText = new MetroFramework.Controls.MetroTextBox();
            this.txt_Result = new MetroFramework.Controls.MetroTextBox();
            this.btn_Encrypt = new MetroFramework.Controls.MetroButton();
            this.btn_Decrypt = new MetroFramework.Controls.MetroButton();
            this.txt_key = new MetroFramework.Controls.MetroTextBox();
            this.txt_salt = new MetroFramework.Controls.MetroTextBox();
            this.cmb_Algorithms = new MetroFramework.Controls.MetroComboBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btn_DecryptFile = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btn_EncryptFile = new MetroFramework.Controls.MetroButton();
            this.ofd_2 = new MetroFramework.Controls.MetroButton();
            this.ofd_1 = new MetroFramework.Controls.MetroButton();
            this.txtDestinationFile = new MetroFramework.Controls.MetroTextBox();
            this.txtSourceFile = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.msMgr = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msMgr)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_InputText
            // 
            // 
            // 
            // 
            this.txt_InputText.CustomButton.Image = null;
            this.txt_InputText.CustomButton.Location = new System.Drawing.Point(418, 2);
            this.txt_InputText.CustomButton.Name = "";
            this.txt_InputText.CustomButton.Size = new System.Drawing.Size(89, 89);
            this.txt_InputText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_InputText.CustomButton.TabIndex = 1;
            this.txt_InputText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_InputText.CustomButton.UseSelectable = true;
            this.txt_InputText.CustomButton.Visible = false;
            this.txt_InputText.Lines = new string[0];
            this.txt_InputText.Location = new System.Drawing.Point(3, 14);
            this.txt_InputText.MaxLength = 32767;
            this.txt_InputText.Multiline = true;
            this.txt_InputText.Name = "txt_InputText";
            this.txt_InputText.PasswordChar = '\0';
            this.txt_InputText.PromptText = "Input Text";
            this.txt_InputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_InputText.SelectedText = "";
            this.txt_InputText.SelectionLength = 0;
            this.txt_InputText.SelectionStart = 0;
            this.txt_InputText.ShortcutsEnabled = true;
            this.txt_InputText.Size = new System.Drawing.Size(510, 94);
            this.txt_InputText.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_InputText.TabIndex = 0;
            this.txt_InputText.UseSelectable = true;
            this.txt_InputText.WaterMark = "Input Text";
            this.txt_InputText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_InputText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_Result
            // 
            // 
            // 
            // 
            this.txt_Result.CustomButton.Image = null;
            this.txt_Result.CustomButton.Location = new System.Drawing.Point(522, 2);
            this.txt_Result.CustomButton.Name = "";
            this.txt_Result.CustomButton.Size = new System.Drawing.Size(89, 89);
            this.txt_Result.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Result.CustomButton.TabIndex = 1;
            this.txt_Result.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Result.CustomButton.UseSelectable = true;
            this.txt_Result.CustomButton.Visible = false;
            this.txt_Result.Lines = new string[0];
            this.txt_Result.Location = new System.Drawing.Point(4, 114);
            this.txt_Result.MaxLength = 32767;
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.PasswordChar = '\0';
            this.txt_Result.PromptText = "Result";
            this.txt_Result.ReadOnly = true;
            this.txt_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Result.SelectedText = "";
            this.txt_Result.SelectionLength = 0;
            this.txt_Result.SelectionStart = 0;
            this.txt_Result.ShortcutsEnabled = true;
            this.txt_Result.Size = new System.Drawing.Size(614, 94);
            this.txt_Result.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Result.TabIndex = 1;
            this.txt_Result.UseSelectable = true;
            this.txt_Result.WaterMark = "Result";
            this.txt_Result.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Result.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Encrypt.Location = new System.Drawing.Point(519, 14);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(100, 43);
            this.btn_Encrypt.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_Encrypt.TabIndex = 3;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseSelectable = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Decrypt.Location = new System.Drawing.Point(518, 65);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(100, 43);
            this.btn_Decrypt.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_Decrypt.TabIndex = 4;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseSelectable = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // txt_key
            // 
            // 
            // 
            // 
            this.txt_key.CustomButton.Image = null;
            this.txt_key.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txt_key.CustomButton.Name = "";
            this.txt_key.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_key.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_key.CustomButton.TabIndex = 1;
            this.txt_key.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_key.CustomButton.UseSelectable = true;
            this.txt_key.CustomButton.Visible = false;
            this.txt_key.Lines = new string[0];
            this.txt_key.Location = new System.Drawing.Point(200, 72);
            this.txt_key.MaxLength = 32767;
            this.txt_key.Name = "txt_key";
            this.txt_key.PasswordChar = '●';
            this.txt_key.PromptText = "Your Secret Key";
            this.txt_key.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_key.SelectedText = "";
            this.txt_key.SelectionLength = 0;
            this.txt_key.SelectionStart = 0;
            this.txt_key.ShortcutsEnabled = true;
            this.txt_key.Size = new System.Drawing.Size(196, 23);
            this.txt_key.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_key.TabIndex = 5;
            this.txt_key.UseSelectable = true;
            this.txt_key.WaterMark = "Your Secret Key";
            this.txt_key.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_key.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_salt
            // 
            // 
            // 
            // 
            this.txt_salt.CustomButton.Image = null;
            this.txt_salt.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txt_salt.CustomButton.Name = "";
            this.txt_salt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_salt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_salt.CustomButton.TabIndex = 1;
            this.txt_salt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_salt.CustomButton.UseSelectable = true;
            this.txt_salt.CustomButton.Visible = false;
            this.txt_salt.Lines = new string[0];
            this.txt_salt.Location = new System.Drawing.Point(449, 72);
            this.txt_salt.MaxLength = 32767;
            this.txt_salt.Name = "txt_salt";
            this.txt_salt.PasswordChar = '●';
            this.txt_salt.PromptText = "Salt";
            this.txt_salt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_salt.SelectedText = "";
            this.txt_salt.SelectionLength = 0;
            this.txt_salt.SelectionStart = 0;
            this.txt_salt.ShortcutsEnabled = true;
            this.txt_salt.Size = new System.Drawing.Size(196, 23);
            this.txt_salt.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_salt.TabIndex = 6;
            this.txt_salt.UseSelectable = true;
            this.txt_salt.WaterMark = "Salt";
            this.txt_salt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_salt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmb_Algorithms
            // 
            this.cmb_Algorithms.FormattingEnabled = true;
            this.cmb_Algorithms.ItemHeight = 23;
            this.cmb_Algorithms.Location = new System.Drawing.Point(30, 140);
            this.cmb_Algorithms.Name = "cmb_Algorithms";
            this.cmb_Algorithms.Size = new System.Drawing.Size(616, 29);
            this.cmb_Algorithms.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmb_Algorithms.TabIndex = 7;
            this.cmb_Algorithms.UseSelectable = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(31, 208);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(629, 261);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.TabIndex = 8;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.txt_InputText);
            this.metroTabPage1.Controls.Add(this.txt_Result);
            this.metroTabPage1.Controls.Add(this.btn_Decrypt);
            this.metroTabPage1.Controls.Add(this.btn_Encrypt);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(621, 219);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Text Encryption";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btn_DecryptFile);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.btn_EncryptFile);
            this.metroTabPage2.Controls.Add(this.ofd_2);
            this.metroTabPage2.Controls.Add(this.ofd_1);
            this.metroTabPage2.Controls.Add(this.txtDestinationFile);
            this.metroTabPage2.Controls.Add(this.txtSourceFile);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(621, 219);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "File Encryption";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btn_DecryptFile
            // 
            this.btn_DecryptFile.Location = new System.Drawing.Point(444, 131);
            this.btn_DecryptFile.Name = "btn_DecryptFile";
            this.btn_DecryptFile.Size = new System.Drawing.Size(125, 33);
            this.btn_DecryptFile.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_DecryptFile.TabIndex = 4;
            this.btn_DecryptFile.Text = "Decrypt";
            this.btn_DecryptFile.UseSelectable = true;
            this.btn_DecryptFile.Click += new System.EventHandler(this.btn_DecryptFile_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(22, 96);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(122, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Destination Folder :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 61);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Source File :";
            // 
            // btn_EncryptFile
            // 
            this.btn_EncryptFile.Location = new System.Drawing.Point(313, 131);
            this.btn_EncryptFile.Name = "btn_EncryptFile";
            this.btn_EncryptFile.Size = new System.Drawing.Size(125, 33);
            this.btn_EncryptFile.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_EncryptFile.TabIndex = 4;
            this.btn_EncryptFile.Text = "Encrypt";
            this.btn_EncryptFile.UseSelectable = true;
            this.btn_EncryptFile.Click += new System.EventHandler(this.btn_EncryptFile_Click);
            // 
            // ofd_2
            // 
            this.ofd_2.Location = new System.Drawing.Point(536, 92);
            this.ofd_2.Name = "ofd_2";
            this.ofd_2.Size = new System.Drawing.Size(30, 23);
            this.ofd_2.TabIndex = 3;
            this.ofd_2.Text = "...";
            this.ofd_2.UseSelectable = true;
            this.ofd_2.Click += new System.EventHandler(this.ofd_2_Click);
            // 
            // ofd_1
            // 
            this.ofd_1.Location = new System.Drawing.Point(536, 57);
            this.ofd_1.Name = "ofd_1";
            this.ofd_1.Size = new System.Drawing.Size(30, 23);
            this.ofd_1.TabIndex = 3;
            this.ofd_1.Text = "...";
            this.ofd_1.UseSelectable = true;
            this.ofd_1.Click += new System.EventHandler(this.ofd_1_Click);
            // 
            // txtDestinationFile
            // 
            // 
            // 
            // 
            this.txtDestinationFile.CustomButton.Image = null;
            this.txtDestinationFile.CustomButton.Location = new System.Drawing.Point(338, 1);
            this.txtDestinationFile.CustomButton.Name = "";
            this.txtDestinationFile.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDestinationFile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDestinationFile.CustomButton.TabIndex = 1;
            this.txtDestinationFile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDestinationFile.CustomButton.UseSelectable = true;
            this.txtDestinationFile.CustomButton.Visible = false;
            this.txtDestinationFile.Enabled = false;
            this.txtDestinationFile.Lines = new string[0];
            this.txtDestinationFile.Location = new System.Drawing.Point(165, 92);
            this.txtDestinationFile.MaxLength = 32767;
            this.txtDestinationFile.Name = "txtDestinationFile";
            this.txtDestinationFile.PasswordChar = '\0';
            this.txtDestinationFile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDestinationFile.SelectedText = "";
            this.txtDestinationFile.SelectionLength = 0;
            this.txtDestinationFile.SelectionStart = 0;
            this.txtDestinationFile.ShortcutsEnabled = true;
            this.txtDestinationFile.Size = new System.Drawing.Size(360, 23);
            this.txtDestinationFile.TabIndex = 2;
            this.txtDestinationFile.UseSelectable = true;
            this.txtDestinationFile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDestinationFile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSourceFile
            // 
            // 
            // 
            // 
            this.txtSourceFile.CustomButton.Image = null;
            this.txtSourceFile.CustomButton.Location = new System.Drawing.Point(338, 1);
            this.txtSourceFile.CustomButton.Name = "";
            this.txtSourceFile.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSourceFile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSourceFile.CustomButton.TabIndex = 1;
            this.txtSourceFile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSourceFile.CustomButton.UseSelectable = true;
            this.txtSourceFile.CustomButton.Visible = false;
            this.txtSourceFile.Enabled = false;
            this.txtSourceFile.Lines = new string[0];
            this.txtSourceFile.Location = new System.Drawing.Point(165, 57);
            this.txtSourceFile.MaxLength = 32767;
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.PasswordChar = '\0';
            this.txtSourceFile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSourceFile.SelectedText = "";
            this.txtSourceFile.SelectionLength = 0;
            this.txtSourceFile.SelectionStart = 0;
            this.txtSourceFile.ShortcutsEnabled = true;
            this.txtSourceFile.Size = new System.Drawing.Size(360, 23);
            this.txtSourceFile.TabIndex = 2;
            this.txtSourceFile.UseSelectable = true;
            this.txtSourceFile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSourceFile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 187);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(117, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Encryption Type : ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(402, 76);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Salt : ";
            // 
            // msMgr
            // 
            this.msMgr.Owner = this;
            this.msMgr.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(23, 114);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(150, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Encryption Algorithm : ";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(153, 76);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(40, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Key : ";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 497);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmb_Algorithms);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.txt_salt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Private Key Cipher";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msMgr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_InputText;
        private MetroFramework.Controls.MetroTextBox txt_Result;
        private MetroFramework.Controls.MetroButton btn_Encrypt;
        private MetroFramework.Controls.MetroButton btn_Decrypt;
        private MetroFramework.Controls.MetroTextBox txt_key;
        private MetroFramework.Controls.MetroTextBox txt_salt;
        private MetroFramework.Controls.MetroComboBox cmb_Algorithms;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton ofd_2;
        private MetroFramework.Controls.MetroButton ofd_1;
        private MetroFramework.Controls.MetroTextBox txtDestinationFile;
        private MetroFramework.Controls.MetroTextBox txtSourceFile;
        private MetroFramework.Controls.MetroButton btn_DecryptFile;
        private MetroFramework.Controls.MetroButton btn_EncryptFile;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Components.MetroStyleManager msMgr;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}

