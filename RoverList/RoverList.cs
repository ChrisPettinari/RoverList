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
        private int count = 0;
        public RoverList ()
        {

        }

        public override int Count
        {

            get
            {
                return count;

            }
        }


        public override void Add(object data)
        {
            if( head == null)
            {
                head = new Node(data);
                current = head;
            }
            else
            {
                current.Next = new Node(data);
                current = current.Next;
            }
            count++;
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
            
        }

        public override Node ElementAt(int Position)
        {
            throw new NotImplementedException(); 
        }

        public override void ListNodes()
        {
            Node node = head;
            while (node != null)
            {
                Console.WriteLine(node.Data + " ");
                node = node.Next;
            }
        }

        public override bool RemoveAt(int Position)
        {
            count--;
            throw new NotImplementedException();
        }
    }
}
