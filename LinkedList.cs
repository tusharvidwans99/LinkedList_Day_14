using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Day_14
{
    public class LinkedList<T>
    {
        public Node<T> head;
        public Node<T> tail;

        //Adding the data at the previous position of the node
        public void add(T data)
        {
            Node<T> addNode = new Node<T>(data);
            if (head == null)
            {
                head = addNode;
            }
            else
            {
                Node<T> temp = head;
                head = addNode;
                addNode.next = temp;
            }
        }

        //Adding the data at the next position of the node.
        public void append(T data)
        {
            Node<T> appendNode = new Node<T>(data);
            if (head == null)
            {
                head = appendNode;
                tail = appendNode;
            }
            else
            {
                tail.next = appendNode;
                tail = tail.next;
            }
        }


        //Inserting an data in between the nodes
        public void insertBetween(T one, T two, T middle)
        {
            Node<T> newNode = new Node<T>(middle);
            Node<T> temp = head;
            while (temp.next != null)
            {
                if ((temp.data.Equals(one) && temp.next.data.Equals(two)) || (temp.data.Equals(two) && temp.next.data.Equals(one)))
                {
                    Node<T> afterZ = temp.next;
                    temp.next = newNode;
                    temp.next.next = afterZ;
                    break;
                }
                temp = temp.next;
            }
        }

        //Deleting the first element from the linked list
        public void pop()
        {
            Node<T> temp = head;
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                head = temp.next;
            }
        }

        public void show()
        {
            Node<T> temp = head;
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }

        }
    }
}
