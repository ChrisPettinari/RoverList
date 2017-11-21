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
            poop.Add("An");//2
            poop.Add("All");
            poop.Add("Star");//
            poop.Add("Get");//2
            poop.Add("Your");
            poop.Add("Game");//
            poop.Add("On");//2
            poop.Add("Go");
            poop.Add("Play");//
            poop.Add("I");//2
            poop.Add("Want");
            poop.Add("To");//
            poop.Add("Die");//2

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
                object newStuff = Console.ReadLine();

                if (newStuff.ToString() == "done")
                {
                    break;
                }

                poop.Add(0,newStuff);

            }
            // TODO:  Print out the list
            Console.WriteLine("-----------------------------------");
            poop.ListNodes();
            // TODO:  Remove every word with an odd length
            for (int i = 0; i < poop.Count;i++)
            {
                if (poop.ElementAt(i).Data.ToString().Length % 2 != 0|| poop.ElementAt(i).Data.ToString().Length == 1)
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
