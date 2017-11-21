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
            Node prev = null;


            for(int i = 0; i < count; i++)
            {
                if (i == Position)
                {
                    Node node = new Node(data);
                    node.Next = next;

                    if (prev != null)
                        prev.Next = node;
                    else
                        head = node;

                    count++;
                }

                prev = next;
                if (next.Next != null)
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
            if (node == null) { node = node.Next; }

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
         
            //its korean i swear

            for(int i = 0; i < Position  -1; i++)
            {
                if (next.Next != null)
                    next = next.Next;
            }

            if (next.Next.Next != null)
                next.Next = next.Next.Next; 
            
            count--;
            return false;
        }
    }
}
