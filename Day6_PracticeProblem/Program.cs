namespace Day6_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DataStructure Practice Problems.");
            bool continueExecution = true;
            while (continueExecution)
            {
                Console.WriteLine("Please choose program to perform:");
                Console.WriteLine("1.LinkedList\n");
                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        LinkedList<int> linkedList = new LinkedList<int>();

                        linkedList.AddFirst(77);
                        linkedList.AddLast(11);
                        linkedList.AddLast(54);

                        Console.WriteLine("Linked List:");
                        linkedList.Print();

                        linkedList.Remove(11);

                        Console.WriteLine("Linked List after removing 11:");
                        linkedList.Print();

                        Console.WriteLine("Does the linked list contain 11? " + linkedList.Contains(11));
                        break;
                }
                Console.WriteLine("Do you want to continue.(yes/no)");
                string userInput = Console.ReadLine();
                if (userInput != "yes")
                {
                    continueExecution = false;
                }
            }

            Console.ReadLine();
        }
    }
}
    
