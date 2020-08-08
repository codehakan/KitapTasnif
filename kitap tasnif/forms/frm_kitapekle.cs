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
    public partial class frm_kitapekle : Form
    {
        connection baglanti;
        public frm_kitapekle()
        {
            InitializeComponent();
            baglanti = new connection();
            yazarlariCek();
            yayinevleriniCek();
        }


        private void txt_kitapadi_Enter(object sender, EventArgs e)
        {
            if (txt_kitapadi.Text == "Kitap ismini girin.")
            {
                txt_kitapadi.ForeColor = Color.Black;
                txt_kitapadi.Text = "";
            }
        }

        private void txt_kitapadi_Leave(object sender, EventArgs e)
        {
            if (txt_kitapadi.Text == "")
            {
                txt_kitapadi.Text = "Kitap ismini girin.";
                txt_kitapadi.ForeColor = Color.Gray;
            }
        }

        private void txt_kitapkodu_Enter(object sender, EventArgs e)
        {
            if (txt_kitapkodu.Text == "Kitap kodunu girin.")
            {
                txt_kitapkodu.ForeColor = Color.Black;
                txt_kitapkodu.Text = "";
            }
        }

        private void txt_kitapkodu_Leave(object sender, EventArgs e)
        {
            if (txt_kitapkodu.Text == "")
            {
                txt_kitapkodu.Text = "Kitap kodunu girin.";
                txt_kitapkodu.ForeColor = Color.Gray;
            }
        }

        private void check_yazarekle_CheckedChanged(object sender, EventArgs e)
        {
            if (check_yazarekle.Checked == true)
            {
                cmbx_yazarlar.Visible = false;
                txt_yazaradi.Visible = true;
            }
            else
            {
                cmbx_yazarlar.Visible = true;
                txt_yazaradi.Visible = false;
            }
        }

        private void txt_yazaradi_Enter(object sender, EventArgs e)
        {
            if (txt_yazaradi.Text == "Yazar ismini girin.")
            {
                txt_yazaradi.ForeColor = Color.Black;
                txt_yazaradi.Text = "";
            }
        }

        private void txt_yazaradi_Leave(object sender, EventArgs e)
        {
            if (txt_yazaradi.Text == "")
            {
                txt_yazaradi.Text = "Yazar ismini girin.";
                txt_yazaradi.ForeColor = Color.Gray;
            }
        }

        private void check_yayineviekle_CheckedChanged(object sender, EventArgs e)
        {
            if (check_yayineviekle.Checked == true)
            {
                cmbx_yayinevleri.Visible = false;
                txt_yayineviadi.Visible = true;
            }
            else
            {
                cmbx_yayinevleri.Visible = true;
                txt_yayineviadi.Visible = false;
            }
        }

        private void txt_yayineviadi_Enter(object sender, EventArgs e)
        {
            if (txt_yayineviadi.Text == "Yayınevi ismini girin.")
            {
                txt_yayineviadi.ForeColor = Color.Black;
                txt_yayineviadi.Text = "";
            }
        }

        private void txt_yayineviadi_Leave(object sender, EventArgs e)
        {
            if (txt_yayineviadi.Text == "")
            {
                txt_yayineviadi.Text = "Yayınevi ismini girin.";
                txt_yayineviadi.ForeColor = Color.Gray;
            }
        }

        private void btn_yazarekle_Click(object sender, EventArgs e)
        {
            kitapEkle();
            var mfrm = (frm_main)Application.OpenForms["degisiklikSonrası"];
            if (mfrm != null)
                mfrm.degisiklikSonrası();
        }

        void kitapEkle()
        {
            try
            {
                if (baglanti.con.State == ConnectionState.Closed)
                    baglanti.con.Open();
                int yazarid = -1;
                int yayineviid = -1;

                if (check_yazarekle.Checked == true)
                {
                    MySqlCommand komut_yazar = new MySqlCommand("INSERT INTO yazar (yazaradi) values (@ad)", baglanti.con);
                    komut_yazar.Parameters.AddWithValue("@ad", txt_yazaradi.Text);
                    komut_yazar.ExecuteNonQuery();
                    komut_yazar = new MySqlCommand("SELECT yazarid from yazar ORDER BY yazarid DESC LIMIT 1", baglanti.con);
                    MySqlDataReader oku = komut_yazar.ExecuteReader();
                    if (oku.Read())
                        yazarid = Convert.ToInt32(oku["yazarid"]);
                    oku.Close();
                }
                if (check_yayineviekle.Checked == true)
                {
                    MySqlCommand komut_yayinevi = new MySqlCommand("INSERT INTO yayinevi (yayineviadi) values (@ad)", baglanti.con);
                    komut_yayinevi.Parameters.AddWithValue("@ad", txt_yayineviadi.Text);
                    komut_yayinevi.ExecuteNonQuery();
                    komut_yayinevi = new MySqlCommand("SELECT yayineviid from yayinevi ORDER BY yayineviid DESC LIMIT 1", baglanti.con);
                    MySqlDataReader oku = komut_yayinevi.ExecuteReader();
                    if (oku.Read())
                        yayineviid = Convert.ToInt32(oku["yayineviid"]);
                    oku.Close();
                }

                MySqlCommand komut = new MySqlCommand("INSERT INTO kitap (kitapismi,yazaradi,yayinevi,kitapkodu) values (@isim,@yazar,@yayinevi,@kod)", baglanti.con);
                komut.Parameters.AddWithValue("@isim", txt_kitapadi.Text);
                // eğer yeni yazar ekleme aktif ise
                if (check_yazarekle.Checked == true)
                    komut.Parameters.AddWithValue("@yazar", yazarid);
                else
                {
                    MySqlCommand kmt = new MySqlCommand("SELECT yazarid from yazar where yazaradi=@ad", baglanti.con);
                    kmt.Parameters.AddWithValue("@ad", cmbx_yazarlar.Text);
                    kmt.ExecuteNonQuery();
                    MySqlDataReader ok = kmt.ExecuteReader();
                    if (ok.Read())
                        yazarid = Convert.ToInt32(ok["yazarid"]);
                    ok.Close();
                    komut.Parameters.AddWithValue("@yazar", yazarid);
                }
                // eğer yeni yayınevi ekleme aktif ise
                if (check_yayineviekle.Checked == true)
                    komut.Parameters.AddWithValue("@yayinevi", yayineviid);
                else
                {
                    MySqlCommand kmt = new MySqlCommand("SELECT yayineviid from yayinevi where yayineviadi=@ad", baglanti.con);
                    kmt.Parameters.AddWithValue("@ad", cmbx_yayinevleri.Text);
                    kmt.ExecuteNonQuery();
                    MySqlDataReader ok = kmt.ExecuteReader();
                    if (ok.Read())
                        yayineviid = Convert.ToInt32(ok["yayineviid"]);
                    ok.Close();
                    komut.Parameters.AddWithValue("@yayinevi", yayineviid);
                }
                // standart komutlar
                komut.Parameters.AddWithValue("@kod", txt_kitapkodu.Text);
                komut.ExecuteNonQuery();
                baglanti.con.Dispose();
                baglanti.con.Close();
                MessageBox.Show("Ekleme başarılı.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata ! Detaylı bilgi:\n" + e.Message, "Hata bulundu", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        void yazarlariCek()
        {
            try
            {
                MySqlCommand komut = new MySqlCommand("SELECT * from yazar", baglanti.con);
                MySqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    cmbx_yazarlar.Items.Add(oku["yazaradi"]);
                }
                oku.Close();
                baglanti.con.Close();
                if (cmbx_yazarlar.Items.Count > 0)
                {
                    cmbx_yazarlar.Sorted = true;
                    cmbx_yazarlar.SelectedIndex = 1;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Hata ! Detaylı bilgi:\n" + e.Message, "Hata bulundu", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        void yayinevleriniCek()
        {
            try
            {
                if (baglanti.con.State == ConnectionState.Closed)
                    baglanti.con.Open();

                MySqlCommand komut = new MySqlCommand("SELECT * from yayinevi", baglanti.con);
                MySqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    cmbx_yayinevleri.Items.Add(oku["yayineviadi"]);
                }
                if (cmbx_yayinevleri.Items.Count > 0)
                {
                    cmbx_yayinevleri.Sorted = true;
                    cmbx_yayinevleri.SelectedIndex = 1;
                }
                oku.Close();
                baglanti.con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata ! Detaylı bilgi:\n" + e.Message, "Hata bulundu", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
    }
}
