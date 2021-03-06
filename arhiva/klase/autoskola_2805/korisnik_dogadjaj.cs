﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoskola_2805
{
    class korisnik_dogadjaj
    {
        public int ID_dogadjaj { get; set; }
        public int ID_korisnik { get; set; }
        public bool dolazak { get; set; }
        public void korisnik_dogadjaj(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_dogadjaj = int.Parse(dr["ID_dogadjaj"].ToString());
                ID_korisnik = int.Parse(dr["ID_korisnik"].ToString());
                dolazak = (bool)dr["dolazak"];
            }
        }
        public int Spremi()
        {
            string sqlUpit = "";
            if (ID_korisnik_ispit == 0)
            {
                sqlUpit = "INSERT INTO korisnik_dogadjaj (ID_dogadjaj,ID_korisnik) VALUES (" + ID_dogadjaj + "," + ID_korisnik + ","+dolazak+")";
            }
            else
            {
                sqlUpit = "UPDATE korisnik_dolazak SET ID_dogadjaj = " + ID_dogadjaj
                +"dolazak="+dolazak
                + "WHERE ID_korisnik=" + ID_korisnik;
            }
            return baza.Instance.IzvrsiUpit(sqlUpit);
        }
    }
}
