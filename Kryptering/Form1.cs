using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kryptering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Texten;
        char[] alpha = "abcdefghijklmnopqrstuvwyxzåäö".ToCharArray();
        
        
        private void btnKrypera_Click(object sender, EventArgs e)
        {
            
            char[] ny = tbxNyckel.Text.ToCharArray();
            char[] teck = textBox1.Text.ToCharArray();
            int[] index = new int[teck.Length];
            int[] nyIndex = new int[ny.Length];
            if (rbnTecken.Checked)
            {
                textBox1.Text = TeckenKrypto();
            }
            if(rnSeriös.Checked)
            {
               textBox1.Text = RealDeal.Encrypt(textBox1.Text, tbxNyckel.Text);
            }
            if(rbVigenere.Checked)
            {
                char nya = alpha[3 + 5];
                for (int i =0; i < teck.Length; i++)
                {
                    for (int u = 0; u < ny.Length; u++)
                    {
                        if(teck[i] == ' ')
                        {
                            continue;
                        }
                        index[i] = Array.IndexOf(alpha, teck[i]);
                        nyIndex[u] = Array.IndexOf(alpha, ny[u]);
                        int lokal = index[i] + nyIndex[u];
                        teck[i] = alpha[lokal % 29];                   
                    }
                }
                textBox1.Text = new string(teck);
            }
        }

        private void btnDekryptera_Click(object sender, EventArgs e)
        {
            char[] ny = tbxNyckel.Text.ToCharArray();
            char[] teck = textBox1.Text.ToCharArray();
            int[] index = new int[teck.Length];
            int[] nyIndex = new int[ny.Length];
            if (rbnTecken.Checked)
            {
                textBox1.Text = TeckenDekrypto();
            }
            if(rnSeriös.Checked)
            {
                textBox1.Text = RealDeal.Decrypt(textBox1.Text, tbxNyckel.Text);
            }
            if(rbVigenere.Checked)
            {
                for (int i = 0; i < teck.Length; i++)
                {
                    for (int u = 0; u < ny.Length; u++)
                    {
                        if (teck[i] == ' ')
                        {
                            continue;
                        }
                        index[i] = Array.IndexOf(alpha, teck[i]);
                        nyIndex[u] = Array.IndexOf(alpha, ny[u]);
                        int lokal = (index[i] - nyIndex[u]) % 29;
                        if (lokal < 0)
                        {
                            lokal = lokal + 29;
                        }
                        teck[i] = alpha[lokal];

                    }
                }
                textBox1.Text = new string(teck);
            }
        }
        string TeckenKrypto()
        {
            char[] teck = textBox1.Text.ToCharArray();
            for (int i = 0; i < teck.Length; i++)
            {
                teck[i] = (char)((int)teck[i] + 1);
            }
            return new string(teck);
        }
        string TeckenDekrypto()
        {
            char[] teck = textBox1.Text.ToCharArray();
            for (int i = 0; i < teck.Length; i++)
            {
                teck[i] = (char)((int)teck[i] - 1);
            }
            return new string(teck);
        }
        //public static int FindIndex<T>(T[] array, Predicate<T> match);
    }
}
