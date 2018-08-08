using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AusbeuterGMBH
{
    class Grundstueck
    {
        public string id;
        public string adresse;
        public string flache;

        public Grundstueck() { }

        public Grundstueck(string id, string adresse, string flache)
        {
            this.id = id;
            this.adresse = adresse;
            this.flache = flache;
        }

        public void get(List<string> li)
        {
            id = li[0];
           adresse = li[1];
            flache = li[2];
           
        }

        public List<string> get()
        {
            List<string> li = new List<string>();
            li[0] = id;
            li[1] = adresse;
            li[2] = flache;
         

            return li;
        }
    }
}
