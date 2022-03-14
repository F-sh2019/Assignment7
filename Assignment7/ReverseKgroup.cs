using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7
{
    class ReverseKgroup
    {
        public Linkedlist ReverseKGroup(Linkedlist LL, int k)
        {

            Node n = LL.head;
            int step = 1;
            Node CurrentNode = LL.head;
            Node FirstNode = LL.head;
            Node Nextnode = LL.head;
            Node Prev = null;
           
            int i = 0;
            while (CurrentNode.next != null)
            {
                while (step != k && CurrentNode.next != null)
                {
                    if (step == 1) FirstNode = CurrentNode;

                    
                    Nextnode = CurrentNode.next;
                   
                    CurrentNode.next = Prev;
                   
                    Prev = CurrentNode;

                    CurrentNode = Nextnode;
                   
                    step++;

                }




                step = 1;
                FirstNode.next = CurrentNode.next;
                FirstNode = CurrentNode;
                if (i == 0) LL.head = FirstNode;
                i++;
                LL.PrintList(LL);

            }

            return LL;
        }

        public void main()
        {
            Linkedlist LL = new Linkedlist();

            for (int i = 3; i > 0; i --)
            {
                LL.insert(i);

            }

            LL.PrintList(LL);
            ReverseKGroup(LL, 3);
            LL.PrintList(LL);
            //RotatingClockwise(4, LL);
        }
    }
}
