using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AusbeuterGMBH
{
    class Haus
    {
        public string id, verw_id, lieg_id, adresse, park_anzahl, parkFrei_anzahl, etg_anzahl;


        public Haus() { }
        public Haus(string id, string verw_id, string lieg_id, string adresse, string park_anzahl, string parkFrei_anzahl, string etg_anzahl)
        {
            this.id = id;
            this.verw_id = verw_id;
            this.lieg_id = lieg_id;
            this.adresse = adresse;
            this.park_anzahl = park_anzahl;
            this.parkFrei_anzahl = parkFrei_anzahl;
            this.etg_anzahl = etg_anzahl;
        }

        public void get(List<string> li)
        {
            id = li[0];
            verw_id = li[1];
            lieg_id = li[2];
            adresse = li[3];
            park_anzahl = li[4];
            parkFrei_anzahl = li[5];
            etg_anzahl = li[6];
        }

        public List<string> get()
        {
            List<string> li = new List<string>();
            li[0] = id;
            li[1] = verw_id;
            li[2] = lieg_id;
            li[3] = park_anzahl;
            li[4] = park_anzahl;
            li[5] = parkFrei_anzahl;
            li[6] = etg_anzahl;
            return li;
        }
    }
}
