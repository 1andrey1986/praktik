using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AusbeuterGMBH
{
    class Mieter
    {
       
       public string  id,name,vorname,bankverbindung,e_mail,tel,parkplatz_id,wohnung_id;


        public Mieter(string id, string name, string vorname, string bankverbindung, string e_mail, string tel, string parkplatz_id, string wohnung_id) { }
        public Mieter(string id, string name, string vorname, string bankverbindung, string e_mail, string tel, string parkplatz_id, string wohnung_id)
        {
            this.id = id;
            this.name = name;
            this.vorname = vorname;
            this.bankverbindung = bankverbindung;
            this.e_mail = e_mail;
            this.tel = tel;
            this.parkplatz_id = parkplatz_id;
            this.wohnung_id = wohnung_id;
        }

        public void get(List<string> li)
        {
            id = li[0];
            name = li[1];
           vorname = li[2];
            bankverbindung = li[3];
            e_mail = li[4];
            tel = li[5];
            parkplatz_id = li[6];
            wohnung_id = li[7];
        }

        public List<string> get()
        {
            List<string> li = new List<string>();
            li[0] = id;
            li[1] = name;
            li[2] = vorname;
            li[3] = bankverbindung;
            li[4] = e_mail;
            li[5] = tel;
            li[6] = parkplatz_id;
            li[7] = wohnung_id;
            return li;
        }
    }
}
