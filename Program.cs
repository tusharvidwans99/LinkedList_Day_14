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

            linkedList.show();

            //create Linked List by appending 30 and 56 to 70
            LinkedList<int> linkedList2 = new LinkedList<int>();

            linkedList2.append(56);
            linkedList2.append(30);
            linkedList2.append(70);

            linkedList2.show();


            //Inserting data in between 30&56
            linkedList.insertBetween(30, 56, 30);
            linkedList.show();

            //Deleting the first element from linkedlist i.e 56
            linkedList.pop();
            linkedList.show();


            //Deleting the last element from linkedlist2 70
            linkedList2.popLast();
            linkedList2.show();
        }
    }
}