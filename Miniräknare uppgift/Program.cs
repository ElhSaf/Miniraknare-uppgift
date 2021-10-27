using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniräknare_uppgift
{
    class Program
    {
        static void MainMenu()     // skapar jag MainMenu metoden för menyn 
        {
            Console.Clear();
            Console.WriteLine("Välkommen till miniräknaren"); // dom olika valen som finns i menyn...
            Console.WriteLine("[1] Göra uträkning ");
            Console.WriteLine("[2] Visa gamla uträkningar");
            
            Console.WriteLine("[5]Avsluta");





        }
        static void Main(string[] args)
        {
            double  num1;
            double  num2;
            char signe;
            double  result;
        
            List<string> history = new List<string>();
            
              
           



            bool displayMenu = true;

            while (displayMenu)
            {
                MainMenu();

                int menuChoice = Convert.ToInt32(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:

                        Console.WriteLine("ange tal1: ");
                       num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ange tal2: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("skriv in operator: ");
                        signe = Convert.ToChar(Console.ReadLine());

                        

                        if (signe == '+')
                        {
                            result = num1 + num2;

                            Console.WriteLine("{0} + {1} = {2}", num1,num2,result );
                            history.Add(string.Format("{0} + {1} = {2}", num1, num2, result));
                           
                        }
                       else  if (signe == '-')
                        {
                            result = num1 - num2;

                            Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
                            history.Add(string.Format("{0} - {1} = {2}", num1, num2, result));
                        }
                        else if (signe == '*')
                        {
                            result = num1 * num2;

                            Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
                            history.Add(string.Format("{0} * {1} = {2}", num1, num2, result));
                        }
                        else
                        {
                            result = num1 / num2;

                            Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
                            history.Add(string.Format("{0} / {1} = {2}", num1, num2, result));


                        }
                        Console.ReadKey();
                        break;
                    
                    case 2:

                        foreach (string count in history)
                        {
                            Console.WriteLine("Dina tidigare uträkningara: {0} ", count );
                            
                        }
                        Console.ReadKey();

                        break;

                    default:
                        displayMenu = false;
                        break;

                        









                      




                }
            }
            
        }
    }
}
