using System;
namespace LeSorceleur.Core.Classes
{
    public class Personnage
    {
        private PersonnageEtat _personnageEtat;
        private Niveau _niveau;
        public Personnage()
        {
            _personnageEtat = new PersonnageEtat();
            _niveau = new Niveau();
        }

        public void Attaque(Personnage personnage)
        {
            personnage.PrendDegats(new Degats());
        }

        internal void PrendDegats(Degats degats)
        {
            _personnageEtat.PrendreDegat(degats);
        }

        public void Soins(Personnage personnage)
        {
            personnage.SeSoigner(new Soins());
        }

        internal void SeSoigner(Soins soins)
        {
            _personnageEtat.Soigner(soins);
        }

        public void AffichageDonnees()
        {
            Console.WriteLine("-----------------------");
            _personnageEtat.InfoEtat();
            _niveau.InfoNiveau();
            Console.WriteLine("-----------------------");
        }

        

    }
}
