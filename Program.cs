// See https://aka.ms/new-console-template for more information
using MultiVersusGame;
using MultiVersusGame.utils;

class Program
{
    static void Main(string[] args)
    {


        Personnage mysthen = new Personnage("Mysthen", 10, 10, 10);
        Personnage ysarion = new Personnage("Ysarion", 15, 15, 5);

        Match match = new Match();
        match.AjoutJoueur(mysthen);
        match.AjoutJoueur(ysarion);
        
        while(!(mysthen.PointsDeVie == 0))
        {
            match.ProchainTour();  
        }

        // string[,] options = { { "Attaquer" },
        //                     { "Afk" } };

        // GridNavigation gridNav = new GridNavigation(options);


        //mysthen.Attaquer(ysarion);
        //ysarion.Attaquer(mysthen);
        //mysthen.Afk();
        //ysarion.Attaquer(mysthen);
    }
}