using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7
{
    class ReverseKgroup
    {
        public Node ReverseKGroup(Node head, int k)
        {

            if (head == null)
                return null;
            int Count = 0;
            Node Current = head;

            Node Next = null;
            Node Prev = null;

         

            while (Count < k && Current != null)
            {


                Next = Current.next;

                Current.next = Prev;

                Prev = Current;

                Current = Next;

                Count++;

            }

            if (Next != null)
                head.next = ReverseKGroup(Next, k);

            return Prev;

        }

        public void main()
        {
            Linkedlist LL = new Linkedlist();

            for (int i = 9; i > 0; i --)
            {
                LL.insert(i);

            }

            LL.PrintList(LL);
            LL.head=ReverseKGroup(LL.head, 3);
            LL.PrintList(LL);
            //RotatingClockwise(4, LL);
        }
    }
}
