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
        }

        public string Erdemjegy()
        {
            string vissza = "";
            if (Sikeres)
            {
                double atlag = eredmenyek.Average();
            }
            else
            {
                vissza = "elégtelen";
            }
            return vissza;
        }
    }
}
