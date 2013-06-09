using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSkola
{
    class pitanja
    {
        public int ID_pitanja { get; set; }
        public int ID_cjelina { get; set; }
        public string tekst { get; set; }
        public string srcPitanja { get; set; }
        public float bodovi { get; set; }
        public pitanja(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_pitanja = int.Parse(dr["ID_pitanja"].ToString());
                ID_cjelina = int.Parse(dr["ID_cjelina"].ToString());
                tekst = dr["tekst"].ToString();
                srcPitanja = dr["srcPitanja"].ToString();
                bodovi = float.Parse(dr["bodovi"].ToString());
            }
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_pitanja == 0)
            {
                sqlUpit = "INSERT INTO pitanja (ID_pitanja, ID_cjelina,tekst,srcPitanja,bodovi) VALUES (default, " + ID_cjelina + ",'" + tekst + "','" + srcPitanja + "'," + bodovi + ")";
            }
            else
            {
                sqlUpit = "UPDATE pitanja SET ID_cjelina = " + ID_cjelina
                + ", tekst = '" + tekst
                + "', srcPitanja = '" + srcPitanja
                + "', bodovi = " + bodovi
                + " WHERE ID_pitanja = " + ID_pitanja;
            }
            return baza.Instanca.IzvrsiUpit(sqlUpit);
        }
    }
}
