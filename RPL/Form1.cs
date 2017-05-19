using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void masukbtn_Click(object sender, EventArgs e)
        {
            if(uname.Text == "admin" && pass.Text == "admin")
            {
                var pindah = new Form2();
                Hide();
                pindah.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Salah username atau password!");
                uname.Focus();
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            uname.Clear();
            pass.Clear();
            uname.Focus();
        }
    }
}
