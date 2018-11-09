using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar
{
    public partial class Form1 : Form
    {
        private const string V = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!" + "\"" + "#$%&\'()*+,-./:;<=>?@[\\]^_`{|}~ \t\n\r\x0b\x0c";
        //   private const string V = "0123456789aábcdeéfghiíjklmnoóöőpqrstuúüűvwxyzAÁBCDEÉFGHIÍJKLMNOÓÖŐPQRSTUÚÜŰVWXYZ!" + "\""+"#$%&\'()*+,-./:;<=>?@[\\]^_`{|}~ \t\n\r\x0b\x0c";

        public Form1()
        {
            InitializeComponent();
        }
        public string Crypt(int c)
        {
            char[] dict = V.ToCharArray();
            char[] intext = inText.Text.ToCharArray();
            string outtext = "";
            for (int i = 0; i < intext.Length; i++)
            {
                int db_index = Array.IndexOf(dict, intext[i]);
                if (db_index - c > dict.Length && c == -1)
                {
                    outtext += dict[db_index - (c) - dict.Length];
                    c = c * -1;
                }
                else if (db_index - c < 0)
                {
                    outtext += dict[dict.Length + db_index - (c)];
                    c = c * -1;
                }
                else
                {
                    outtext += dict[db_index - (c)];
                    c = c * -1;
                }
                
            }
            return outtext;
        }
        private void Encrypt_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "") { 
                int c = -1;
                string outtext=Crypt(c);
                outText.Text = outtext;
                System.IO.File.WriteAllText(@"C:\TestFolder\WriteLines.txt", outtext);

            }
            else
            {
                MessageBox.Show("verzió nincs kiválasztva");
            }
        }
        private void Decrypt_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                int c = 1;
                string outtext = Crypt(c);
                outText.Text = outtext;
            }
            else
            {
                MessageBox.Show("verzió nincs kiválasztva");
            }
        }
    }
}
