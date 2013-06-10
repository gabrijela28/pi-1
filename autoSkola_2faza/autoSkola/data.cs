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
    /// <summary>
    /// Klasa za povlačenje podataka s servera i pohranu u liste 
    /// </summary>
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
            /// <summary>
            /// dohvača podatke koje korisnik može pregledavati i pohranjuje ih u listu
            /// </summary>
            string sqlUpit = "SELECT ID_korisnik FROM korisnik WHERE korisnicko_ime='" + korIme +"' and lozinka='"+lozinka+"';";
            int ID = 0;
            try
            {
                ID = (int)baza.Instanca.DohvatiVrijednost(sqlUpit);
            }
            finally{
            }
            /// <summary>
            /// postupak se ponavlja za svaku listu
            /// </summary>
            Cjelina=new List<cjelina>();
            sqlUpit = "SELECT cjelina.ID_cjelina,cjelina.ID_predmet,cjelina.naziv,cjelina.opis,cjelina.bodovi FROM cjelina,grupa,korisnik_grupa WHERE cjelina.ID_cjelina=grupa.ID_cjelina and grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
            DbDataReader readerCJ = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (readerCJ.Read())
            {
                Cjelina.Add(new cjelina(readerCJ));
            }
            readerCJ.Close();
 
            Dogadjaj = new List<dogadjaj>();
            sqlUpit = "SELECT dogadjaj.ID_dogadjaj,dogadjaj.kreirao,dogadjaj.napomena,dogadjaj.datum FROM dogadjaj,korisnik_dogadjaj WHERE dogadjaj.ID_dogadjaj=korisnik_dogadjaj.ID_dogadjaj and korisnik_dogadjaj.ID_korisnik=" + ID + ";";
            DbDataReader readerDG = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (readerDG.Read())
            {
                Dogadjaj.Add(new dogadjaj(readerDG));
            }
            readerDG.Close();

            Grupa = new List<grupa>();
            sqlUpit = "SELECT grupa.ID_grupa,grupa.ID_cjelina,grupa.predavac FROM grupa,korisnik_grupa WHERE grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
            DbDataReader readerGR = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (readerGR.Read())
            {
                Grupa.Add(new grupa(readerGR));
            }
            readerGR.Close();

            Ispit = new List<ispit>();
            sqlUpit = "SELECT ispit.ID_ispit,ispit.ID_grupa,ispit.datum,ispit.napomena,ispit.trajanje FROM ispit,korisnik_ispit WHERE ispit.ID_ispit=korisnik_ispit.ID_ispit and korisnik_ispit.ID_korisnik=" + ID + ";";
            DbDataReader readerIS = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (readerIS.Read())
            {
                Ispit.Add(new ispit(readerIS));
            }
            readerIS.Close();

            Korisnik = new List<korisnik>();
            sqlUpit = "SELECT * FROM korisnik WHERE ID_korisnik=" + ID + ";";
            DbDataReader readerKR = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (readerKR.Read())
            {
                Korisnik.Add(new korisnik(readerKR));
            }
            readerKR.Close();

            Korisnik_dogadjaj = new List<korisnik_dogadjaj>();
            sqlUpit = "SELECT * FROM korisnik_dogadjaj WHERE korisnik_dogadjaj.ID_korisnik=" + ID + ";";
            DbDataReader readerKG = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (readerKG.Read())
            {
                Korisnik_dogadjaj.Add(new korisnik_dogadjaj(readerKG));
            }
            readerKG.Close();

            Korisnik_grupa = new List<korisnik_grupa>();
            sqlUpit = "SELECT * FROM korisnik_grupa WHERE korisnik_grupa.ID_korisnik=" + ID + ";";
            DbDataReader readerKGr = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (readerKGr.Read())
            {
                Korisnik_grupa.Add(new korisnik_grupa(readerKGr));
            }
            readerKGr.Close();

            Korisnik_ispit = new List<korisnik_ispit>();
            sqlUpit = "SELECT * FROM korisnik_ispit WHERE korisnik_ispit.ID_korisnik=" + ID + ";";
            DbDataReader readerKI = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (readerKI.Read())
            {
                Korisnik_ispit.Add(new korisnik_ispit(readerKI));
            }
            readerKI.Close();

            KorisnikTip = new List<korisnikTip>();
            sqlUpit = "SELECT * FROM korisnikTip;";
            DbDataReader readerKT = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (readerKT.Read())
            {
                KorisnikTip.Add(new korisnikTip(readerKT));
            }
            readerKT.Close();

            Materijal = new List<materijal>();
            sqlUpit = "SELECT materijal.ID_materijal,materijal.ID_cjelina,materijal.opis,materijal.srcMaterijal FROM materijal,grupa,korisnik_grupa WHERE materijal.ID_cjelina=grupa.ID_cjelina and grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
            DbDataReader readerMT = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (readerMT.Read())
            {
                Materijal.Add(new materijal(readerMT));
            }
            readerMT.Close();

            Odgovor=new List<odgovor>();
            sqlUpit = "SELECT odgovor.ID_odgovor,odgovor.ID_pitanja,odgovor.tekst,odgovor.tocno,odgovor.srcOdgovor FROM odgovor,pitanja,grupa,korisnik_grupa WHERE odgovor.ID_pitanja=pitanja.ID_pitanja and pitanja.ID_cjelina=grupa.ID_cjelina and grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
            DbDataReader readerOD = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (readerOD.Read())
            {
                Odgovor.Add(new odgovor(readerOD));
            }
            readerOD.Close();

            Odgovor_ispit=new List<odgovor_ispit>();;
            sqlUpit = "SELECT odgovor_ispit.ID_korisnik_ispit,odgovor_ispit.ID_odgovor FROM odgovor_ispit,korisnik_ispit WHERE odgovor_ispit.ID_korisnik_ispit=korisnik_ispit.ID_korisnik_ispit and korisnik_ispit.ID_korisnik=" + ID + ";";
            DbDataReader readerOI = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (readerOI.Read())
            {
                Odgovor_ispit.Add(new odgovor_ispit(readerOI));
            }
            readerOI.Close();

            Pitanja=new List<pitanja>();;
            sqlUpit = "SELECT pitanja.ID_pitanja,pitanja.ID_cjelina,pitanja.tekst,pitanja.srcPitanja,pitanja.bodovi FROM pitanja,grupa,korisnik_grupa WHERE pitanja.ID_cjelina=grupa.ID_cjelina and grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
            DbDataReader readerPT = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (readerPT.Read())
            {
                Pitanja.Add(new pitanja(readerPT));
            }
            readerPT.Close();

            Predmet=new List<predmet>();;
            sqlUpit = "SELECT predmet.ID_predmet,predmet.naziv,predmet.opis FROM predmet,cjelina,grupa,korisnik_grupa WHERE predmet.ID_predmet=cjelina.ID_predmet and cjelina.ID_cjelina=grupa.ID_cjelina and grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
            DbDataReader readerCJ2 = baza.Instanca.DohvatiDataReader(sqlUpit);
            while (readerCJ2.Read())
            {
                Cjelina.Add(new cjelina(readerCJ2));
                
            }

            readerCJ2.Close();
        }




    }
}
