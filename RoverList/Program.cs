using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:  Implement the RoverList class
            RoverList poop = new RoverList();

            // TODO:  Create a RoverList and then fill it with 16 words



            poop.Add("Hey");
            poop.Add("Now");
            poop.Add("You're");//
            poop.Add("An");
            poop.Add("All");
            poop.Add("Star");//
            poop.Add("Get");
            poop.Add("Your");
            poop.Add("Game");//
            poop.Add("On");
            poop.Add("Go");
            poop.Add("Play");//
            poop.Add("I");
            poop.Add("Want");
            poop.Add("To");//
            poop.Add("Die");

            // TODO:  Print out the list
           
            poop.ListNodes();
            Console.WriteLine("-----------------------------------");
            // TODO:  Remove every 3rd word
            for (int i = 2; i < poop.Count; i = i+2)
            {
                
                    poop.RemoveAt(i);
               
            }
            // TODO:  Print out the list
            poop.ListNodes();
            Console.WriteLine("-----------------------------------");

            // TODO:  Print out the list
            poop.ListNodes();
            Console.WriteLine("-----------------------------------");
            // TODO:  Remove every 3rd word
            for (int i = 2; i < poop.Count; i = i + 2)
            {

                poop.RemoveAt(i);

            }
            // TODO:  Print out the list
            poop.ListNodes();
            Console.WriteLine("-----------------------------------");
            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"

            Console.WriteLine("FEED ME WORDS ");
            

            while (true)
            {
                String newNode = Console.ReadLine();

                if (newNode == "done")
                {
                    break;
                }

                poop.Add(newNode);

            }
            // TODO:  Print out the list

            Console.WriteLine("-----------------------------------");
            poop.ListNodes();
            Console.WriteLine("-----------------------------------");
            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            Console.WriteLine("FEED ME MORE WORDS ");
            while (true)
            {
                String newNode = Console.ReadLine();

                if (newNode == "done")
                {
                    break;
                }

                poop.Add(0,newNode);

            }
            // TODO:  Print out the list
            Console.WriteLine("-----------------------------------");
            poop.ListNodes();
            // TODO:  Remove every word with an odd length
            for(int i = 0; i < poop.Count;i++)
            {
                String node = poop.ElementAt(i).Data.ToString();
                if(node.Length % 2 != 0 ||node.Length == 1)
                {
                    poop.RemoveAt(i);
                }
            }

            // TODO:  Print out the list
            Console.WriteLine("-----------------------------------");
            poop.ListNodes();
            // TODO:  Clear the list
            poop.Clear();
            // TODO:  Print out the list
            Console.WriteLine("-----------------------------------");
            poop.ListNodes();
            Console.WriteLine("-----------------------------------");

        }
    }
}
