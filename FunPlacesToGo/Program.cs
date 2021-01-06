using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FunPlacesToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting();  
        }

        static void Greeting()
        {
            Console.WriteLine("Hello welcome to GC Fun places to go program!\n\nAs your assistant will ask 2 questions!" +
                "\n\nAfter the questions, will then use them for your personalized recomendations!\n\nIf ready then press enter to continue!");
            Console.ReadLine();
            QuestionsLogic();
        }

        static void QuestionsLogic()
        {
            
            Console.WriteLine("What are you in the mood for?\n\nSelect 1 for Action\n\nSelect 2 for Chilling\n\n" +
                "Select 3 for Danger\n\nSelect 4 for Good Food");
            string input = Console.ReadLine();
            int.TryParse(input, out int mood);
            while (!int.TryParse(input, out mood) || mood < 1 || mood > 4)
            {
                Console.WriteLine("Selection is invalid!\n\nOnly numbers 1-4...");
                Console.WriteLine("What are you in the mood for?\n\nSelect 1 for Action\n\nSelect 2 for Chilling\n\n" +
                "Select 3 for Danger\n\nSelect 4 for Good Food");
                input = Console.ReadLine();
                int.TryParse(input, out mood);
            }
    
            Console.WriteLine("How many people are attending?");
            input = Console.ReadLine();
            int.TryParse(input, out int numberofpeople);
            while (!int.TryParse(input, out numberofpeople) || numberofpeople < 0)
            {
                Console.WriteLine("Selection is invalid!\n\nNumbers only...");
                Console.WriteLine();
                Console.WriteLine("How many people are attending?");
                 input = Console.ReadLine();
                int.TryParse(input, out numberofpeople);
            } 
            //Console.WriteLine($"{mood} + {numberofpeople}");

            if (mood == 1 && numberofpeople == 0)
            {
                Console.WriteLine("If you are in the mood for Action, then you should go Stock Car Racing" +
                    " and travel in sneakers.");
            }
            else if (mood == 1 && 0 < numberofpeople && numberofpeople < 5)
            {
                Console.WriteLine("If you are in the mood for Action, then you should go Stock Car Racing" +
                    " and travel in a sedan.");
            }
            else if (mood == 1 && numberofpeople > 4 && numberofpeople < 11 )
            {
                Console.WriteLine("If you are in the mood for Action, then you should go Stock Car Racing" +
                    " and travel in a Volkswagen bus.");
            }
             else if (mood == 1 && numberofpeople > 10)
            {
                Console.WriteLine("If you are in the mood for Action, then you should go Stock Car Racing" +
                    " and travel on an airplane.");
            }
            else if (mood == 2 && numberofpeople == 0)
            {
                Console.WriteLine("If you are in the mood for Chillin, then you should go Hiking" +
                    " and travel in sneakers.");
            }
            else if (mood == 2 && 0 < numberofpeople && numberofpeople < 5)
            {
                Console.WriteLine("If you are in the mood for Chillin, then you should go Hiking" +
                    " and travel in a sedan.");
            }
            else if (mood == 2 && numberofpeople > 4 && numberofpeople < 11)
            {
                Console.WriteLine("If you are in the mood for Chillin, then you should go Hiking" +
                    " and travel in a Volkswagen bus.");
            }
            else if (mood == 2 && numberofpeople > 10)
            {
                Console.WriteLine("If you are in the mood for Chillin, then you should go Hiking" +
                    " and travel on an airplane.");
            }
            else if (mood == 3 && numberofpeople == 0)
            {
                Console.WriteLine("If you are in the mood for Danger, then you should go Sky Diving" +
                    " and travel in sneakers.");
            }
            else if (mood == 3 && 0 < numberofpeople && numberofpeople < 5)
            {
                Console.WriteLine("If you are in the mood for Danger, then you should go Sky Diving" +
                    " and travel in a sedan.");
            }
            else if (mood == 3 && numberofpeople > 4 && numberofpeople < 11)
            {
                Console.WriteLine("If you are in the mood for Danger, then you should go Sky Diving" +
                    " and travel in a Volkswagen bus.");
            }
            else if (mood == 3 && numberofpeople > 10)
            {
                Console.WriteLine("If you are in the mood for Danger, then you should go Sky Diving" +
                    " and travel on an airplane.");
            }
            else if (mood == 4 && numberofpeople == 0)
            {
                Console.WriteLine("If you are in the mood for Good Food, then you should go to Outback Steakhouse" +
                    " and travel in sneakers.");
            }
            else if (mood == 4 && 0 < numberofpeople && numberofpeople < 5)
            {
                Console.WriteLine("If you are in the mood for Good Food, then you should go Outback Steakhouse" +
                    " and travel in a sedan.");
            }
            else if (mood == 4 && numberofpeople > 4 && numberofpeople < 11)
            {
                Console.WriteLine("If you are in the mood for Good Food, then you should go Outback Steakhouse" +
                    " and travel in a Volkswagen bus.");
            }
            else
            {
                Console.WriteLine("If you are in the mood for Good Food, then you should go Outback Steakhouse" +
                    " and travel on an airplane.");
            }
            //continueProgram();
            ExitProgram();
        }
        static void continueProgram()
        {
            Console.WriteLine("Do you want to try again for alternative suggessions?");
            string input = Console.ReadLine();
            while (input.ToLower() != "y" || input.ToLower() != "n")
            {
                Console.WriteLine("Invalid input, Y for yes and N for no...");
                Console.WriteLine("Do you want to try again for alternative suggessions?");
                input = Console.ReadLine();
            }
            if (input.ToLower() == "y")
            {
                Greeting();
            }
            ExitProgram();
        }

        static void ExitProgram()
        {
            Console.WriteLine("\n\nThank you for using the recommendation platform...\n\nGoodbye!!\n\nPress Enter to Exit Program...");
            Console.ReadLine();
        }
    }
}
