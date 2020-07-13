using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JS_LearnApp
{
    public partial class Cert : Form
    {
        public Cert(string theme)
        {
            InitializeComponent();
            lab = theme;
        }
        string lab = "";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cert_Load(object sender, EventArgs e)
        {
            label3.Text = lab;
        }

        private void Cert_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Cert_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            Close();
        }
    }
}
