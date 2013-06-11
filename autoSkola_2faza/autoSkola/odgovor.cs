using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSkola
{
    public class odgovor
    {
        public int ID_odgovor { get; set; }
        public int ID_pitanja { get; set; }
        public string tekst { get; set; }
        public bool tocno { get; set; }
        public string srcOdgovor { get; set; }
        public bool promjena { get; set; }
        public odgovor(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_odgovor = int.Parse(dr["ID_odgovor"].ToString());
                ID_pitanja = int.Parse(dr["ID_pitanja"].ToString());
                tekst = dr["tekst"].ToString();
                tocno = (bool)dr["tocno"];
                srcOdgovor = dr["srcOdgovor"].ToString();
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
            if (ID_odgovor == 0)
            {
                sqlUpit = "INSERT INTO odgovor (ID_odgovor,ID_pitanja,tekst,tocno,srcOdgovor) VALUES (default, " + ID_pitanja + ",'" + tekst + "'," + tocno + ",'" + srcOdgovor + "')";
            }
            else
            {
                sqlUpit = "UPDATE odgovor SET ID_pitanja = " + ID_pitanja
                + ", tekst = '" + tekst
                + "', tocno = " + tocno
                + ", scrOdgovor='" + srcOdgovor
                + "' WHERE ID_odgovor=" + ID_odgovor;
            }
            promjena = false;
            return baza.Instanca.IzvrsiUpit(sqlUpit);
        }

    }
}
