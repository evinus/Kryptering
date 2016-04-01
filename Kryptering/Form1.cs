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
        private void btnKrypera_Click(object sender, EventArgs e)
        {
            
            char[] ny = tbxNyckel.Text.ToCharArray();
            char[] teck = textBox1.Text.ToCharArray();
            if (rbnTecken.Checked)
            {
                textBox1.Text = TeckenKrypto();
            }
        }

        private void btnDekryptera_Click(object sender, EventArgs e)
        {
            char[] ny = tbxNyckel.Text.ToCharArray();
            if (rbnTecken.Checked)
            {
                textBox1.Text = TeckenDekrypto();
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
    }
}
