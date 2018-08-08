using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AusbeuterGMBH
{
    class Datenbank
    {
        private MySqlConnection dbConnection;
        public void dbOeffnen()
        {
            try
            {
                dbConnection =
                    new MySqlConnection("Server=localhost; DATABASE=test; UID=root; PASSWORD=root; SSLMODE=NONE");

                // MessageBox.Show("Datenbank geöffnet");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void dbSchliessen()
        {
            dbConnection.Close();
        }
        public void mySQLBefel(string befehl)
        {
            dbOeffnen();
            MySqlCommand comm = dbConnection.CreateCommand();
            comm.CommandText = befehl;
            dbConnection.Open();
            comm.ExecuteNonQuery();
            dbConnection.Close();
            dbSchliessen();

        }
        public void save(string tabelenName,List<string> zeile )
        {
            string befel = $"Insert into {tabelenName} values (";
            int i = 0; 
            foreach(string wort in zeile)
            {
                if (i > 0) befel += ",";
                befel += wort;
                i++;

            }
            befel += ");";
            mySQLBefel(befel);
        }

        public List<List<string>> load(string tabelenName)
        {
            List<List<string>> liMA = new List<List<string>>();
            dbOeffnen();
            MySqlCommand comm = dbConnection.CreateCommand();
            comm.CommandText = $"select * from ausbeuter {tabelenName};";
            dbConnection.Open();
            MySqlDataReader reader = comm.ExecuteReader();

            while(reader.Read())
            {
                List<string> zeile = new List<string>();
                int j = 0;
                string wort = reader.GetString(0);
                while(wort != "" )
                {
                    j++;
                    zeile.Add(reader.GetString(j));
                    wort = reader.GetString(j);
                }
                liMA.Add(zeile);
            }
            reader.Close();
            dbConnection.Close();
            dbSchliessen();
            return liMA;
        }

        public void update(List<string> neu, List<string> alt,string tabelenName)
        {
            List<string> spaltenNamen = new List<string>();
            dbOeffnen();
            MySqlCommand comm = dbConnection.CreateCommand();
            comm.CommandText = $"desc {tabelenName};";
            dbConnection.Open();
            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                spaltenNamen.Add(reader.GetString(0));
            }
           
            //return liMA;



            string befel = $"update {tabelenName} set ";
            int i;
            for(i = 1; i<spaltenNamen.Count-1; i++)
            {
                if (i > 1) befel += ",";
                befel += $" {spaltenNamen[i]} = {neu[i]} ";
                

            }
            befel += $"{spaltenNamen[0]}=+{alt[0]};";
            mySQLBefel(befel);
            reader.Close();
            dbConnection.Close();
            dbSchliessen();
        }
        //public List<string>


    }
}
