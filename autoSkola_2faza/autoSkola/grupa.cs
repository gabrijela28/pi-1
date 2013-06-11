using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSkola
{
    public class grupa
    {
        public int ID_grupa { get; set; }
        public int ID_cjelina { get; set; }
        public int predavac { get; set; }
        public grupa(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_grupa = int.Parse(dr["ID_grupa"].ToString());
                ID_cjelina = int.Parse(dr["ID_cjelina"].ToString());
                predavac = int.Parse(dr["predavac"].ToString());
            }

        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_grupa == 0)
            {
                sqlUpit = "INSERT INTO grupa (ID_grupa,ID_cjelina,predavac) VALUES (default, " + ID_cjelina + "," + predavac + ")";
            }
            else
            {
                sqlUpit = "UPDATE grupa SET ID_cjelina = " + ID_cjelina
                + ", predavac = " + predavac
                + "WHERE ID_grupa=" + ID_grupa;
            }
            return baza.Instanca.IzvrsiUpit(sqlUpit);
        }
    }
}
