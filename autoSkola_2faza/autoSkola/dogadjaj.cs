﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// za debug!
using System.Windows.Forms;

namespace autoSkola
{
    public class dogadjaj
    {
        public int ID_dogadjaj { get; set; }
        public int kreirao { get; set; }
        public string napomena { get; set; }
        public string datum { get; set; }
        public bool promjena { get; set; }
        public dogadjaj(DbDataReader dr)
        {
            if (dr != null)
            {
                ID_dogadjaj = int.Parse(dr["ID_dogadjaj"].ToString());
                kreirao = int.Parse(dr["kreirao"].ToString());
                napomena = dr["napomena"].ToString();
                datum = dr["datum"].ToString();
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
                sqlUpit = "INSERT INTO dogadjaj (ID_dogadjaj,kreirao,napomena,datum) VALUES (default, " + kreirao + ",'" + napomena + "','" + datum + "')";
            }
            else
            {
                sqlUpit = "UPDATE dogadjaj SET kreirao = " + kreirao
                + ", napomena = '" + napomena
                + "', datum='" + datum
                + "' WHERE ID_dogadjaj=" + ID_dogadjaj;
            }
            promjena = false;
            return baza.Instanca.IzvrsiUpit(sqlUpit);
        }
    }
}
