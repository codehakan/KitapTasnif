using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kitap_tasnif.newforms
{
    public partial class frm_yayineviekle : Form
    {
        connection baglanti;
        public frm_yayineviekle()
        {
            InitializeComponent();
            if (baglanti == null)
                baglanti = new connection();
        }

        private void btn_yayineviekle_Click(object sender, EventArgs e)
        {
            yayinEviEkle();
        }

        void yayinEviEkle()
        {
            try
            {
                MySqlCommand komut = new MySqlCommand("INSERT INTO yayinevi (yayineviadi) values (@yayineviadi)", baglanti.con);
                komut.Parameters.AddWithValue("@yayineviadi", txt_yayineviadi.Text);
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.con.Dispose();
                baglanti.con.Close();
                MessageBox.Show("Yayınevi başarıyla eklendi", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
