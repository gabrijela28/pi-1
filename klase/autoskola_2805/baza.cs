using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data.Common;
using System.Data;

namespace autoskola_2805
{
    /// <summary>
    /// Klasa za rad s bazom (singleton)
    /// </summary>
    public class baza
    {
        private static baza instanca;
        private string stringKonekcija;
        private SQLiteConnection konekcija;
        
        
        private baza()
        {
            stringKonekcija = @"Data Source= ..\..\Baza\EvidencijaStudenataPI.db3";
            konekcija = new SQLiteConnection(stringKonekcija);
            konekcija.Open();
        }

        ~ baza() 
        {
            konekcija.Close();
            konekcija = null;
        }
        
        public static baza Instanca
        {
            get
            {
                if (instanca == null)
                {
                    instanca = new baza();
                }
                return instanca;
            }
            
        }
        public string Stringkonekcija
        {
            get { return stringKonekcija; }
            private set { stringKonekcija = value; }
        }

        public SQLiteConnection Konekcija
        {
            get { return konekcija; }
            private set { konekcija = value; }
        }

        /// <summary>
        /// Dohvaća podatke u obliku DataReader objekta na temelju proslijeđenog upita.
        /// </summary>
        /// <param name="sqlUpit">SQL upit.</param>
        /// <returns>Rezultati upita.</returns>
        public DbDataReader DohvatiDataReader(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Konekcija);
            return command.ExecuteReader();
        }

        /// <summary>
        /// Dohvaća skalarnu vrijednost kao rezultat proslijeđenog upita.
        /// </summary>
        /// <param name="sqlUpit">SQL upit.</param>
        /// <returns>Skalarna vrijednost kao rezultat upita.</returns>
        public object DohvatiVrijednost(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Konekcija);
            return command.ExecuteScalar();
        }

        /// <summary>
        /// Izvršava INSERT, UPDATE, DELETE SQL izraz.
        /// </summary>
        /// <param name="sqlUpit">INSERT, UPDATE, DELETE SQL izraz.</param>
        /// <returns>Broj redaka u tablici koji su dodani, promijenjeni ili obrisani.</returns>
        public int IzvrsiUpit(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Konekcija);
            return command.ExecuteNonQuery();
        }
    }
}
