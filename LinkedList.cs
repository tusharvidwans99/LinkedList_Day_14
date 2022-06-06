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


        //Deleting Last element from the linkedlist
        public void popLast()
        {
            Node<T> temp = head;
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                while (temp.next != tail)
                {
                    temp = temp.next;
                }
                temp.next = null;
                tail = temp;
            }
        }

        //This method will find the node using value.
        public bool search(T data)
        {
            Node<T> temp = head;
            bool isPresent = false;
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return false;
            }
            else
            {
                while (temp != null)
                {
                    if (temp.data.Equals(data))
                    {
                        isPresent = true;
                        break;
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }
            }
            return isPresent;
        }

        //This method will insert the data after specific node.
        public void insertAfter(T insertAfter, T insertData)
        {
            Node<T> temp = head;
            Node<T> insertNode = new Node<T>(insertData);
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            else
            {
                while (temp != null)
                {
                    if (temp.data.Equals(insertAfter))
                    {
                        Node<T> node = temp.next;
                        temp.next = insertNode;
                        insertNode.next = node;
                        temp = node;
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }
            }
        }


        //Printing the values in the linked list
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
