using System;

namespace PileGenerique
{
    class Program
    {
        static void Main(string[] args)
        {
            Pile<Mangas> collection = new Pile<Mangas>(5);
            Mangas Yona1 = new Mangas("Princesse Yona", 1);
            Mangas Yona2 = new Mangas("Princesse Yona", 2);


            collection.Empiler(Yona1);
            collection.Empiler(Yona2);

            string choix = "-1";

            do
            {

                Console.WriteLine("1 - Ajouter un mangas");
                Console.WriteLine("2 - Retirer un mangas");
                Console.WriteLine("3 - Voir ma collection");
                choix = Console.ReadLine();


                switch (choix)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("---------------------");
                        Console.WriteLine("| Ajouter un mangas |");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Merci de saisir les informations suivantes : ");
                        Console.Write("Le titre : ");
                        string titre = Console.ReadLine();
                        Console.Write("Le numéro du tome : ");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        Mangas m = new Mangas(titre, numero);

                        collection.Empiler(m);

                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("---------------------");
                        Console.WriteLine("| Retirer un mangas |");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Liste de vos mangas : ");
                        for (int i = 0; i < 5; i++)
                        {
                            if (collection.AfficherElement(i) != null)
                            {
                                Console.WriteLine("\tMangas " + i + " : " + collection.AfficherElement(i).Titre + " Tome" + collection.AfficherElement(i).NbTome);
                            }
                        }
                        Console.Write("Saisissez la position de votre mangas : ");
                        numero = Convert.ToInt32(Console.ReadLine());
                        collection.Depiler(collection.AfficherElement(numero));
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("--------------------");
                        Console.WriteLine("| Votre collection |");
                        Console.WriteLine("--------------------");
                        for (int i = 0; i < 5; i++)
                        {                           
                            if (collection.AfficherElement(i) != null)
                            {
                                Console.WriteLine("\tMangas " + i + " : " + collection.AfficherElement(i).Titre + " Tome" + collection.AfficherElement(i).NbTome);
                            }
                            
                        }
                        break;
                    default:
                        break;
                }

            } while (choix != "0");

            
        }
    }
}
