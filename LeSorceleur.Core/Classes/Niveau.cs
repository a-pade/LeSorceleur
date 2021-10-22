using System;
namespace LeSorceleur.Core.Classes
{
    public class Niveau
    {
        private int _Niveau;
        public Niveau()
        {
            _Niveau = 1;
        }

        internal void InfoNiveau()
        {
            Console.WriteLine("Niveau: " + _Niveau);
        }
    }
}
