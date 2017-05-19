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
    public partial class Form4 : Form
    {
        public Form4()
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

        private void inputbtn_Click(object sender, EventArgs e)
        {
            //mengambil index yang dipilih dari combobox
            switch (comboBox1.SelectedIndex)
            {
                //jika yang dipilih index 0 (berdasarkan id)
                case 0:
                    {
                        /*//pencarian data peserta berdasarkan masukan nama
                        if (dataGridView1.Exists(pst => pst.nama == txtCari.Text))
                        {
                            Peserta p = listPeserta.Find(pst => pst.nama == txtCari.Text);
                            //jika ada, tampilkan pada messagebox
                            MessageBox.Show(
                                "ID : " + p.ID +
                                "\nNama : " + p.nama +
                                "\nAsal Sekolah : " + p.sekolah +
                                "\nLomba : " + p.lomba,
                                "Data Peserta Ditemukan"
                                );
                        }
                        else
                        {
                            MessageBox.Show(
                                "Tidak ada peserta dengan nama " + txtCari.Text,
                                "Data Peserta Tidak Ditemukan"
                                );
                        }*/
                        //this.transaksi1TableAdapter.FillByKTA(this.database1DataSet.Transaksi);

                    };
                    break;
                //jika yang dipilih index 1 (berdasarkan nama)
                case 1:
                    {
                        /*//pencarian data peserta berdasarkan masukan sekolah
                        if (listPeserta.Exists(pst => pst.sekolah == txtCari.Text))
                        {
                            Peserta p = listPeserta.Find(pst => pst.sekolah == txtCari.Text);
                            //jika ada, tampilkan pada messagebox
                            MessageBox.Show(
                                "ID : " + p.ID +
                                "\nNama : " + p.nama +
                                "\nAsal Sekolah : " + p.sekolah +
                                "\nLomba : " + p.lomba,
                                "Data Peserta Ditemukan"
                                );
                        }
                        else
                        {
                            MessageBox.Show(
                                "Tidak ada peserta dengan asal sekolah " + txtCari.Text,
                                "Data Peserta Tidak Ditemukan"
                                );
                        }*/
                        //this.transaksi1TableAdapter.FillByNama(textBox1.Text);

                    };
                    break;
            }

            //mengosongkan kembali field cari
            textBox1.Text = "";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Transaksi' table. You can move, or remove it, as needed.
            //this.transaksiTableAdapter1.Fill(this.database1DataSet.Transaksi);

        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Transaksi1' table. You can move, or remove it, as needed.
            this.transaksi1TableAdapter.Fill(this.database1DataSet.Transaksi1);

        }
    }
}
