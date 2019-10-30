using NBitcoin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWallet
{
    public partial class Form1 : Form
    {
        bool IsTxt_WordsPasswordChar = true;
        bool IsTxt_PasswordPasswordChar = true;
        private static Wordlist Wordlist = Wordlist.English;

        string MainNetworkPath = "m/44'/0'/0'";
        string TestNetworkPath = "m/44'/1'/0'";

        string Path
        {
            get { return Txt_Path.Text.Trim(); }
        }


        public Form1()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            Txt_Password.ReadOnly = true;
            Txt_Words.ReadOnly = true;
            Txt_MasterPublicKey.ReadOnly = true;
            Txt_Address.ReadOnly = true;
            Cmb_Network.DataSource = Enum.GetValues(typeof(NetworkType));
            Cmb_ScriptPubKeyType.DataSource = Enum.GetValues(typeof(ScriptPubKeyType));
            Cmb_ScriptPubKeyType.SelectedItem = ScriptPubKeyType.Segwit;
        }

        private void Btn_CreateWallet_Click(object sender, EventArgs e)
        {
            string basePath;
            ScriptPubKeyType scriptPubKeyType = (ScriptPubKeyType)Cmb_ScriptPubKeyType.SelectedItem;
            NetworkType networkType = (NetworkType)Cmb_Network.SelectedItem;
            Network net = Network.Main;
            if (networkType == NetworkType.Mainnet)
            {
                net = Network.Main;
            }
            else if (networkType == NetworkType.Testnet)
            {
                net = Network.TestNet;
            }
            else if (networkType == NetworkType.Regtest)
            {
                net = Network.RegTest;
            }
            basePath = Path;
            if (string.IsNullOrWhiteSpace(basePath))
            {
                if (net == Network.Main)
                {
                    basePath = MainNetworkPath;
                }
                else
                {
                    basePath = TestNetworkPath;
                }
            }

            Mnemonic mnemonic = new Mnemonic(Wordlist, WordCount.Twelve);
            var words = mnemonic.ToString();
            var password = Guid.NewGuid().ToString();
            Mnemonic mnemo = new Mnemonic(words, Wordlist);
            ExtKey hdroot = mnemo.DeriveExtKey(password);
            List<string> addresses = new List<string>();
            for (int i = 0; i < 1; i++)
            {
                var privkey = hdroot.Derive(new NBitcoin.KeyPath(basePath + "/0/" + i.ToString()));
                var publicKey = privkey.Neuter().PubKey;
                var privateKey = privkey.Neuter().GetWif(net);
                var address = publicKey.GetAddress(scriptPubKeyType, net).ToString();
                addresses.Add(address);
            }

            ExtKey masterKey = hdroot.Derive(new NBitcoin.KeyPath(basePath));
            string masterPublicKey = masterKey.Neuter().GetWif(net).ToString();
            string masterPrivateKey = masterKey.GetWif(net).ToString();

            Txt_Address.Text = addresses[0];
            Txt_Password.Text = password;
            Txt_Words.Text = words;
            Txt_MasterPublicKey.Text = masterPublicKey;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_ShowWords_Click(object sender, EventArgs e)
        {
            if (IsTxt_WordsPasswordChar)
            {
                Txt_Words.PasswordChar = Char.MinValue;
                IsTxt_WordsPasswordChar = false;
                Btn_ShowWords.Text = "Hide Password";
            }
            else
            {
                Txt_Words.PasswordChar = '*';
                IsTxt_WordsPasswordChar = true;
                Btn_ShowWords.Text = "Show Password";
            }
        }

        private void Btn_ShowPassword_Click(object sender, EventArgs e)
        {
            if (IsTxt_PasswordPasswordChar)
            {
                Txt_Password.PasswordChar = Char.MinValue;
                IsTxt_PasswordPasswordChar = false;
                Btn_ShowPassword.Text = "Hide Password";
            }
            else
            {
                Txt_Password.PasswordChar = '*';
                IsTxt_PasswordPasswordChar = true;
                Btn_ShowPassword.Text = "Show Password";
            }
        }

        private void Cmb_Network_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetMainNetworkPath();
        }

        void SetMainNetworkPath()
        {
            NetworkType networkType = (NetworkType)Cmb_Network.SelectedItem;
            if (networkType == NetworkType.Mainnet)
            {
                Txt_Path.Text = MainNetworkPath;
            }
            else
            {
                Txt_Path.Text = TestNetworkPath;
            }
        }
    }


}
