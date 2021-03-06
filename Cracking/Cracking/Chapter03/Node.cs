﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking.Chapter03
{
    public class ElementOutOfBoundsException : Exception
    {

    }

    public class Node
    {
        public int value { get; set; }
        public int times { get; set; }
        public Node next { get; set; }

        public Node()
        {

        }

        public Node(int value)
        {
            this.value = value;
            times = 1;
        }

        public void PrintTail()
        {
            Node ptr = this;
            while (ptr != null)
            {
                System.Diagnostics.Debug.Write(String.Format(" {0} ", ptr.value));
                ptr = ptr.next;
            }
            System.Diagnostics.Debug.WriteLine("");
        }
    }
}
