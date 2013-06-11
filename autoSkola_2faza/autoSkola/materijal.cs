using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSkola
{
    public class materijal
    {
        public int ID_materijal { get; set; }
        public int ID_cjelina { get; set; }
        public string opis { get; set; }
        public string srcMaterijal { get; set; }
        public materijal(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_materijal = int.Parse(dr["ID_materijal"].ToString());
                ID_cjelina = int.Parse(dr["ID_cjelina"].ToString());
                opis = dr["opis"].ToString();
                srcMaterijal = dr["srcMaterijal"].ToString();
            }

        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_materijal == 0)
            {
                sqlUpit = "INSERT INTO materijal (ID_materijal,ID_cjelina,opis,srcMaterijal) VALUES (default, " + ID_cjelina + ",'" + opis + "','" + srcMaterijal + "')";
            }
            else
            {
                sqlUpit = "UPDATE materijal SET ID_cjelina = " + ID_cjelina
                + ", opis = '" + opis
                + "'scrMaterijal='" + srcMaterijal
                + "'WHERE ID_materijal=" + ID_materijal;
            }
            return baza.Instanca.IzvrsiUpit(sqlUpit);
        }
    }
}
