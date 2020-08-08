using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace kitap_tasnif
{
    public class connection
    {

        public MySqlConnection con;
        public connection()
        {
            con = getCon();
        }

        public MySqlConnection getCon()
        {
            if (con == null)
            {
                con = new MySqlConnection("Server=localhost;Port=3340;Database=kitap_tasnif;Uid=root;Pwd='Hakan.033';");
                con.Open();
                return con;
            }
            else
            {
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                else if (con.State == System.Data.ConnectionState.Open)
                    return con;
                return con;
            }
        }

    }
}
