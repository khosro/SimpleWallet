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
            this.SuspendLayout();
            // 
            // Txt_Words
            // 
            this.Txt_Words.Location = new System.Drawing.Point(121, 35);
            this.Txt_Words.Multiline = true;
            this.Txt_Words.Name = "Txt_Words";
            this.Txt_Words.PasswordChar = '*';
            this.Txt_Words.Size = new System.Drawing.Size(448, 125);
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
            this.Txt_Password.Location = new System.Drawing.Point(121, 200);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(439, 20);
            this.Txt_Password.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pasword";
            // 
            // Txt_Address
            // 
            this.Txt_Address.Location = new System.Drawing.Point(121, 264);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(439, 20);
            this.Txt_Address.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // Btn_CreateWallet
            // 
            this.Btn_CreateWallet.Location = new System.Drawing.Point(282, 398);
            this.Btn_CreateWallet.Name = "Btn_CreateWallet";
            this.Btn_CreateWallet.Size = new System.Drawing.Size(138, 23);
            this.Btn_CreateWallet.TabIndex = 6;
            this.Btn_CreateWallet.Text = "Create Wallet";
            this.Btn_CreateWallet.UseVisualStyleBackColor = true;
            this.Btn_CreateWallet.Click += new System.EventHandler(this.Btn_CreateWallet_Click);
            // 
            // Btn_ShowWords
            // 
            this.Btn_ShowWords.Location = new System.Drawing.Point(601, 86);
            this.Btn_ShowWords.Name = "Btn_ShowWords";
            this.Btn_ShowWords.Size = new System.Drawing.Size(106, 23);
            this.Btn_ShowWords.TabIndex = 7;
            this.Btn_ShowWords.Text = "ShowWords";
            this.Btn_ShowWords.UseVisualStyleBackColor = true;
            this.Btn_ShowWords.Click += new System.EventHandler(this.Btn_ShowWords_Click);
            // 
            // Btn_ShowPassword
            // 
            this.Btn_ShowPassword.Location = new System.Drawing.Point(601, 198);
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
            this.Cmb_Network.Location = new System.Drawing.Point(121, 361);
            this.Cmb_Network.Name = "Cmb_Network";
            this.Cmb_Network.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Network.TabIndex = 9;
            // 
            // Txt_MasterPublicKey
            // 
            this.Txt_MasterPublicKey.Location = new System.Drawing.Point(121, 307);
            this.Txt_MasterPublicKey.Multiline = true;
            this.Txt_MasterPublicKey.Name = "Txt_MasterPublicKey";
            this.Txt_MasterPublicKey.Size = new System.Drawing.Size(439, 38);
            this.Txt_MasterPublicKey.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Master public key";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

