using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AusbeuterGMBH
{
   public class Verwalter
    {
        public string id;
        public string name, vorname, tel;

        public Verwalter() { }
        public Verwalter(string id, string name, string vorname, string tel)
        {
            this.id = id;
            this.name = name;
            this.vorname = vorname;
            this.tel = tel;
        }
        public void set (List<string> li)
        {
            id = li[0];
            name = li[1];
            vorname = li[2];
            tel = li[3];
        }

        public List<string> get()
        {
            List<string> li = new List<string>();
            li[0] = id;
            li[1] = name;
            li[2] = vorname;
            li[3] = tel;

            return li;
        }
    }
}
