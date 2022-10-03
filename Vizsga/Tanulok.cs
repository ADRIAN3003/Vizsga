using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vizsga
{
    class Tanulok
    {
        private string nev;

        public string Nev
        {
            get { return nev; }
            private set { nev = value; }
        }

        private List<double> eredmenyek;

        public List<double> Eredmenyek
        {
            get { return eredmenyek; }
            private set { eredmenyek = value; }
        }

        public bool sikeres = true;

        public bool Sikeres
        {
            get { return sikeres; }
            set { sikeres = value; }
        }

        public double Atlag { get; set; }

        public double Legjobb { get; set; }

        public double Leggyengebb { get; set; }

        public Tanulok(string sor)
        {
            string[] tmp = sor.Split(';');
            nev = tmp[0];
            eredmenyek = new List<double>();
            for (int i = 1; i < tmp.Length; i++)
            {
                double temp = Convert.ToDouble(tmp[i]);
                eredmenyek.Add(temp);

                if (temp < 0.51)
                {
                    sikeres = false;
                }
            }
            Atlag = Math.Round(Eredmenyek.Average(), 2) * 100;
            Legjobb = Math.Round(Eredmenyek.Max(), 2) * 100;
            Leggyengebb = Math.Round(Eredmenyek.Min(), 2) * 100;
        }

        public string Erdemjegy()
        {
            string vissza = "";
            if (sikeres)
            {
                double atlag = eredmenyek.Average();
                if (atlag >= 0.81)
                {
                    vissza = "jeles";
                }
                else if (atlag >= 0.71)
                {
                    vissza = "jó";
                }
                else if (atlag >= 0.61)
                {
                    vissza = "közepes";
                }
                else
                {
                    vissza = "elégséges";
                }
            }
            else
            {
                vissza = "elégtelen";
            }
            return vissza;
        }

        public override string ToString()
        {
            string kiiras = $"Tanuló neve: {Nev}\nLegjobb eredménye: {Legjobb}%\nLeggyengébb eredménye: {Leggyengebb}%\n";
            if (sikeres)
            {
                kiiras += "Sikeres vizsgát tett";
            }
            else
            {
                kiiras += "Sikertelen vizsgát tett";
            }
            return kiiras;
        }
    }
}
