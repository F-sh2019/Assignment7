using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7
{
    class FindNthfromend
    {
      
		/* Function to get the nth node from end of list */
		void printNthFromLast(Linkedlist LL,int n)
		{
			Node main_ptr = LL.head;
			Node ref_ptr = LL.head;

			int count = 0;
			if (LL.head != null)
			{
				while (count < n)
				{
					if (ref_ptr == null)
					{
						Console.WriteLine(n + " is greater than the no "
											+ " of nodes in the list");
						return;
					}
					ref_ptr = ref_ptr.next;
					count++;
				}

				if (ref_ptr == null)
				{
					LL.head = LL.head.next;
					if (LL.head != null)
						Console.WriteLine("Node no. " +
											n + " from last is " +
											main_ptr.value);
				}
				else
				{
					while (ref_ptr != null)
					{
						main_ptr = main_ptr.next;
						ref_ptr = ref_ptr.next;
					}
					Console.WriteLine("Node no. " +
									n + " from last is " +
									main_ptr.value);
				}
			}
		}

		

		
		public  void main()
		{
			Linkedlist llist = new Linkedlist();
			llist.insert(20);
			llist.insert(4);
			llist.insert(15);
			llist.insert(35);

			printNthFromLast(llist,4);
		}
	}



}

