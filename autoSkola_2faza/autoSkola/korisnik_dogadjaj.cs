﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSkola
{
    public class korisnik_dogadjaj
    {
        public int ID_dogadjaj { get; set; }
        public int ID_korisnik { get; set; }
        public bool dolazak { get; set; }
        public bool promjena { get; set; }
        public korisnik_dogadjaj(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_dogadjaj = int.Parse(dr["ID_dogadjaj"].ToString());
                ID_korisnik = int.Parse(dr["ID_korisnik"].ToString());
                dolazak = (bool)dr["dolazak"];
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
            if (ID_dogadjaj == 0)
            {
                sqlUpit = "INSERT INTO korisnik_dogadjaj (ID_dogadjaj,ID_korisnik) VALUES (" + ID_dogadjaj + "," + ID_korisnik + "," + dolazak + ")";
            }
            else
            {
                sqlUpit = "UPDATE korisnik_dolazak SET ID_dogadjaj = " + ID_dogadjaj
                + ", dolazak=" + dolazak
                + " WHERE ID_korisnik=" + ID_korisnik;
            }
            promjena = false;
            return baza.Instanca.IzvrsiUpit(sqlUpit);
        }
    }
}
