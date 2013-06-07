using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoskola_2805
{
    class korisnik
    {
        public int ID_korisnik { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string korisnicko_ime { get; set; }
        public string lozinka { get; set; }
        public string oib { get; set; }
        public string mail { get; set; }
        public string telefon { get; set; }
        public int ID_korisnikTip { get; set; }
        public void korisnik(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_korisnik = int.Parse(dr["ID_korisnik"].ToString());
                ime = dr["ime"].ToString();
                prezime = dr["prezime"].ToString();
                korisnicko_ime = dr["korisnicko_ime"].ToString();
                lozinka = dr["lozinka"].ToString();
                oib = dr["oib"].ToString();
                mail = dr["mail"].ToString();
                telefon = dr["telefon"].ToString();
                ID_korisnikTip = int.Parse(dr["ID_korisnikTip"].ToString());
            }

        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_korisnik == 0)
            {
                sqlUpit = "INSERT INTO korisnik (ID_korisnik,ime,prezime,korisnicko_ime,lozinka,oib,mail,telefon,ID_korisnikTip) VALUES (default, '" + ime + "','" + prezime +  "','" +korisnicko_ime+"','"+lozinka+"','"+oib+"','"+mail+"','"+telefon+"',"+ID_korisnikTip+")";
            }
            else
            {
                sqlUpit = "UPDATE korisnik SET ime = '" + ime
                + "' prezime='"+prezime
                +"' korsinicko_ime='"+korisnicko_ime
                +"' lozinka='"+lozinka
                +"' oib='"+oib
                +"' mail='"+mail
                +"' telefon='"+telefon
                +"' ID_korisnikTip="+ID_korisnikTip
                + "WHERE ID_korisnik=" + ID_korisnik;
            }
            return baza.Instance.IzvrsiUpit(sqlUpit);
        }
    }
}
