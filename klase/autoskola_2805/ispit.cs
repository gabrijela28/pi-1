using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoskola_2805
{
    class ispit
    {
        public int ID_ispit { get; set; }
        public int ID_grupa { get; set; }
        public DateTime datum { get; set; }
        public string napomena { get; set; }
        public DateTime trajanje { get; set; }
        public void odogovor(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_ispit = int.Parse(dr["ID_ispit"].ToString());
                ID_grupa = int.Parse(dr["ID_grupa"].ToString());
                datum = DateTime.Parse(dr["datum"].ToString());
                napomena = dr["napomena"].ToString();
                trajanje = DateTime.Parse(["trajanje"].ToString());
            }

        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_ispit == 0)//tTuple sam stao
            {
                sqlUpit = "INSERT INTO ispit (ID_ispit,ID_grupa,datum,napomena,trajanje) VALUES (default, " + ID_grupa + ",'" + datum + "','" + napomena + "','" +trajanje +"')";
            }
            else
            {
                sqlUpit = "UPDATE ispit SET ID_grupa = " + ID_grupa
                + ", datum = '" + datum
                + "' napomena='" + napomena
                + "' trajanje='"+trajanje
                + "'WHERE ID_ispit=" + ID_ispit;
            }
            return baza.Instance.IzvrsiUpit(sqlUpit);
        }
    }
}
