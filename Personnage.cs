using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiVersusGame
{
    public class Personnage
    {
        public string Nom { get; private set; }
        public int PointsDeVie { get; private set; }
        public int Force { get; private set; }
        public int Defense { get; private set; }

        public Personnage(string nom, int pointsDeVie, int force, int defense)
        {
            Nom = nom;
            PointsDeVie = pointsDeVie;
            Force = force;
            Defense = defense;
        }

        public void Attaquer(Personnage cible)
        {
            // Calculer les dégâts infligés en fonction de la force et de la défense
            int degats = Math.Max(0, Force - cible.Defense);

            Console.WriteLine($"{Nom} attaque {cible.Nom} et inflige {degats} dégâts !");

            // Appliquer les dégâts à la cible
            cible.SubirDegats(degats);
        }

        public void Afk()
        {

            Console.WriteLine($"{Nom} passe son tour (le gros gland) !");

        }

        public void SubirDegats(int montant)
        {
            PointsDeVie -= montant;

            if (PointsDeVie <= 0)
            {
                PointsDeVie = 0;
                Console.WriteLine($"{Nom} a été vaincu !");
            }
        }
    }


}
