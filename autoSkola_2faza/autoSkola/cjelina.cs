using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSkola
{
    public class cjelina
    {
        public int ID_cjelina { get; set; }
        public int ID_predmet { get; set; }
        public string naziv { get; set; }
        public string opis { get; set; }
        public float bodovi { get; set; }
        public bool promjena { get; set; }
        public cjelina(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_cjelina = int.Parse(dr["ID_cjelina"].ToString());
                ID_predmet = int.Parse(dr["ID_predmet"].ToString());
                naziv = dr["naziv"].ToString();
                opis = dr["opis"].ToString();
                bodovi = float.Parse(dr["bodovi"].ToString());
                promjena = false;
            }

        }
        public void setPromjena() {
            promjena = true;
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_cjelina == 0)
            {
                sqlUpit = "INSERT INTO cjelina (ID_cjelina,ID_predmet,naziv,opis,bodovi) VALUES (default, " + ID_predmet + ",'" + naziv + "','" + opis + "'," + bodovi + ")";
            }
            else
            {
                sqlUpit = "UPDATE cjelina SET ID_predmet = " + ID_predmet
                + ", naziv = '" + naziv
                + "', opis='" + opis
                + "', bodovi=" + bodovi
                + "WHERE ID_cjelina=" + ID_cjelina;
            }
            promjena = false;
            return baza.Instanca.IzvrsiUpit(sqlUpit);
        }
    }
}
