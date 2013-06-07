using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoskola_2805
{
    class predmet{
        public int ID_predmet {get; set;}
        public string naziv {get; set;}
        public string opis { get; set; }
        public predmet(DbDataReader dr){
            if (dr != null){
                ID_predmet = int.Parse(dr["ID_predmet"].ToString());
                naziv = dr["naziv"].ToString();
                opis = dr["opis"].ToString();
            }
        }
        public int Spremi(){
            string sqlUpit = "";
            if (ID_predmet == 0){
                sqlUpit = "INSERT INTO predmet (ID_predmet, naziv,opis) VALUES (default, " + ID_predmet + "," + naziv + "','" + opis + "')";
            }
            else{
                sqlUpit = "UPDATE predmet SET naziv = '" + naziv
                + "', opis = '" + opis
                + "' WHERE Id = " + ID_predmet;
            }
            return baza.Instance.IzvrsiUpit(sqlUpit);
        }
    }
}
