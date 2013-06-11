using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSkola
{
    public class korisnik_grupa
    {
        public int ID_grupa { get; set; }
        public int ID_korisnik { get; set; }
        public bool promjena { get; set; }
        public korisnik_grupa(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_grupa = int.Parse(dr["ID_grupa"].ToString());
                ID_korisnik = int.Parse(dr["ID_korisnik"].ToString());
                promjena = false;
            }
        }
        public void setPromjena()
        {
            promjena = true;
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_grupa == 0)
            {
                sqlUpit = "INSERT INTO korisnik_grupa (ID_grupa,ID_korisnik) VALUES (" + ID_grupa + "," + ID_korisnik + ")";
            }
            else
            {
                sqlUpit = "UPDATE korisnik_grupa SET ID_grupa = " + ID_grupa
                + " WHERE ID_korisnik=" + ID_korisnik;
            }
            promjena = false;
            return baza.Instanca.IzvrsiUpit(sqlUpit);
        }
    }
}
