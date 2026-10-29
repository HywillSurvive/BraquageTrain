using System.Security.Cryptography;

namespace Braquage_train;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes :
           - Utiliser une première boucle pour parcourir les quatre wagons.
           - Utiliser une deuxième boucle à l'intérieur pour parcourir les trois coffres de chaque wagon.
           - Afficher chaque coffre inspecté avec son numéro de wagon.
           - Compter le nombre total de coffres inspectés.
           
           Exemple :
               Inspection des 4 wagons du train
               Wagon 1 - Coffre 1 inspecté
               Wagon 1 - Coffre 2 inspecté
               Wagon 1 - Coffre 3 inspecté
               Wagon 2 - Coffre 1 inspecté
               ...
               Total : 12 coffres inspectés.
            
            BONUS 1 : permettre à l'utilisateur de choisir le nombre de wagons
            BONUS 2 : enregistrer l'ensemble du butin trouvé et l'afficher à la fin
         */

        int nombreTotalWagon = 0;
        int nombreTotalCoffre = 0;
        int butinTotalCoffre = 0;

        Console.WriteLine("Vous attaquez un train. \nVous allez inspecter les 4 wagons du train.");

        for (int wagon = 1; wagon < 5; wagon++)
        {
            Console.WriteLine("Voulez-vous entrer dans le wagon " + wagon + "? \nAppuyez sur 1 pour oui ou sur 0 pour non!");
            int choixWagon = Convert.ToInt32(Console.ReadLine());
            
            if (choixWagon == 1)
            {
                Console.WriteLine("Vous inspectez le wagon " + wagon + ".");
                
                for (int coffre = 1; coffre < 4; coffre++)
                {
                    int butin = RandomNumberGenerator.GetInt32(1001);
                    Console.WriteLine("Wagon " + wagon + " - Coffre " + coffre + " inspecté " + butin + " - butin");
                    butinTotalCoffre += butin;

                }
                
                nombreTotalWagon++;
                nombreTotalCoffre += 3;

            }
            if (choixWagon == 0)
            {
                if (wagon < 4)
                {
                    Console.WriteLine("Vous passé directement au wagon suivant.");
                }
            }
        }

        Console.WriteLine("\nVous avez braqué le train avec " + nombreTotalWagon + " wagon sur les 4. \nVous avez fouillé " + nombreTotalCoffre + " coffre au total.");
        Console.WriteLine("Le total de butin trouvé sélève à " + butinTotalCoffre + " Dollar.");
    }
}