using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AusbeuterGMBH
{
    class Wohnung
    {
        public string id, haus_id, zimmer_anzahl, etg;

        public Wohnung() { }
        public Wohnung(string id, string haus_id, string zimmer_anzahl, string etg)
        {
            this.id = id;
            this.haus_id = haus_id;
            this.zimmer_anzahl = zimmer_anzahl;
            this.etg = etg;
        }

        public void get(List<string> li)
        {
            id = li[0];
            haus_id = li[1];
            zimmer_anzahl = li[2];
            etg = li[3];
        }

        public List<string> get()
        {
            List<string> li = new List<string>();
            li[0] = id;
            li[1] = haus_id;
            li[2] = zimmer_anzahl;
            li[3] = etg;

            return li;
        }
    }
}
