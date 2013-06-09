using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoskola_2805
{
    class korisnik_grupa
    {
        public int ID_grupa { get; set; }
        public int ID_korisnik { get; set; }
        public void korisnik_ispit(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_grupa = int.Parse(dr["ID_grupa"].ToString());
                ID_korisnik = int.Parse(dr["ID_korisnik"].ToString());

            }
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_korisnik_ispit == 0)
            {
                sqlUpit = "INSERT INTO korisnik_grupa (ID_grupa,ID_korisnik) VALUES (" + ID_grupa + "," + ID_korisnik + ")";
            }
            else
            {
                sqlUpit = "UPDATE korisnik_grupa SET ID_grupa = " + ID_grupa
                + "WHERE ID_korisnik=" + ID_korisnik;
            }
            return baza.Instance.IzvrsiUpit(sqlUpit);
        }
    }
}
