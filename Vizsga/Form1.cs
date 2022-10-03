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
            Beolvasas();
            DarabszamKiiras();
            NevekFeltoltese();
        }

        private void NevekFeltoltese()
        {
            foreach (var tanulo in tanulok)
            {
                lboxAdatok.Items.Add(tanulo.Nev);
            }
        }

        private void DarabszamKiiras()
        {
            tbBeolvasas.Text = tanulok.Count + " vizsgázó adatait beolvastuk";
        }

        private void Beolvasas()
        {
            using (StreamReader sr = new StreamReader("adatok.txt"))
            {
                while (!sr.EndOfStream)
                {
                    tanulok.Add(new Tanulok(sr.ReadLine()));
                }
            }
        }

        private void btnSikeres_Click(object sender, EventArgs e)
        {
            int sikeres = 0;
            foreach (var tanulo in tanulok)
            {
                if (tanulo.sikeres)
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
                    if (tanulo.sikeres)
                    {
                        sw.WriteLine(tanulo.Nev + "\t\t" + tanulo.Atlag + "\t\t" + tanulo.Erdemjegy());
                    }
                }
            }
        }
    }
}
