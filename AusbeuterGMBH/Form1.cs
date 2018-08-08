using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AusbeuterGMBH
{
    public partial class Form1 : Form
    {
        List<Haus> liHaus = new List<Haus>();
        List<Wohnung> liWohnung = new List<Wohnung>();
        List<Verwalter> liVerwalter = new List<Verwalter>();
        List<Grundstueck> liGrundstueck = new List<Grundstueck>();
        List<Parkplatz> liParkplatz = new List<Parkplatz>();
        List<Mieter> liMieter = new List<Mieter>();
        List<List<string>> liBBB = new List<List<string>>();
        Datenbank db = new Datenbank();

        public Form1()
        {
            InitializeComponent();
            liBBB = db.load("verwalter");
           
            foreach(List<string> s in liBBB)
            {
                Verwalter neu = new Verwalter();
                neu.set(s);
                liVerwalter.Add(neu);
            }
            //db.save(" ");
            //liVerwalter.Add(new Verwalter())
        }

        //public List<string>

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
