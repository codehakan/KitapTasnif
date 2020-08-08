using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kitap_tasnif.report;
using MySql.Data;
using MySql.Data.MySqlClient;
using DevExpress.XtraReports.UI;
using kitap_tasnif.forms;
using DevExpress.XtraEditors;

namespace kitap_tasnif.newforms
{
    public partial class frm_main : Form
    {
        public connection baglanti;
        kitap ktp;
        DataTable dt = new DataTable();


        public frm_main()
        {
            InitializeComponent();
            baglanti = new connection();
            baglanti.con = baglanti.getCon();
            status_label1.Text = "Bugün: " + DateTime.Today.ToShortDateString();
            degisiklikSonrası();
        }

        public void degisiklikSonrası()
        {
            cek();
            ayarla();
        }

        public void ayarla()
        {
            data_allBooks.Columns[0].HeaderText = "Sıra No";
            data_allBooks.Columns[0].Width = 50;
            data_allBooks.Columns[1].HeaderText = "Kitap İsmi";
            data_allBooks.Columns[1].Width = 420;
            data_allBooks.Columns[2].HeaderText = "Yazar Adı";
            data_allBooks.Columns[2].Width = 270;
            data_allBooks.Columns[3].HeaderText = "Yayınevi";
            data_allBooks.Columns[3].Width = 150;
            data_allBooks.Columns[4].HeaderText = "Kütüphane Kodu";
            data_allBooks.Columns[4].Width = 140;
            btn_toplamKitap.Text = "Toplam Kitap Sayısı: " + data_allBooks.Rows.Count.ToString();
        }

        public void cek()
        {
            try
            {
                dt.Clear();
                if (baglanti.con.State == ConnectionState.Closed)
                    baglanti.con.Open();
                MySqlCommand komut = new MySqlCommand("select kitapid,kitapismi,yazar.yazaradi,yayinevi.yayineviadi,kitapkodu from kitap inner join yazar on kitap.yazaradi=yazar.yazarid inner join yayinevi on kitap.yayinevi=yayinevi.yayineviid", baglanti.con);
                MySqlDataAdapter da = new MySqlDataAdapter(komut);
                da.Fill(dt);
                data_allBooks.DataSource = dt;
                komut.ExecuteNonQuery();
                baglanti.con.Close();
            }
            catch (Exception e)
            {
                baglanti.con.Close();
                MessageBox.Show("Hata tespit edildi.\n\n" + e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Programdan çıkış yapmak istiyor musunuz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_yazarekle_Click(object sender, EventArgs e)
        {
            frm_yazarekle frm = new frm_yazarekle();
            frm.ShowDialog();
            degisiklikSonrası();
        }

        private void frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            frm_kitapekle frm = new frm_kitapekle();
            frm.ShowDialog();
            degisiklikSonrası();
        }

        private void btn_yayineviekle_Click(object sender, EventArgs e)
        {
            frm_yayineviekle frm = new frm_yayineviekle();
            frm.ShowDialog();
            degisiklikSonrası();
        }

        private void yazarListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_yazarlistesi frm = new frm_yazarlistesi();
            frm.ShowDialog();
            degisiklikSonrası();
        }

        private void yayıneviListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_yayinevilistesi frm = new frm_yayinevilistesi();
            frm.ShowDialog();
            degisiklikSonrası();
        }

        private void txt_aramaYap_EditValueChanged(object sender, EventArgs e)
        {
            aramaYap();
        }

