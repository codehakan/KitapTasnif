using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kitap_tasnif.newforms
{
    public partial class frm_yazarlistesi : Form
    {
        connection baglanti;
        public frm_yazarlistesi()
        {
            InitializeComponent();
            if (baglanti == null)
                baglanti = new connection();
            yazarlariGetir();
        }

        void ebatlariAyarla()
        {
            try
            {
                data_yazar.Columns[0].HeaderText = "Yazar Numarası";
                data_yazar.Columns[0].Width = 100;
                data_yazar.Columns[1].HeaderText = "Yazar Adı";
                data_yazar.Columns[1].Width = 410;
                toolStripStatusLabel1.Text = "Toplam Yazar Sayısı: " + data_yazar.Rows.Count;
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata tespit edildi.\n\n" + e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void yazarlariGetir()
        {
            try
            {
                if (baglanti.con.State == ConnectionState.Closed)
                    baglanti.con.Open();
                MySqlCommand komut = new MySqlCommand("SELECT * FROM yazar", baglanti.con);
                MySqlDataAdapter da = new MySqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data_yazar.DataSource = dt;
                baglanti.con.Close();
                ebatlariAyarla();
            }
            catch (Exception e)
            {
                baglanti.con.Close();
                MessageBox.Show("Hata tespit edildi.\n\n" + e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
