using System;
using LeSorceleur.Core.Classes;

namespace LeSorceleur
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Personnage player1 = new Personnage();
            Personnage player2 = new Personnage();

            
            player1.AffichageDonnees();
            player2.AffichageDonnees();
        }

        
    }
}
