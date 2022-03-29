using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7
{
    class AddTwoLists
    {

        public void AddTwoList(Node First, Node Second)
        {


            Node Result = null;
            int Carry = 0;
            Node Temp = null;
            Node Prev = null;
            while (First != null || Second != null)
            {

                int sum = Carry + (First == null ? 0 : First.value) + (Second == null ? 0 : Second.value);
                Carry = (sum > 9) ? 1 : 0;
                sum = sum % 10;
                Temp = new Node(sum);
                if (Result == null)
                {
                    Result = Temp;

                }
                else
                {
                    Prev.next = Temp;
                }


                Prev = Temp;
                if (First != null) First = First.next;
                if (Second != null) Second = Second.next;
            }
            if (Carry==1){
                Temp.next=new Node(Carry);
                }

            Linkedlist s = new Linkedlist();
            s.head=Result;
            s.PrintList(s);
        }



        public void main()
        { Linkedlist ll1 = new Linkedlist() ;
            
            ll1.insert(5);
            ll1.insert(9);
            ll1.insert(3);
            //ll1.head=
            ll1.PrintList(ll1);

            Linkedlist ll2 = new Linkedlist();
            ll2.insert(3);
            ll2.insert(8);
            ll1.PrintList(ll2);

            AddTwoList(ll1.head, ll2.head);



        }
    }
}
