using System;
namespace LeSorceleur.Core.Classes
{
    public class Soins
    {
        private int _Soins;
        public Soins()
        {
            Random r = new Random();

            _Soins = r.Next(30, 110);
        }

        internal void AjouterVie(PointDeVie pointDeVie)
        {
            while (_Soins >= 0)
            {
                pointDeVie.AjouterDesPointsDeVie();
                _Soins--;
            }
        }
    }
}