        void aramaYap()
        {
            try
            {

                string aramaTuru = "kitapismi"; // default olarak

                if (check_kitap.Checked == true)
                    aramaTuru = "kitapismi";

                else if (check_yayinevi.Checked == true)
                    aramaTuru = "yayineviadi"; // sadece bu yayınevi sütun isminde hata veriyor. Bulunamadı diyor.

                else if (check_yazar.Checked == true)
                    aramaTuru = "yazaradi"; // sadece yazar adına göre arama yapmak için

                else if (check_kod.Checked == true)
                    aramaTuru = "kitapkodu";    // sadece kitap koduna göre arama yapmak için

                DataView dv = dt.DefaultView;
                dv.RowFilter = aramaTuru + " LIKE '%" + txt_aramaYap.Text + "%'";
                data_allBooks.DataSource = dv;

                // veritabanında arama yaparak datagride yansıtma kodları
                /*
                if (baglanti.con.State == ConnectionState.Closed)
                    baglanti.con.Open();
                NpgsqlCommand komut = new NpgsqlCommand("SELECT * from kitap where " + aramaTuru + " ILIKE @isim", baglanti.con);
                komut.Parameters.AddWithValue("@isim", txt_aramaYap.Text + "%");
                komut.ExecuteNonQuery();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data_allBooks.DataSource = dt;
                baglanti.con.Close();*/
                //ayarla();
            }
            catch (Exception e)
            {
                baglanti.con.Close();
                MessageBox.Show("Hata tespit edildi.\n\n" + e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void check_kitap_CheckedChanged(object sender, EventArgs e)
        {
            if (check_kitap.Checked == true)
            {
                check_yazar.Enabled = false;
                check_yayinevi.Enabled = false;
                check_kod.Enabled = false;
            }
            else
            {
                check_yazar.Enabled = true;
                check_yayinevi.Enabled = true;
                check_kod.Enabled = true;
            }
        }

        private void check_yazar_CheckedChanged(object sender, EventArgs e)
        {
            if (check_yazar.Checked == true)
            {
                check_kitap.Enabled = false;
                check_yayinevi.Enabled = false;
                check_kod.Enabled = false;
            }
            else
            {
                check_kitap.Enabled = true;
                check_yayinevi.Enabled = true;
                check_kod.Enabled = true;
            }

        }

        private void check_yayinevi_CheckedChanged(object sender, EventArgs e)
        {
            if (check_yayinevi.Checked == true)
            {
                check_kitap.Enabled = false;
                check_yazar.Enabled = false;
                check_kod.Enabled = false;
            }
            else
            {
                check_kitap.Enabled = true;
                check_yazar.Enabled = true;
                check_kod.Enabled = true;
            }
        }

        private void excellAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //XtraReport report = new XtraReport();
            //report.LoadLayout(Application.StartupPath + "/report/raporlama.repx");
            if (baglanti.con.State == ConnectionState.Closed)
                baglanti.con.Open();
            MySqlCommand komut = new MySqlCommand("select * from kitapview", baglanti.con);
            komut.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            da.Fill(dt2);
            XtraReport1 rep = new XtraReport1();
            rep.DataSource = dt2;
            rep.ShowPreview();
            //XtraMessageBox.Show("Deneme amaçlıdır", "Selam", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        DataTable dbcek()
        {
            try
            {
                if (baglanti.con.State == ConnectionState.Closed)
                    baglanti.con.Open();
                MySqlCommand komut = new MySqlCommand("select * from kitapview", baglanti.con);
                komut.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(komut);
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private void pDFAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XtraReport rapor = new XtraReport();
            //rapor.LoadLayout(Application.StartupPath + @"/report/XtraReport1.cs");
            rapor.DataSource = dbcek();
            rapor.ShowDesigner();
        }

        private void check_kod_CheckedChanged(object sender, EventArgs e)
        {
            if (check_kod.Checked == true)
            {
                check_kitap.Enabled = false;
                check_yazar.Enabled = false;
                check_yayinevi.Enabled = false;
            }
            else
            {
                check_kitap.Enabled = true;
                check_yazar.Enabled = true;
                check_yayinevi.Enabled = true;
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_hakkinda show = new frm_hakkinda();
            show.ShowDialog();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ktp. = data_allBooks.Rows[0].Cells[2].Value.ToString();
            //MessageBox.Show(yzr.yazarAdi);
            frm_kitapduzenle frm = new frm_kitapduzenle();
            frm.ShowDialog();
        }
    }
}
