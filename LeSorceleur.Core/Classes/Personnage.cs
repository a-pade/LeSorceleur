using System;
namespace LeSorceleur.Core.Classes
{
    public class Personnage
    {
        public int PointDeVie { get; set; }

        public int Niveau { get; set; }

        public bool Vivant { get; set; }

        public Personnage()

        {
            PointDeVie = 1000;
            Niveau = 1;
            Vivant = true;
        }

        public void Attaque(Personnage ennemie)
        {
            Random r = new Random();
            int randomDegats = r.Next(50, 150);

            int pdv = ennemie.PointDeVie - randomDegats;

            if(pdv <= 0)
            {
                ennemie.Vivant = false;
            }
            else
            {
                ennemie.PointDeVie -= randomDegats;
            }
        }

        public void Soins(Personnage allié)
        {
            if (!allié.Vivant)
            {
                return;
            }
            else
            {
                Random r = new Random();
                int randomSoins = r.Next(40, 130);

                allié.PointDeVie += randomSoins;
            }
            

        }
    }
}
