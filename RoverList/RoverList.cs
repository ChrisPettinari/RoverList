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
            for(int i = 0; i < 16; i++)
            {
                if(i == Position)
                {
                    data = next;
                }
                next = next.Next;
            }

        }

        public override void Clear()
        {
            Node next = head;
            next = null;

            while (next.Next != null)
            {
                next.Next = null;
            }
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
            Node next = head;

            for(int i = 0; i < Position; i++)
            {
                if (i == Position && next != null)
                {
                    next = null;
                    return true;
                }
                next = next.Next;
            }
            return false;
        }
    }
}
