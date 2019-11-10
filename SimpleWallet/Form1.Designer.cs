namespace SimpleWallet
{
    partial class Form1
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
            this.Txt_Words = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_CreateWallet = new System.Windows.Forms.Button();
            this.Btn_ShowWords = new System.Windows.Forms.Button();
            this.Btn_ShowPassword = new System.Windows.Forms.Button();
            this.Cmb_Network = new System.Windows.Forms.ComboBox();
            this.Txt_MasterPublicKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Path = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cmb_ScriptPubKeyType = new System.Windows.Forms.ComboBox();
            this.Txt_Addresses = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Words
            // 
            this.Txt_Words.Location = new System.Drawing.Point(121, 35);
            this.Txt_Words.Multiline = true;
            this.Txt_Words.Name = "Txt_Words";
            this.Txt_Words.PasswordChar = '*';
            this.Txt_Words.Size = new System.Drawing.Size(448, 51);
            this.Txt_Words.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Words";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(130, 111);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(439, 20);
            this.Txt_Password.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pasword";
            // 
            // Txt_Address
            // 
            this.Txt_Address.Location = new System.Drawing.Point(130, 137);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(439, 20);
            this.Txt_Address.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Address";
            // 
            // Btn_CreateWallet
            // 
            this.Btn_CreateWallet.Location = new System.Drawing.Point(295, 454);
            this.Btn_CreateWallet.Name = "Btn_CreateWallet";
            this.Btn_CreateWallet.Size = new System.Drawing.Size(138, 23);
            this.Btn_CreateWallet.TabIndex = 6;
            this.Btn_CreateWallet.Text = "Create Wallet";
            this.Btn_CreateWallet.UseVisualStyleBackColor = true;
            this.Btn_CreateWallet.Click += new System.EventHandler(this.Btn_CreateWallet_Click);
            // 
            // Btn_ShowWords
            // 
            this.Btn_ShowWords.Location = new System.Drawing.Point(610, 35);
            this.Btn_ShowWords.Name = "Btn_ShowWords";
            this.Btn_ShowWords.Size = new System.Drawing.Size(106, 23);
            this.Btn_ShowWords.TabIndex = 7;
            this.Btn_ShowWords.Text = "ShowWords";
            this.Btn_ShowWords.UseVisualStyleBackColor = true;
            this.Btn_ShowWords.Click += new System.EventHandler(this.Btn_ShowWords_Click);
            // 
            // Btn_ShowPassword
            // 
            this.Btn_ShowPassword.Location = new System.Drawing.Point(610, 111);
            this.Btn_ShowPassword.Name = "Btn_ShowPassword";
            this.Btn_ShowPassword.Size = new System.Drawing.Size(106, 23);
            this.Btn_ShowPassword.TabIndex = 8;
            this.Btn_ShowPassword.Text = "Show Password";
            this.Btn_ShowPassword.UseVisualStyleBackColor = true;
            this.Btn_ShowPassword.Click += new System.EventHandler(this.Btn_ShowPassword_Click);
            // 
            // Cmb_Network
            // 
            this.Cmb_Network.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Network.FormattingEnabled = true;
            this.Cmb_Network.Location = new System.Drawing.Point(132, 429);
            this.Cmb_Network.Name = "Cmb_Network";
            this.Cmb_Network.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Network.TabIndex = 9;
            this.Cmb_Network.SelectedIndexChanged += new System.EventHandler(this.Cmb_Network_SelectedIndexChanged);
            // 
            // Txt_MasterPublicKey
            // 
            this.Txt_MasterPublicKey.Location = new System.Drawing.Point(130, 295);
            this.Txt_MasterPublicKey.Multiline = true;
            this.Txt_MasterPublicKey.Name = "Txt_MasterPublicKey";
            this.Txt_MasterPublicKey.Size = new System.Drawing.Size(439, 38);
            this.Txt_MasterPublicKey.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Master public key";
            // 
            // Txt_Path
            // 
            this.Txt_Path.Location = new System.Drawing.Point(130, 348);
            this.Txt_Path.Name = "Txt_Path";
            this.Txt_Path.Size = new System.Drawing.Size(439, 20);
            this.Txt_Path.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Path";
            // 
            // Cmb_ScriptPubKeyType
            // 
            this.Cmb_ScriptPubKeyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_ScriptPubKeyType.FormattingEnabled = true;
            this.Cmb_ScriptPubKeyType.Location = new System.Drawing.Point(132, 393);
            this.Cmb_ScriptPubKeyType.Name = "Cmb_ScriptPubKeyType";
            this.Cmb_ScriptPubKeyType.Size = new System.Drawing.Size(121, 21);
            this.Cmb_ScriptPubKeyType.TabIndex = 14;
            // 
            // Txt_Addresses
            // 
            this.Txt_Addresses.Location = new System.Drawing.Point(130, 171);
            this.Txt_Addresses.Multiline = true;
            this.Txt_Addresses.Name = "Txt_Addresses";
            this.Txt_Addresses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Addresses.Size = new System.Drawing.Size(439, 102);
            this.Txt_Addresses.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Addresses";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 550);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Addresses);
            this.Controls.Add(this.Cmb_ScriptPubKeyType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Path);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_MasterPublicKey);
            this.Controls.Add(this.Cmb_Network);
            this.Controls.Add(this.Btn_ShowPassword);
            this.Controls.Add(this.Btn_ShowWords);
            this.Controls.Add(this.Btn_CreateWallet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Words);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Words;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_CreateWallet;
        private System.Windows.Forms.Button Btn_ShowWords;
        private System.Windows.Forms.Button Btn_ShowPassword;
        private System.Windows.Forms.ComboBox Cmb_Network;
        private System.Windows.Forms.TextBox Txt_MasterPublicKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Path;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cmb_ScriptPubKeyType;
        private System.Windows.Forms.TextBox Txt_Addresses;
        private System.Windows.Forms.Label label6;
    }
}

