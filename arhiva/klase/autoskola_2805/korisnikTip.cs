using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoskola_2805
{
    class korisnikTip
    {
        public int ID_korisnikTip { get; set; }
        public string naziv { get; set; }
        public void korinkTip(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_korisnikTip = int.Parse(dr["ID_korisnikTip"].ToString());
                naziv = dr["naziv"].ToString();

            }
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_korisnikTip == 0)
            {
                sqlUpit = "INSERT INTO korisnikTip (ID_korisnikTip,naziv) VALUES (default, '" + naziv + "')";
            }
            else
            {
                sqlUpit = "UPDATE korisnikTip SET "
                + "naziv='" + naziv
                + "'WHERE ID_korisnikTip=" + ID_korisnikTip;
            }
            return baza.Instance.IzvrsiUpit(sqlUpit);
        }
    }
}
