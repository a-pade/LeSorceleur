using System;
namespace LeSorceleur.Core.Classes
{
    public class VivantOuMort
    {
        private bool _VivantOuMort;
        public VivantOuMort()
        {
            _VivantOuMort = true;
        }

        public void JeSuisVivant()
        {
            _VivantOuMort = false;
        }

        internal void InfoVivantOuMort()
        {
            Console.WriteLine("Etat du Personnage: " + _VivantOuMort);
        }
    }
}
