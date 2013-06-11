using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSkola
{
    public class odgovor_ispit
    {
        public int ID_korisnik_ispit { get; set; }
        public int ID_odgovor { get; set; }
        public bool promjena { get; set; }
        public odgovor_ispit(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_korisnik_ispit = int.Parse(dr["ID_korisnik_ispit"].ToString());
                ID_odgovor = int.Parse(dr["ID_odgovor"].ToString());
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
            if (ID_korisnik_ispit == 0)
            {
                sqlUpit = "INSERT INTO odgovor_ispit (ID_odgovor_ispit, ID_odgovor) VALUES (default, " + ID_odgovor + ")";
            }
            else
            {
                sqlUpit = "UPDATE odgovor_ispit SET ID_odgovor=" + ID_odgovor + " WHERE ID_odgovor_ispit=" + ID_korisnik_ispit;
            }
            promjena = false;
            return baza.Instanca.IzvrsiUpit(sqlUpit);
        }
    }
}
