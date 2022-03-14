using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7
{
    class FindingLLMiddle
    {

        public void FindingMiddle(Linkedlist LL)
        {


            Node FP  = LL.head;
            Node SP =  LL.head;
            if (LL.head != null)
            {
                while ( FP != null && FP.next != null)
                {

                    FP = FP.next.next;
                    SP = SP.next;
                
                }

                Console.WriteLine("The middle Element is" + SP.value);
            
            
            
            }





        
        }

        public void main()
        {
            Linkedlist ll = new Linkedlist();


            for (int i = 5; i > 0; i--)
            {
                ll.insert(i);
                ll.PrintList(ll);                 
                FindingMiddle(ll);
            }
           




        }
    }
}
