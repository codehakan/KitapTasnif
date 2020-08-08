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

namespace kitap_tasnif.forms
{
    public partial class frm_kitapduzenle : Form
    {
        connection baglanti;
        public frm_kitapduzenle()
        {
            InitializeComponent();
            baglanti = new connection();
        }

        void yazarlariCek()
        {
            try
            {
                MySqlCommand komut = new MySqlCommand("SELECT yazarid, yazaradi from yazar where yazarid=", baglanti.con);
            }
            catch (Exception hata)
            {
                if (baglanti.con.State == ConnectionState.Open)
                    baglanti.con.Close();
                MessageBox.Show("Hata tespit edildi.\n\n" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
