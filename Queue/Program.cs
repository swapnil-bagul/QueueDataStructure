using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Object 
            QueueFunction  queueFunction = new QueueFunction();
            //Call Methode
            queueFunction.Enqueue(50);
            queueFunction.Enqueue(30);
            queueFunction.Enqueue(70);
            Console.WriteLine("The Queue list is :");
            queueFunction.Display();
        }
    }
}
