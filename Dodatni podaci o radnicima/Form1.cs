using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dodatni_podaci_o_radnicima
{
    public partial class Form1 : Form
    {
        private OleDbConnection konekcija = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cvijander\source\repos\Relja napredni kurs\Dodatni podaci o radnicima\Dodatni podaci o radnicima\bin\Debug\baza.mdb");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void radnikePripravnikezaposleniKraceOdGodinuDanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            try
            {
                konekcija.Open();
                string tekstKomande = "select * from Radnik where DatumZaposlenja > 16/4/2020 order by Plata desc";
                OleDbCommand komanda = new OleDbCommand(tekstKomande, konekcija);
                OleDbDataAdapter adapter = new OleDbDataAdapter(komanda);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
            }
            catch (Exception x)
            {
                MessageBox.Show("Greska prilikom ispisa " + x.Message);
            }
            finally
            {
                if (konekcija.State == ConnectionState.Open)
                {
                    konekcija.Close();
                }
            }
        }

        private void prikazatiNajvecuINajmanjuPlatuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;

            try
            {
                konekcija.Open();
                string tekstKomande = "select MAX(Plata), MIN(Plata) from Radnik";
                OleDbCommand komanda = new OleDbCommand(tekstKomande, konekcija);
                OleDbDataReader citac = komanda.ExecuteReader();
                if (citac.Read() == true)
                {
                    textBox1.Text = citac[0].ToString();
                    textBox2.Text = citac[1].ToString();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Greska prilikom ispisa " + x.Message);
            }
            finally
            {
                if (konekcija.State == ConnectionState.Open)
                {
                    konekcija.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                string maxPlata = textBox1.Text;
                string tekstKomande = "select ime, prezime from Radnik where Plata=" + maxPlata;
                OleDbCommand komanda = new OleDbCommand(tekstKomande, konekcija);
                OleDbDataReader citac = komanda.ExecuteReader();
                while (citac.Read() == true)
                {
                    string odgovor = "Osoba sa najvecom platom " + citac[0].ToString() + " " + citac[1].ToString();
                    MessageBox.Show(odgovor);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Greska " + x.Message);
            }
            finally
            {
                if (konekcija.State == ConnectionState.Open)
                    konekcija.Close();
            }
        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                string minPlata = textBox2.Text;
                string tekstKomande = "select ime , prezime from Radnik where Plata=" + minPlata;
                OleDbCommand komanda = new OleDbCommand(tekstKomande, konekcija);
                OleDbDataReader citac = komanda.ExecuteReader();
                while (citac.Read() == true)
                {
                    string odgovor = "Osoba sa najmanjom platom " + citac[0] + " " + citac[1];
                    MessageBox.Show(odgovor);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (konekcija.State == ConnectionState.Open)
                    konekcija.Close();
            }
        }

        private void pronadjiRadnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;

            try
            {
                konekcija.Open();
                string tekstKomande = "select * from Radnik where ime LIKE 'M%'";
                OleDbCommand komanda = new OleDbCommand(tekstKomande, konekcija);
                OleDbDataAdapter adapter = new OleDbDataAdapter(komanda);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                dataGridView2.DataSource = tabela;
            }
            catch (Exception x)
            {
                MessageBox.Show("Greska " + x.ToString());
            }
            finally
            {
                if (konekcija.State == ConnectionState.Open)
                    konekcija.Close();
            }
        }

        private void prikazatiSveRadnikeCijePrezimeSadrziSlovoOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;

            try
            {
                konekcija.Open();
                string tekstKomande = "select * from Radnik where prezime LIKE '%O%'";
                OleDbCommand komanda = new OleDbCommand(tekstKomande, konekcija);
                OleDbDataAdapter adapter = new OleDbDataAdapter(komanda);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                dataGridView2.DataSource = tabela;
            }
            catch (Exception x)
            {
                MessageBox.Show("Greska " + x.ToString());
            }
            finally
            {
                if (konekcija.State == ConnectionState.Open)
                    konekcija.Close();
            }
        }
    }
}