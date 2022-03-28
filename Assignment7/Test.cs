using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7
{
    public class Test
    {



		public Node reverse(Node head, int k)
		{
			if (head == null)
				return null;
			
			Node current = head;
			Node next = null;
			Node prev = null;

			int count = 0;

			/* Reverse first k nodes of linked list */
			while (count < k && current != null)
			{
				next = current.next;
				current.next = prev;
				prev = current;
				current = next;
				count++;
			}

			/* next is now a pointer to (k+1)th node
				Recursively call for the list starting from
			current. And make rest of the list as next of
			first node */
			if (next != null)
				head.next = reverse(next, k);

			// prev is now head of input list
			return prev;
		}

		/* Utility functions */

		/* Inserts a new Node at front of the list. */


		/* Driver code*/
		public void main()
		{
			Linkedlist llist = new Linkedlist();

			/* Constructed Linked List is 1->2->3->4->5->6->
			7->8->8->9->null */
			//llist.insert(9);
			//llist.insert(8);
			//llist.insert(7);
			//llist.insert(6);
			//llist.insert(5);
			//llist.insert(4);
			//llist.insert(3);
			//llist.insert(2);
			//llist.insert(1);
			for (int i = 3; i > 0; i--)
			{
				llist.insert(i);

			}
			Console.WriteLine("Given Linked List");
			llist.PrintList(llist);

			llist.head = reverse(llist.head, 2);

			Console.WriteLine("Reversed list");
			llist.PrintList(llist);


		}

		}
}
