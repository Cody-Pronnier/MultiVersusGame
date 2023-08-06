using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiVersusGame.utils
{
    public class Match
    {
        private List<Personnage> personnages = new List<Personnage>();
        private int currentPlayerIndex = 0;
        

        public void AjoutJoueur(Personnage joueur)
        {
            personnages.Add(joueur);
        }

        public void ProchainTour()
        {
            Personnage personnageEnTrainDeJouer = personnages[currentPlayerIndex];
            Console.WriteLine($"C'est au tour de {personnageEnTrainDeJouer.Nom}!");
            string choix = Choix();

            if (choix == "Attaquer")
            {
                personnageEnTrainDeJouer.Attaquer(personnages[(currentPlayerIndex + 1) % personnages.Count]);

            }
            else
            {
                personnageEnTrainDeJouer.Afk();
            }
            currentPlayerIndex = (currentPlayerIndex + 1) % personnages.Count; // Passage au joueur suivant

        }

        public string Choix()
        {
            string[,] options = { { "Attaquer" }, { "Afk" } };
            GridNavigation gridNav = new GridNavigation(options);
            string choix = gridNav.DisplayGrid();
            return choix;
        }

    }


}
