using System;
namespace LeSorceleur.Core.Classes
{
    public class PointDeVie
    {
        private int _PointDeVie;
        private VivantOuMort _vivantOuMort;
        public PointDeVie()
        {
            _PointDeVie = 1000;
        }

        public void PerdreDesPointsDeVie()
        {
            if (_PointDeVie -1 > 0)
            {
                _PointDeVie -= 1;
            }
            if(_PointDeVie -1 <= 0)
            {
                _vivantOuMort.JeSuisVivant();
            }
        }

        public void AjouterDesPointsDeVie()
        {
            if(_PointDeVie + 1 > 0 || _PointDeVie + 1 < 1000)
            {
                _PointDeVie += 1;
            }
            
        }

        internal void InfoPointDeVie()
        {
            Console.WriteLine("Point de Vie: " + _PointDeVie);
        }
    }
}
