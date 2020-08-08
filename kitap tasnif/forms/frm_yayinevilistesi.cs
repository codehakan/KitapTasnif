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
    public partial class frm_yayinevilistesi : Form
    {
        connection baglanti;
        public frm_yayinevilistesi()
        {
            InitializeComponent();
            if (baglanti == null)
                baglanti = new connection();
            yayinEviGetir();
        }

        void ebatlariAyarla()
        {
            try
            {
                data_yayinevi.Columns[0].HeaderText = "Yayınevi Numarası";
                data_yayinevi.Columns[0].Width = 100;
                data_yayinevi.Columns[1].HeaderText = "Yayınevi Adı";
                data_yayinevi.Columns[1].Width = 410;
                toolStripStatusLabel1.Text = "Toplam Yayınevi Sayısı: " + data_yayinevi.Rows.Count;
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata tespit edildi.\n\n" + e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void yayinEviGetir()
        {
            try
            {
                MySqlCommand komut = new MySqlCommand("SELECT * FROM yayinevi", baglanti.con);
                MySqlDataAdapter da = new MySqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data_yayinevi.DataSource = dt;
                baglanti.con.Dispose();
                baglanti.con.Close();
                ebatlariAyarla();
            }
            catch (Exception e)
            {
                baglanti.con.Dispose();
                baglanti.con.Close();
                MessageBox.Show("Hata tespit edildi.\n\n" + e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
