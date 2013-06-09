using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// za debug!
using System.Windows.Forms;

namespace autoSkola
{
    class dogadjaj
    {
        public int ID_dogadjaj { get; set; }
        public int kreirao { get; set; }
        public string napomena { get; set; }
        public DateTime datum { get; set; }

        public dogadjaj(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_dogadjaj = int.Parse(dr["ID_dogadjaj"].ToString());
                kreirao = int.Parse(dr["kreirao"].ToString());
                napomena = dr["napomena"].ToString();
                MessageBox.Show(dr["datum"].ToString());
                datum = DateTime.Parse(dr["datum"].ToString());
            }

        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_dogadjaj == 0)
            {
                sqlUpit = "INSERT INTO dogadjaj (ID_dogadjaj,kreirao,napomena,datum) VALUES (default, " + kreirao + ",'" + napomena + "','" + datum + "')";
            }
            else
            {
                sqlUpit = "UPDATE dogadjaj SET kreirao = " + kreirao
                + ", napomena = '" + napomena
                + "'datum='" + datum
                + "'WHERE ID_dogadjaj=" + ID_dogadjaj;
            }
            return baza.Instanca.IzvrsiUpit(sqlUpit);
        }
    }
}
