using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitap_tasnif
{
    abstract class kitap
    {
        private int sirano;
        private string kitapismi;
        private string kod;

        public int siraNo
        {
            get
            {
                return sirano;
            }
            set
            {
                sirano = value;
            }
        }

        public string kitapIsmi
        {
            get
            {
                return kitapismi;
            }
            set
            {
                kitapismi = value;
            }
        }

        public string Kod
        {
            get
            {
                return kod;
            }
            set
            {
                kod = value;
            }
        }
    }
}
