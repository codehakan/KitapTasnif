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
    public partial class frm_yazarekle : Form
    {
        connection baglanti;
        public frm_yazarekle()
        {
            InitializeComponent();
            if (baglanti == null)
                baglanti = new connection();
        }

        private void btn_yazarekle_Click(object sender, EventArgs e)
        {
            yazarEkle();
        }
        void yazarEkle()
        {
            try
            {
                MySqlCommand komut = new MySqlCommand("INSERT INTO yazar (yazaradi) values (@yazaradi)", baglanti.con);
                komut.Parameters.AddWithValue("@yazaradi", txt_yazaradi.Text);
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.con.Dispose();
                baglanti.con.Close();
                MessageBox.Show("Yazar başarıyla eklendi", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
