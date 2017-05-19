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
    public partial class Form3 : Form
    {
        int id;
        public Form3()
        {
            InitializeComponent();
            id = 4;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            var pindah = new Form2();
            Hide();
            pindah.ShowDialog();
            Close();
        }

        private void inputbtn_Click(object sender, EventArgs e)
        {
            // this.transaksiTableAdapter.Fill(this.database1DataSet.Transaksi);
            DateTime waktu;
            waktu = DateTime.Today;
            int harga = Convert.ToInt32(textBox3.Text);
            //kint id = 2;
            string nama = "";

            if(textBox1.Text == "A0001")
            {
                nama = "Asep";
            }
            else if(textBox1.Text == "A0002")
            {
                nama = "Bambang";
            }
            else if(textBox1.Text == "A0003")
            {
                nama = "Cecep";
            }
            string idd = Convert.ToString(id);
            string haha = Convert.ToString(waktu);

            // Save the new row to the database
            //this.transaksiTableAdapter.Insert(idd,waktu,"P0001",textBox1.Text,nama,harga);
            //this.transaksiTableAdapter.Update(this.database1DataSet.Transaksi);
            this.transaksiTableAdapter.InsertQuery(id, haha, "P0001", textBox1.Text, nama, harga);
            this.transaksiTableAdapter.Fill(this.database1DataSet.Transaksi);
            this.anggotaTableAdapter1.UpdateQuery(harga, textBox1.Text, textBox1.Text);
            id++;
            textBox1.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.database1DataSet.Transaksi);

        }
    }
}
