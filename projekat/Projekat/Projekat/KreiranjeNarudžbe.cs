using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class KreiranjeNarudžbe : Form
    {
        public KreiranjeNarudžbe()
        {
            InitializeComponent();
        }

        String konekcioniString = Form1.konekcioniString;
        public static String kupacID = Form1.kupacID;
        public static String narudzba="";

        private void KreiranjeNarudžbe_Load(object sender, EventArgs e)
        {
            PrikazArtikala();
            Korpa();
        }

        private void ModificirajGridView(DataGridView dgv)
        {

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows.IndexOf(dgv.Rows[i]) % 2 == 0)
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.Gainsboro;
                else
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
        }

        private void PrikazArtikala()
        {
            String query = "SELECT a.artikal_id AS 'ID artikla', a.naziv_artikla AS 'Naziv', a.vrsta_artikla AS 'Vrsta',a.cijena AS 'Cijena',s.kolicina_stanje AS 'Količina' FROM artikal a,skladiste s WHERE a.artikal_id=s.artikal_id";
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
                dataAdapter.Dispose();
                konekcija.Close();

                ModificirajGridView(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonKreirajNarudžbu_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO narudzbenica(kupac_id,datum_narudzbe) VALUES('" + kupacID + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);
            konekcija.Open();
            MySqlCommand cmd = new MySqlCommand(query, konekcija);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Narudžba je kreirana.");
            konekcija.Close();

            String queryN="SELECT narudzbenica_id FROM narudzbenica WHERE kupac_id='"+ kupacID +"'AND datum_narudzbe='"+ DateTime.Now.ToString("yyyy-MM-dd") +"'";
            MySqlConnection konekcija1 = new MySqlConnection(konekcioniString);
            konekcija1.Open();
            MySqlCommand cmd1 = new MySqlCommand(query, konekcija);
            MySqlDataReader reader;
            reader = cmd1.ExecuteReader();
            reader.Read();
            narudzba=reader[0].ToString();

            konekcija1.Close();
        }

        private void Korpa()
        {
            String query = "SELECT s.stavka_id AS 'ID stavke', s.narudzbenica_id AS 'ID narudzbe', s.artikal_id AS 'ID artikla',s.kolicina AS 'Količina',a.naziv_artikla AS 'Naziv artikla' FROM artikal a,stavka_narudzbenice s WHERE s.artikal_id=a.artikal_id";
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                dataGridView2.DataSource = tabela;
                dataAdapter.Dispose();
                konekcija.Close();

                ModificirajGridView(dataGridView2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO stavka_narudzbenice(narudzbenica_id,artikal_id,kolicina) VALUES('"+narudzba+"','"+textBoxID.Text+"','"+textBoxKOL.Text+"')";
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query, konekcija);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Artikl ubačen u korpu.");
                konekcija.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



       
    }
}
