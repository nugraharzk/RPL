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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            var pindah = new Form2();
            Hide();
            pindah.ShowDialog();
            Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Anggota' table. You can move, or remove it, as needed.
            this.anggotaTableAdapter.Fill(this.database1DataSet.Anggota);

        }
    }
}
