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
    public partial class BrisanjeNarudžbe : Form
    {
        public BrisanjeNarudžbe()
        {
            InitializeComponent();
        }
        String konekcioniString = Form1.konekcioniString;

        private void BrisanjeNarudžbe_Load(object sender, EventArgs e)
        {
            PrikazNarudzbi();
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
        private void PrikazNarudzbi()
        {
            String query = "SELECT n.narudzbenica_id AS 'ID narudzbe', n.kupac_id AS 'ID kupca',CONCAT(k.ime,' ',k.prezime) AS 'Ime i prezime',"+
            "n.datum_narudzbe AS 'Datum narudzbe' from narudzbenica n, kupac k WHERE n.kupac_id=k.kupac_id";
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

        private void buttonBrisanjeNarudžbe_Click(object sender, EventArgs e)
        {
            string query = "DELETE from narudzbenica where narudzbenica_id='"+textBoxIDNarudzbe.Text+"'";
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query,konekcija);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Obrisana je narudzba.");
                PrikazNarudzbi();
                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
