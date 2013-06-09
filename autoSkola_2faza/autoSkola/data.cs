using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSkola
{
    class data
    {
        public List<cjelina> Cjelina { get; set; }
        public List<dogadjaj> Dogadjaj { get; set; }
        public List<grupa> Grupa { get; set; }
        public List<ispit> Ispit { get; set; }
        public List<korisnik> Korisnik { get; set; }
        public List<korisnik_dogadjaj> Korisnik_dogadjaj { get; set; }
        public List<korisnik_grupa> Korisnik_grupa { get; set; }
        public List<korisnik_ispit> Korisnik_ispit { get; set; }
        public List<korisnikTip> KorisnikTip { get; set; }
        public List<materijal> Materijal { get; set; }
        public List<odgovor> Odgovor { get; set; }
        public List<odgovor_ispit> Odgovor_ispit { get; set; }
        public List<pitanja> Pitanja { get; set; }
        public List<predmet> Predmet { get; set; }
        public data(string korIme, string lozinka) { 
            string sqlUpit = "SELECT ID_korisnik FROM korisnik WHERE korisnicko_ime='" + korIme +"' and lozinka='"+lozinka+"';";
            int ID = 0;
            //znaći vraća mi grešku da već postoji instanca baze koja koristi DohvatiVrijednost
            try
            {
                ID = (int)baza.Instanca.DohvatiVrijednost(sqlUpit);
            }
            finally{
            }
            Cjelina=new List<cjelina>();
            sqlUpit = "SELECT cjelina.ID_cjelina,cjelina.ID_predmet,cjelina.naziv,cjelina.opis,cjelina.bodovi FROM cjelina,grupa,korisnik_grupa WHERE cjelina.ID_cjelina=grupa.ID_cjelina and grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
            var reader = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (reader.Read())
            {
                Cjelina.Add(new cjelina(reader));
            }
            Dogadjaj = new List<dogadjaj>();
            sqlUpit = "SELECT dogadjaj.ID_dogadjaj,dogadjaj.kreirao,dogadjaj.napomena,dogadjaj.datum FROM dogadjaj,korisnik_dogadjaj WHERE dogadjaj.ID_dogadjaj=korisnik_dogadjaj.ID_dogadjaj and korisnik_dogadjaj.ID_korisnik=" + ID + ";";
            reader = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (reader.Read())
            {
                Dogadjaj.Add(new dogadjaj(reader));
            }
            Grupa = new List<grupa>();
            sqlUpit = "SELECT grupa.ID_grupa,grupa.ID_cjelina,grupa.predavac FROM grupa,korisnik_grupa WHERE grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
            reader = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (reader.Read())
            {
                Grupa.Add(new grupa(reader));
            }
            Ispit = new List<ispit>();
            sqlUpit = "SELECT ispit.ID_ispit,ispit.ID_grupa,ispit.datum,ispit.napomena,ispit.trajanje FROM ispit,korisnik_ispit WHERE ispit.ID_ispit=korisnik_ispit.ID_ispit and korisnik_ispit.ID_korisnik=" + ID + ";";
            reader = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (reader.Read())
            {
                Ispit.Add(new ispit(reader));
            }
            Korisnik = new List<korisnik>();
            sqlUpit = "SELECT * FROM korisnik WHERE ID_korisnik=" + ID + ";";
            reader = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (reader.Read())
            {
                Korisnik.Add(new korisnik(reader));
            }
            Korisnik_dogadjaj = new List<korisnik_dogadjaj>();
            sqlUpit = "SELECT * FROM korisnik_dogadjaj WHERE korisnik_dogadjaj.ID_korisnik=" + ID + ";";
            reader = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (reader.Read())
            {
                Korisnik_dogadjaj.Add(new korisnik_dogadjaj(reader));
            }
            Korisnik_grupa = new List<korisnik_grupa>();
            sqlUpit = "SELECT * FROM korisnik_grupa WHERE korisnik_grupa.ID_korisnik=" + ID + ";";
            reader = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (reader.Read())
            {
                Korisnik_grupa.Add(new korisnik_grupa(reader));
            }
            Korisnik_ispit = new List<korisnik_ispit>();
            sqlUpit = "SELECT * FROM korisnik_ispit WHERE korisnik_ispit.ID_korisnik=" + ID + ";";
            reader = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (reader.Read())
            {
                Korisnik_ispit.Add(new korisnik_ispit(reader));
            }
            KorisnikTip = new List<korisnikTip>();
            sqlUpit = "SELECT * FROM korisnikTip;";
            reader = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (reader.Read())
            {
                KorisnikTip.Add(new korisnikTip(reader));
            }
            Materijal = new List<materijal>();
            sqlUpit = "SELECT materijal.ID_materijal,materijal.ID_cjelina,materijal.opis,materijal.srcOdgovor FROM materijal,grupa,korisnik_grupa WHERE materijal.ID_cjelina=grupa.ID_cjelina and grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
            reader = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (reader.Read())
            {
                Materijal.Add(new materijal(reader));
            }
            Odgovor=new List<odgovor>();
            sqlUpit = "SELECT odgovor.ID_odgovor,odgovor.ID_pitanja,odgovor.tekst,odgovor.tocno.srcOdgovor FROM odgovor,pitanja,grupa,korisnik_grupa WHERE odgovor.ID_pitanja=pitanja.ID_pitanja and pitanja.ID_cjelina=grupa.ID_cjelina and grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
            reader = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (reader.Read())
            {
                Odgovor.Add(new odgovor(reader));
            }
            Odgovor_ispit=new List<odgovor_ispit>();;
            sqlUpit = "SELECT odgovor_ispit.ID_korisnik_ispit,odgovor_ispit.ID_odgovor FROM odgovor_ispit,korisnik_ispit WHERE odgovor_ispit.ID_korisnik_ispit=korisnik_ispit.ID_korisnik_ispit and korisnik_ispit.ID_korisnik=" + ID + ";";
            reader = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (reader.Read())
            {
                Odgovor_ispit.Add(new odgovor_ispit(reader));
            }
            Pitanja=new List<pitanja>();;
            sqlUpit = "SELECT pitanja.ID_pitanja,pitanja.ID_cjelina,pitanja.tekst,pitanja.srcPitanja,pitanja.bodovi FROM pitanja,grupa,korisnik_grupa WHERE pitanja.ID_cjelina=grupa.ID_cjelina and grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
            reader = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (reader.Read())
            {
                Pitanja.Add(new pitanja(reader));
            }
            Predmet=new List<predmet>();;
            sqlUpit = "SELECT predmet.ID_predmet,predmet.naziv,predmet.opis FROM predmet,cjelina,grupa,korisnik_grupa WHERE predmet.ID_predmet=cjelina.ID_predmet and cjelina.ID_cjelina=grupa.ID_cjelina and grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
            reader = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (reader.Read())
            {
                Cjelina.Add(new cjelina(reader));
            }
        }




    }
}
