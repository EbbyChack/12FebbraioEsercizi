using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12FebbraioEs2
{
    internal class Menu
    {
        //creo due variabile per il coperto e per il totale
        double coperto = 3.00;
        double total = 0.00;
        
        

        
        //stampa il menu
        public void PrintMenu()
            {
               Console.WriteLine("============== MENU ==============");
               Console.WriteLine("1: Coca Cola 150 ml (€ 2.50)");
               Console.WriteLine("2: Insalata di pollo (€ 5.20)");
               Console.WriteLine("3: Pizza Margherita (€ 10.00)");
               Console.WriteLine("4: Pizza 4 Formaggi (€ 12.50)");
               Console.WriteLine("5: Pz patatine fritte (€ 3.50)");
               Console.WriteLine("6: Insalata di riso (€ 8.00)");
               Console.WriteLine("7: Frutta di stagione (€ 5.00)");
               Console.WriteLine("8: Pizza fritta (€ 5.00)");
               Console.WriteLine("9: Piadina vegetariana (€ 6.00)");
               Console.WriteLine("10: Panino Hamburger (€ 7.90)");
               Console.WriteLine("11: Stampa conto finale e conferma");
               Console.WriteLine("==============MENU==============");

           
        }
        
        //uno switch per fare la somma del totale che ritona una stringa che viene inserita in un array nel main
        public string LetUserPick(string choice)
        {
                    
            switch (choice)
            {
                case "1":
                    total += 2.50;
                    return "-Coca Cola 150 ml (€ 2.50)";
                    ;
                case "2":
                    total += 5.20;
                    return "-Insalata di pollo (€ 5.20)";
                    ;
                case "3":
                    total += 10.00;
                    return "-Pizza Margherita (€ 10.00)";
                    ;
                case "4":
                    total += 12.50;
                    return "-Pizza 4 Formaggi (€ 12.50)";
                    ;
                case "5":
                    total += 3.50;
                    return "-Pz patatine fritte (€ 3.50)";
                    ;
                case "6":
                    total += 8.00;
                    return "-Insalata di riso (€ 8.00)";
                    ;
                case "7":
                    total += 5.00;
                    return "-Frutta di stagione (€ 5.00)";
                    ;
                case "8":
                    total += 5.00;
                    return "-Pizza fritta (€ 5.00)";
                    ;
                case "9":
                    total += 6.00;
                    return "-Piadina vegetariana (€ 6.00)";
                    ;
                case "10":
                    total += 7.90;
                    return "-Panino Hamburger (€ 7.90)";
                    ;
                case "11":
                
                    return "Thank you for ordering";
                        ;
                 default: 
                    Console.WriteLine("Not valid, try again");
                    return "";
            }

            
        }

        //per stampare il totale
        public void ShowTotal()
        {
            Console.WriteLine($"Your total is € {total += coperto}");
        }
    }
}
