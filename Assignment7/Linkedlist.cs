using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7
{
    class Linkedlist
    {
        public Node head ;

        public void insert(int new_data)
        {
            Node new_node = new Node(new_data);

            new_node.next = head;
            head = new_node;


        }

        public void PrintList(Linkedlist ll)
        {
            Node n1 =  ll.head;

            while (n1 != null)
            {
                Console.Write(n1.value + "->");
                n1 = n1.next;
            }
            Console.WriteLine("NULL");

        }


    }
}
