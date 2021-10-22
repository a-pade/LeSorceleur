using System;
namespace LeSorceleur.Core.Classes
{
    public class Degats
    {
        private int _Degats;
        public Degats()
        {
            Random r = new Random();

            _Degats = r.Next(50, 150);
        }

        internal void Soustraire(PointDeVie pointDeVie)
        {
            while (_Degats>=0)
            {
                pointDeVie.PerdreDesPointsDeVie();
                _Degats--;
            }
            
        }
    }
}
