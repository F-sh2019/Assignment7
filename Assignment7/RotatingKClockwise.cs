using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7
{
    class RotatingKClockwise
    {
        public void RotatingClockwise(int K ,Linkedlist LL)
        {
            if (K == 0)
                return;
            Node current = LL.head;

            int count = 1;

            while (current != null && count < K)
            {

                current = current.next;
                count++;
            }


            if (current == null)
                return;

            Node KthNode = current;

            while (current.next != null)
            {
                current = current.next;
            
            }

            current.next = LL.head;
            LL.head = KthNode.next;

            
            KthNode.next = null;


            LL.PrintList(LL);



        }



       



        public void main()
        {
            Linkedlist LL = new Linkedlist();

            for (int i = 60; i > 0; i -= 10)
            {
                LL.insert(i);

            }

            LL.PrintList(LL);
            RotatingClockwise(4 ,LL);



        }


    }
}
