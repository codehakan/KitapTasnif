using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitap_tasnif
{
    class yazar:kitap
    {
        int yazarid;
        string yazaradi;

        public int yazarId
        {
            get
            {
                return yazarid;
            }
            set
            {
                yazarid = value;
            }
        }

        public string yazarAdi
        {
            get
            {
                return yazaradi;
            }
            set
            {
                yazaradi = value;
            }
        }

    }
}
