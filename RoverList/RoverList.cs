﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class RoverList : RoverListBase
    {
        // Add any variables you need here
        
        public RoverList ()
        {

        }

        public override int Count => throw new NotImplementedException();

        public override void Add(object data)
        {
            throw new NotImplementedException();
        }

        public override void Add(int Position, object data)
        {
            Node next = head;
            while (next != null)
            {
                Console.WriteLine(next.Data);
                next = next.Next;
            }

        }

        public override void Clear()
        {
            throw new NotImplementedException();
        }

        public override Node ElementAt(int Position)
        {
            
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
