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

            Console.WriteLine("Player 1: Je Suis Vivant, j'ai "
                    + player1.PointDeVie + "HP et je suis niveau " + player1.Niveau);

            Console.WriteLine("Player 2: Je Suis Vivant, j'ai "
                    + player2.PointDeVie + "HP et je suis niveau " + player2.Niveau);

            while (player1.Vivant.Equals(true) || player2.Vivant.Equals(true))
            {
                player1.Attaque(player2);
                Console.WriteLine(player2.PointDeVie);
                player2.Attaque(player1);
                Console.WriteLine(player1.PointDeVie);
                player1.Soins(player1);
                Console.WriteLine(player1.PointDeVie);
                player2.Soins(player2);
                Console.WriteLine(player2.PointDeVie);
            }
            
        }
    }
}
