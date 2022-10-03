using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vizsga
{
    public partial class Form1 : Form
    {
        List<Tanulok> tanulok = new List<Tanulok>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("adatok.txt"))
            {
                while (!sr.EndOfStream)
                {
                    tanulok.Add(new Tanulok(sr.ReadLine()));
                }
            }

            tbBeolvasas.Text = tanulok.Count + " vizsgázó adatait beolvastuk";

            foreach (var tanulo in tanulok)
            {
                lboxAdatok.Items.Add(tanulo.Nev);
            }
        }

        private void btnSikeres_Click(object sender, EventArgs e)
        {
            int sikeres = 0;
            foreach (var tanulo in tanulok)
            {
                if (tanulo.Erdemjegy() != "elégtelen")
                {
                    sikeres++;
                }
            }
            lbFo.Text = sikeres + " fő";
        }

        private void btnAllomanybaIras_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("vizsgaeredmenyek.txt"))
            {
                foreach (var tanulo in tanulok)
                {
                    sw.WriteLine(tanulo.Nev + "\t\t" + Convert.ToInt32(tanulo.Eredmenyek.Average()));
                }
            }
        }
    }
}
