using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class QueueFunction
    {
         public Node head;

        // Added Element In Queue
        public void Enqueue(int data)
        {
            Node new_node = new Node(data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = new_node;
            }
            Console.WriteLine("value is inserted " + new_node.data);
        }

        //Dequeue Element of Queue 
        public void Dequeue()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("No Element Present ");
            }
            this.head = temp.next;
            temp = null;

        }


        //Display Queue Element
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("queue is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine("" + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
