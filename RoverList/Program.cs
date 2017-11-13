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
            poop.Add("You're");
            poop.Add("An");
            poop.Add("All");
            poop.Add("Star");
            poop.Add("Get");
            poop.Add("Your");
            poop.Add("Game");
            poop.Add("On");
            poop.Add("Go");
            poop.Add("Play");
            poop.Add("I");
            poop.Add("Want");
            poop.Add("To");
            poop.Add("Die");

            // TODO:  Print out the list
            poop.ListNodes(); 
            // TODO:  Remove every 3rd word
            for(int i = 0; i < poop.Count; i++)
            {
                if(i % 3 == 0)
                {
                    poop.RemoveAt(i);
                }
            }
            // TODO:  Print out the list
            poop.ListNodes();

            // TODO:  Print out the list

            // TODO:  Remove every 3rd word
            for (int i = 0; i < poop.Count; i++)
            {
                if (i % 3 == 0)
                {
                    poop.RemoveAt(i);
                }
            }
            // TODO:  Print out the list
            poop.ListNodes();
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
            poop.ListNodes();
                // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
                // TODO:  Print out the list

                // TODO:  Remove every word with an odd length
                // TODO:  Print out the list

                // TODO:  Clear the list
                // TODO:  Print out the list


        }
    }
}
