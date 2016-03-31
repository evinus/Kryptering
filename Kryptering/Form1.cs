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
            Texten = textBox1.Text;
            char[] ny = tbxNyckel.Text.ToCharArray();
            char[] teck = Texten.ToCharArray();
            for (int i = 0; i < teck.Length;i++ )
            {
                teck[i] = (char)((int)teck[i] + 1);
            }
            textBox1.Text = new string(teck);
        }

        private void btnDekryptera_Click(object sender, EventArgs e)
        {

        }
    }
}
