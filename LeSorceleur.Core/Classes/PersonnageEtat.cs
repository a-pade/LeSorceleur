using System;
namespace LeSorceleur.Core.Classes
{
    public class PersonnageEtat
    {

        private PointDeVie _pointDeVie;
        private VivantOuMort _vivantOuMort;

        public PersonnageEtat()
        {
            _pointDeVie = new PointDeVie();
            _vivantOuMort = new VivantOuMort();

        }

    
        public void PrendreDegat(Degats degats)
        {
            degats.Soustraire(_pointDeVie);
        }

        internal void Soigner(Soins soins)
        {
            soins.AjouterVie(_pointDeVie);
        }

        internal void InfoEtat()
        {
            _pointDeVie.InfoPointDeVie();
            _vivantOuMort.InfoVivantOuMort();
        }

        
    }
}
