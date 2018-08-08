using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AusbeuterGMBH
{
    class Parkplatz
    {
        public string id,haus_id;
        public string parkplatzName;


        public Parkplatz() { }
        public Parkplatz(string id, string haus_id, string parkplatzName)
        {
            this.id = id;
            this.haus_id = haus_id;
            this.parkplatzName = parkplatzName;
        }

        public void get(List<string> li)
        {
            id = li[0];
            haus_id = li[1];
           parkplatzName = li[2];
           
        }

        public List<string> get()
        {
            List<string> li = new List<string>();
            li[0] = id;
            li[1] = haus_id;
            li[2] = parkplatzName;
           

            return li;
        }
    }
}
