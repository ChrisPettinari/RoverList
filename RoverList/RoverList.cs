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


            for(int i = 0; i < count; i++)
            {
                if (i == Position)
                {
                    next = new Node(data);
                    count++;
                }
                next = next.Next;
            }
        }

        public override void Clear()
        {
            
            while (true)
            {
                if( head == null)
                {
                    break;
                }
                else
                {
                   head = null;
                }
              
            }
            count = 0;
        }

        public override Node ElementAt(int Position)
        {
            Node next = head;
            for(int i = 0 ; i < count; i++)
            {
                if(i == Position && next != null)
                {
                    return next;
                }
                
            }

            return null;



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
            Node next;
            if (head == null)
            {
                return true;
            }
            else
            {
                next = head;
            }
         
            if(Position< 0 || Position >= count)
            {
                throw new IndexOutOfRangeException();
            }

            for(int i = 0; i < Position  -1; i++)
            {
                next = next.Next;
            }

            next.Next = next.Next.Next;
            
            count--;
            return false;
        }
    }
}
