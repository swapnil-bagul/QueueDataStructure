using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Node
    {
        //variables
        public int data;
        public Node next;
        //Constructor
        public Node(int New_Data)
        {
            data = New_Data;
            next = null;
        }
    }
}
