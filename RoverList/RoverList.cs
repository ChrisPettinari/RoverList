using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class RoverList : RoverListBase
    {
        // Add any variables you need here
        int c = 0;
        public RoverList ()
        {

        }

        public override int Count
        {

            get
            {
                return c;

            }
        }


        public override void Add(object data)
        {
          
        }

        public override void Add(int Position, object data)
        {
            Node next = head;
            int i = 0; 
            while (next != null)
            {
                Console.WriteLine(next.Data);
                if (i == Position)
                {
                    data = next;
                }
                next = next.Next;

                i++;
            }

        }

        public override void Clear()
        {
            throw new NotImplementedException();
        }

        public override Node ElementAt(int Position)
        {
            throw new NotImplementedException(); 
        }

        public override void ListNodes()
        {
            throw new NotImplementedException();
        }

        public override bool RemoveAt(int Position)
        {
            throw new NotImplementedException();
        }
    }
}
