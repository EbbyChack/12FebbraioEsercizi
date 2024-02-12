using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12FebbraioEs2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //per vedere il simbolo del euro
            Console.OutputEncoding = Encoding.UTF8;
            List<string> OrderedItems = new List<string>();
            
            Menu menu = new Menu();
            menu.PrintMenu();
            //un booleano per capire se l'utente sta ancora ordinando
            bool isOrdering = true;

            while(isOrdering)
            {
                string choice = Console.ReadLine();
                //inserisce la stringa in un array
                OrderedItems.Add(menu.LetUserPick(choice));
                if(choice == "11")
                {
                    isOrdering = false;
                    Console.WriteLine("Ordered items:");
                    //for loop per stampare tutti i prodotti ordinati
                    foreach (string item in OrderedItems)
                    {
                        Console.WriteLine($"{item}");
                    }
                    menu.ShowTotal();  
                }

                
            }

            Console.ReadLine();
        }
    }
}
