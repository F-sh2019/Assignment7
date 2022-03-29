using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7
{
	class SwapPair
	{

		public Node pairWiseSwap(Linkedlist LL)
		{
			Node node = LL.head;



			
			if (node == null || node.next == null)
			{
				return node;
			}

		
			Node prev = node;
			Node curr = node.next;

			
			node = curr;

		
			while (true)
			{
				Node next = curr.next;

				
				curr.next = prev;

				
				if (next == null || next.next == null)
				{
					prev.next = next;
					break;
				}

			
				prev.next = next.next;

				
				prev = next;
				curr = prev.next;
			}
			return node;
		}



	


	public void main()
	{
		Linkedlist llist = new Linkedlist();


		llist.insert(5);
		llist.insert(4);
		llist.insert(3);
		llist.insert(2);
		llist.insert(1);

		Console.WriteLine("Linked List before calling pairWiseSwap() ");


		llist.PrintList(llist);

		


		Console.WriteLine("Linked List after calling pairWiseSwap() ");
			Node n = pairWiseSwap(llist);

			llist.head = n;
			llist.PrintList(llist);



		}



}

}

