using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7
{
	class FindingLoopinLL
	{




		public Boolean detectLoop(Linkedlist LL)
		{
			Node slow_p = LL.head, fast_p = LL.head;
			while (slow_p != null && fast_p != null
				&& fast_p.next != null)
			{
				slow_p = slow_p.next;
				fast_p = fast_p.next.next;
				if (slow_p == fast_p)
				{
					return true;
				}
			}
			return false;
		}

		/* Driver code */
		public void main()
		{
			Linkedlist llist = new Linkedlist();

			llist.insert(12);
			llist.insert(3);
			llist.insert(22);
			llist.insert(9);
			/*Create loop for testing */
			llist.head.next.next.next.next = llist.head;

			detectLoop(llist);
			if (detectLoop(llist))
			{
				Console.WriteLine("Loop Found");
			}
			else
			{
				Console.WriteLine("No Loop");
			}
		}
	}
}
	



