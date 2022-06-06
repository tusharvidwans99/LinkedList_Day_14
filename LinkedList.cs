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
    }
}
