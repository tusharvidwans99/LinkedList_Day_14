namespace LinkedList_Day_14
{
    /// <summary>
    /// In this program we are going to do operations on LinkedList.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this program in which we are doing operations on LinkedList");

            //create Linked List by adding 30 and 56 to 70
            LinkedList<int> linkedList = new LinkedList<int>();         
            linkedList.add(70);
            linkedList.add(30);
            linkedList.add(56);

            Console.WriteLine("Linked List1");
            linkedList.show();

            //create Linked List by appending 30 and 56 to 70
            LinkedList<int> linkedList2 = new LinkedList<int>();

            linkedList2.append(56);
            linkedList2.append(30);
            linkedList2.append(70);

            Console.WriteLine("Linked List2");
            linkedList2.show();


            //Inserting data in between 30&56
            Console.WriteLine("Linked List1");
            linkedList.insertBetween(30, 56, 30);
            linkedList.show();

            //Deleting the first element from linkedlist i.e 56
            linkedList.pop();
            Console.WriteLine("Linked List1");
            linkedList.show();


            //Deleting the last element from linkedlist2 70
            linkedList2.popLast();
            Console.WriteLine("Linked List2");
            linkedList2.show();

            //finding the node of value 30 in linkedlist2, will return true if finds the node or false if not present.
            Console.WriteLine(linkedList2.search(30));

            //Inserting data after 30 in linkedlist2
            linkedList2.insertAfter(30, 40);
            Console.WriteLine("Linked List2");
            linkedList2.show();


            //deleting the specific node from linkedlist2.
            linkedList2.deleteNode(30);
            Console.WriteLine("Linked List2");
            linkedList2.show();
        }
    }
}