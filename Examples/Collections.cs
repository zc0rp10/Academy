using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of T
            var names = new List<string>();
            names.add = "Bo";
            names.add = "Li";
            names.add = "An";

            //names[names.Count - 1] = "Bo";

            foreach (var item in names)
            {
                System.Console.WriteLine(item);
            }

            //Queue
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            System.Console.WriteLine(queue.Dequeue()); //Prints out the item that's been in the queue the longest. Ex, 1,2,3

            foreach (var item in queue)
            {
                System.Console.WriteLine(item);
            }

            //Stack
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            System.Console.WriteLine(stack.Pop()); //Prints out the item that was added in the queue last. Ex, 3,2,1

            //Dictionaries
            var people = new Dictionary<string, int>();
            people.Add("Bo", 30);
            people.Add("An", 40);

            System.Console.WriteLine(people["Bo"]); //Prints out the value connected with the given key. Ex, 30
        }
    }
}