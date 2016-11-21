using System;
// No additional "using" statements may be added.
// Adding references as "System.Collections.Hashtable myHashtable = ..." are also disallowed.
// No use of Array.sort() or Array.resize(), or any built-in or API methods that provide this functionality.
// This is to see your problem solving skills, not your knowledge of the API.


// To start, create a new C# Console Application project.
// Cut and paste the contents of the file into the default project Program.cs file.
// Completely replace the existing contents of that file.

// When complete, return the resultant Program.cs from your new project folder.


namespace PriorityQueue
{
    class Program
    {

        //A PriorityQueue is a FIFO queue/buffer that supports the additional idea of "priority".
        //Items of highest priority are returned first.
        //Items of same priority are returned FIFO.
        public interface PriorityQueue
        {
            //Add a task to the Queue.
            //priority will always be provided as a non-negative integer (zero is valid)
            //zero (0) is the lowest priority, max priority is only limited by the integer type.
            void addTask(String taskDescription, int priority);

            //Return the "next" task based on the rules above and remove it from the queue.
            //If the Queue is empty, return null.
            String nextTask();
        }

        /************************************************************************************
        *     Implement your version of the PriorityQueue interface below as "myQueue".     * 
        *************************************************************************************/
        //Note:  Inner classes are allowed.
        //Note:  Queues should be able to hold an unlimited number of elements (consistent with available memory).
        //Note:  Concentrate on creating a clean, easy to follow solution, using standard langauge features and OO design.


        // *******  Your class called "myQueue" goes here. *******


        /************************************************************************
        *     Implement your version of the PriorityQueue interface above.      * 
        *************************************************************************/


        static void Main(string[] args)
        {
            PriorityQueue pq = null;

            //Implement the interface above so that "myQueue" is valid.
            pq = new myQueue();

            // Sample test data/code
            pq.addTask("first", 1);
            pq.addTask("second", 1);
            pq.addTask("third", 3);
            pq.addTask("fourth", 1);
            Console.WriteLine("GetNext(): " + pq.nextTask());
            Console.WriteLine("GetNext(): " + pq.nextTask());
            pq.addTask("fifth", 1);
            pq.addTask("sixth", 5);
            Console.WriteLine("GetNext(): " + pq.nextTask());
            Console.WriteLine("GetNext(): " + pq.nextTask());
            Console.WriteLine("GetNext(): " + pq.nextTask());
            Console.WriteLine("GetNext(): " + pq.nextTask());
            Console.WriteLine("GetNext(): " + pq.nextTask());
            pq.addTask("seventh", 1);
            pq.addTask("eighth", 2);
            pq.addTask("ninth", 2);
            pq.addTask("tenth", 3);
            Console.WriteLine("GetNext(): " + pq.nextTask());
            Console.WriteLine("GetNext(): " + pq.nextTask());
            Console.WriteLine("GetNext(): " + pq.nextTask());
            Console.WriteLine("GetNext(): " + pq.nextTask());
            Console.ReadLine();

            The output for the above should be; 
            GetNext(): third;
            GetNext(): first;
            GetNext(): sixth;
            GetNext(): second;
            GetNext(): fourth
            GetNext(): fifth;
            GetNext(): tenth;
            GetNext(): eight;
            GetNext(): ninth;
            GetNext(): seventh

            //Note:  A different set of test data will be used for testing than is provided above. This needs to be an all purpose solution.

        }

    }

}