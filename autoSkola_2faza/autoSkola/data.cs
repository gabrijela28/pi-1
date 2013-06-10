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
            string sqlUpit = "SELECT ID_korisnik FROM korisnik WHERE korisnicko_ime='" + korIme +"' and lozinka='"+lozinka+"';";
            int ID = 0;
            try
            {
                ID = (int)baza.Instanca.DohvatiVrijednost(sqlUpit);
            }
            finally{
            }
            korisnik Kor = new korisnik();
            string tip = Kor.Provjera(korIme, lozinka);
            if(tip=="Učenik"){
                /// <summary>
                /// dohvača podatke koje korisnik može pregledavati i pohranjuje ih u listu
                /// </summary>
                Cjelina=new List<cjelina>();
                sqlUpit = "SELECT cjelina.ID_cjelina,cjelina.ID_predmet,cjelina.naziv,cjelina.opis,cjelina.bodovi FROM cjelina,grupa,korisnik_grupa WHERE cjelina.ID_cjelina=grupa.ID_cjelina and grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
                DbDataReader reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Cjelina.Add(new cjelina(reader));
                }
                reader.Close();

                /// <summary>
                /// postupak se ponavlja za svaku listu
                /// </summary>
                Dogadjaj = new List<dogadjaj>();
                sqlUpit = "SELECT dogadjaj.ID_dogadjaj,dogadjaj.kreirao,dogadjaj.napomena,dogadjaj.datum FROM dogadjaj,korisnik_dogadjaj WHERE dogadjaj.ID_dogadjaj=korisnik_dogadjaj.ID_dogadjaj and korisnik_dogadjaj.ID_korisnik=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Dogadjaj.Add(new dogadjaj(reader));
                }
                reader.Close();

                Grupa = new List<grupa>();
                sqlUpit = "SELECT grupa.ID_grupa,grupa.ID_cjelina,grupa.predavac FROM grupa,korisnik_grupa WHERE grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Grupa.Add(new grupa(reader));
                }
                reader.Close();

                Ispit = new List<ispit>();
                sqlUpit = "SELECT ispit.ID_ispit,ispit.ID_grupa,ispit.datum,ispit.napomena,ispit.trajanje FROM ispit,korisnik_ispit WHERE ispit.ID_ispit=korisnik_ispit.ID_ispit and korisnik_ispit.ID_korisnik=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Ispit.Add(new ispit(reader));
                }
                reader.Close();

                Korisnik = new List<korisnik>();
                sqlUpit = "SELECT * FROM korisnik WHERE ID_korisnik=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Korisnik.Add(new korisnik(reader));
                }
                reader.Close();

                Korisnik_dogadjaj = new List<korisnik_dogadjaj>();
                sqlUpit = "SELECT * FROM korisnik_dogadjaj WHERE korisnik_dogadjaj.ID_korisnik=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Korisnik_dogadjaj.Add(new korisnik_dogadjaj(reader));
                }
                reader.Close();

                Korisnik_grupa = new List<korisnik_grupa>();
                sqlUpit = "SELECT * FROM korisnik_grupa WHERE korisnik_grupa.ID_korisnik=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Korisnik_grupa.Add(new korisnik_grupa(reader));
                }
                reader.Close();

                Korisnik_ispit = new List<korisnik_ispit>();
                sqlUpit = "SELECT * FROM korisnik_ispit WHERE korisnik_ispit.ID_korisnik=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Korisnik_ispit.Add(new korisnik_ispit(reader));
                }
                reader.Close();

                KorisnikTip = new List<korisnikTip>();
                sqlUpit = "SELECT * FROM korisnikTip;";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    KorisnikTip.Add(new korisnikTip(reader));
                }
                reader.Close();

                Materijal = new List<materijal>();
                sqlUpit = "SELECT materijal.ID_materijal,materijal.ID_cjelina,materijal.opis,materijal.srcMaterijal FROM materijal,grupa,korisnik_grupa WHERE materijal.ID_cjelina=grupa.ID_cjelina and grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Materijal.Add(new materijal(reader));
                }
                reader.Close();

                Odgovor=new List<odgovor>();
                sqlUpit = "SELECT odgovor.ID_odgovor,odgovor.ID_pitanja,odgovor.tekst,odgovor.tocno,odgovor.srcOdgovor FROM odgovor,pitanja,grupa,korisnik_grupa WHERE odgovor.ID_pitanja=pitanja.ID_pitanja and pitanja.ID_cjelina=grupa.ID_cjelina and grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Odgovor.Add(new odgovor(reader));
                }
                reader.Close();

                Odgovor_ispit=new List<odgovor_ispit>();;
                sqlUpit = "SELECT odgovor_ispit.ID_korisnik_ispit,odgovor_ispit.ID_odgovor FROM odgovor_ispit,korisnik_ispit WHERE odgovor_ispit.ID_korisnik_ispit=korisnik_ispit.ID_korisnik_ispit and korisnik_ispit.ID_korisnik=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Odgovor_ispit.Add(new odgovor_ispit(reader));
                }
                reader.Close();

                Pitanja=new List<pitanja>();;
                sqlUpit = "SELECT pitanja.ID_pitanja,pitanja.ID_cjelina,pitanja.tekst,pitanja.srcPitanja,pitanja.bodovi FROM pitanja,grupa,korisnik_grupa WHERE pitanja.ID_cjelina=grupa.ID_cjelina and grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Pitanja.Add(new pitanja(reader));
                }
                reader.Close();

                Predmet=new List<predmet>();;
                sqlUpit = "SELECT predmet.ID_predmet,predmet.naziv,predmet.opis FROM predmet,cjelina,grupa,korisnik_grupa WHERE predmet.ID_predmet=cjelina.ID_predmet and cjelina.ID_cjelina=grupa.ID_cjelina and grupa.ID_grupa=korisnik_grupa.ID_grupa and korisnik_grupa.ID_korisnik=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Cjelina.Add(new cjelina(reader));
                
                }

                reader.Close();
            }
            else if(tip=="Administrator"){
                /// <summary>
                /// dohvača sve podatke i pohranjuje ih u listu
                /// </summary>
                Cjelina=new List<cjelina>();
                sqlUpit = "SELECT cjelina.ID_cjelina,cjelina.ID_predmet,cjelina.naziv,cjelina.opis,cjelina.bodovi FROM cjelina;";
                DbDataReader reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Cjelina.Add(new cjelina(reader));
                }
                reader.Close();

                /// <summary>
                /// postupak se ponavlja za svaku listu
                /// </summary>
                Dogadjaj = new List<dogadjaj>();
                sqlUpit = "SELECT dogadjaj.ID_dogadjaj,dogadjaj.kreirao,dogadjaj.napomena,dogadjaj.datum FROM dogadjaj;";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Dogadjaj.Add(new dogadjaj(reader));
                }
                reader.Close();

                Grupa = new List<grupa>();
                sqlUpit = "SELECT grupa.ID_grupa,grupa.ID_cjelina,grupa.predavac FROM grupa;";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Grupa.Add(new grupa(reader));
                }
                reader.Close();

                Ispit = new List<ispit>();
                sqlUpit = "SELECT ispit.ID_ispit,ispit.ID_grupa,ispit.datum,ispit.napomena,ispit.trajanje FROM ispit;";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Ispit.Add(new ispit(reader));
                }
                reader.Close();

                Korisnik = new List<korisnik>();
                sqlUpit = "SELECT * FROM korisnik;";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Korisnik.Add(new korisnik(reader));
                }
                reader.Close();

                Korisnik_dogadjaj = new List<korisnik_dogadjaj>();
                sqlUpit = "SELECT * FROM korisnik_dogadjaj;";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Korisnik_dogadjaj.Add(new korisnik_dogadjaj(reader));
                }
                reader.Close();

                Korisnik_grupa = new List<korisnik_grupa>();
                sqlUpit = "SELECT * FROM korisnik_grupa;";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Korisnik_grupa.Add(new korisnik_grupa(reader));
                }
                reader.Close();

                Korisnik_ispit = new List<korisnik_ispit>();
                sqlUpit = "SELECT * FROM korisnik_ispit;";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Korisnik_ispit.Add(new korisnik_ispit(reader));
                }
                reader.Close();

                KorisnikTip = new List<korisnikTip>();
                sqlUpit = "SELECT * FROM korisnikTip;";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    KorisnikTip.Add(new korisnikTip(reader));
                }
                reader.Close();

                Materijal = new List<materijal>();
                sqlUpit = "SELECT materijal.ID_materijal,materijal.ID_cjelina,materijal.opis,materijal.srcMaterijal FROM materijal;";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Materijal.Add(new materijal(reader));
                }
                reader.Close();

                Odgovor=new List<odgovor>();
                sqlUpit = "SELECT odgovor.ID_odgovor,odgovor.ID_pitanja,odgovor.tekst,odgovor.tocno,odgovor.srcOdgovor FROM odgovor;";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Odgovor.Add(new odgovor(reader));
                }
                reader.Close();

                Odgovor_ispit=new List<odgovor_ispit>();;
                sqlUpit = "SELECT odgovor_ispit.ID_korisnik_ispit,odgovor_ispit.ID_odgovor FROM odgovor_ispit;";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Odgovor_ispit.Add(new odgovor_ispit(reader));
                }
                reader.Close();

                Pitanja=new List<pitanja>();;
                sqlUpit = "SELECT pitanja.ID_pitanja,pitanja.ID_cjelina,pitanja.tekst,pitanja.srcPitanja,pitanja.bodovi FROM pitanja;";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Pitanja.Add(new pitanja(reader));
                }
                reader.Close();

                Predmet=new List<predmet>();;
                sqlUpit = "SELECT predmet.ID_predmet,predmet.naziv,predmet.opis FROM predmet;";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Cjelina.Add(new cjelina(reader));
                
                }

                reader.Close();
            }
            else if(tip=="Predavač" || tip=="Instruktor")
            {
                /// <summary>
                /// dohvača podatke koje korisnik može pregledavati i pohranjuje ih u listu
                /// </summary>
                Cjelina = new List<cjelina>();
                sqlUpit = "SELECT cjelina.ID_cjelina,cjelina.ID_predmet,cjelina.naziv,cjelina.opis,cjelina.bodovi FROM cjelina,grupa WHERE cjelina.ID_cjelina=grupa.ID_cjelina and grupa.predavac=" + ID + ";";
                DbDataReader reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Cjelina.Add(new cjelina(reader));
                }
                reader.Close();

                /// <summary>
                /// postupak se ponavlja za svaku listu
                /// </summary>
                Dogadjaj = new List<dogadjaj>();
                sqlUpit = "SELECT dogadjaj.ID_dogadjaj,dogadjaj.kreirao,dogadjaj.napomena,dogadjaj.datum FROM dogadjaj,korisnik_dogadjaj WHERE dogadjaj.kreirao=" + ID + "OR (dogadjaj.ID_dogadjaj=korisnik_dogadjaj.ID_dogadjaj AND korisnik_dogadjaj.ID_korisnik="+ID+");";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Dogadjaj.Add(new dogadjaj(reader));
                }
                reader.Close();

                Grupa = new List<grupa>();
                sqlUpit = "SELECT grupa.ID_grupa,grupa.ID_cjelina,grupa.predavac FROM grupa WHERE grupa.predavac=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Grupa.Add(new grupa(reader));
                }
                reader.Close();

                Ispit = new List<ispit>();
                sqlUpit = "SELECT ispit.ID_ispit,ispit.ID_grupa,ispit.datum,ispit.napomena,ispit.trajanje FROM ispit,grupa WHERE ispit.ID_grupa=grupa.ID_grupa and grupa.predavac=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Ispit.Add(new ispit(reader));
                }
                reader.Close();

                Korisnik = new List<korisnik>();
                sqlUpit = "SELECT korisnik.ID_korisnik,korisnik.ime,korisnik.prezime,korisnik.korisnicko_ime,korisnik.lozinka,korisnik.oib,korisnik.mail,korisnik.telefon,korisnik.ID_korisnikTip FROM korisnik,grupa,korisnik_grupa WHERE (korisnik.ID_korisnik=korisnik_grupa.ID_korisnik and korisnik_grupa.ID_grupa=grupa.ID_grupa and grupa.predavac=" + ID + ") or korisnik.ID_korisnikTip<>100;";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Korisnik.Add(new korisnik(reader));
                }
                reader.Close();

                Korisnik_dogadjaj = new List<korisnik_dogadjaj>();
                sqlUpit = "SELECT korisnik_dogadjaj.ID_dogadjaj,korisnik_dogadjaj.ID_korisnik,korisnik_dogadjaj.dolazak FROM korisnik_dogadjaj,dogadjaj WHERE korisnik_dogadjaj.ID_dogadjaj=dogadjaj.ID_dogadjaj and dogadjaj.kreirao=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Korisnik_dogadjaj.Add(new korisnik_dogadjaj(reader));
                }
                reader.Close();
                Korisnik_grupa = new List<korisnik_grupa>();
                sqlUpit = "SELECT korisnik_grupa.ID_grupa,korisnik_grupa.ID_korisnik FROM korisnik_grupa,grupa WHERE korisnik_grupa.ID_grupa=grupa.ID_grupa and grupa.predavac=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Korisnik_grupa.Add(new korisnik_grupa(reader));
                }
                reader.Close();

                Korisnik_ispit = new List<korisnik_ispit>();
                sqlUpit = "SELECT korisnik_ispit.ID_korisnik_ispit,korisnik_ispit.ID_korisnik,korisnik_ispit.ID_ispit FROM korisnik_ispit,ispit,grupa WHERE korisnik_ispit.ID_ispit=ispit.ID_ispit and ispit.ID_grupa=grupa.ID_grupa and grupa.predavac=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Korisnik_ispit.Add(new korisnik_ispit(reader));
                }
                reader.Close();

                KorisnikTip = new List<korisnikTip>();
                sqlUpit = "SELECT * FROM korisnikTip;";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    KorisnikTip.Add(new korisnikTip(reader));
                }
                reader.Close();

                Materijal = new List<materijal>();
                sqlUpit = "SELECT materijal.ID_materijal,materijal.ID_cjelina,materijal.opis,materijal.srcMaterijal FROM materijal,grupa WHERE materijal.ID_cjelina=grupa.ID_cjelina and grupa.predavac=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Materijal.Add(new materijal(reader));
                }
                reader.Close();

                Odgovor = new List<odgovor>();
                sqlUpit = "SELECT odgovor.ID_odgovor,odgovor.ID_pitanja,odgovor.tekst,odgovor.tocno,odgovor.srcOdgovor FROM odgovor,pitanja,grupa WHERE odgovor.ID_pitanja=pitanja.ID_pitanja and pitanja.ID_cjelina=grupa.ID_cjelina and grupa.predavac=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Odgovor.Add(new odgovor(reader));
                }
                reader.Close();

                Odgovor_ispit = new List<odgovor_ispit>(); ;
                sqlUpit = "SELECT odgovor_ispit.ID_korisnik_ispit,odgovor_ispit.ID_odgovor FROM odgovor_ispit,korisnik_ispit,ispit,grupa WHERE odgovor_ispit.ID_korisnik_ispit=korisnik_ispit.ID_korisnik_ispit and korisnik_ispit.ID_ispit=ispit.ID_ispit and ispit.ID_grupa=grupa.ID_grupa and grupa.predavac=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Odgovor_ispit.Add(new odgovor_ispit(reader));
                }
                reader.Close();

                Pitanja = new List<pitanja>(); ;
                sqlUpit = "SELECT pitanja.ID_pitanja,pitanja.ID_cjelina,pitanja.tekst,pitanja.srcPitanja,pitanja.bodovi FROM pitanja,grupa WHERE pitanja.ID_cjelina=grupa.ID_cjelina and grupa.predavac=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Pitanja.Add(new pitanja(reader));
                }
                reader.Close();

                Predmet = new List<predmet>(); ;
                sqlUpit = "SELECT predmet.ID_predmet,predmet.naziv,predmet.opis FROM predmet,cjelina,grupa WHERE predmet.ID_predmet=cjelina.ID_predmet and cjelina.ID_cjelina=grupa.ID_cjelina and grupa.predavac=" + ID + ";";
                reader = baza.Instanca.DohvatiDataReader(sqlUpit);
                while (reader.Read())
                {
                    Cjelina.Add(new cjelina(reader));

                }

                reader.Close();
            }
        }




    }
}
