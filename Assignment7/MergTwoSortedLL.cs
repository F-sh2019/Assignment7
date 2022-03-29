using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7
{
    class MergTwoSortedLL
    {




		
		static Node mergeUtil(Node h1, Node h2)
		{
			// if only one node in first list
			// simply point its head to second list
			if (h1.next == null)
			{
				h1.next = h2;
				return h1;
			}

			// Initialize current and next pointers of
			// both lists
			Node curr1 = h1, next1 = h1.next;
			Node curr2 = h2, next2 = h2.next;

			while (next1 != null && curr2 != null)
			{
				// if curr2 lies in between curr1 and next1
				// then do curr1->curr2->next1
				if ((curr2.value) >= (curr1.value)
					&& (curr2.value) <= (next1.value))
				{
					next2 = curr2.next;
					curr1.next = curr2;
					curr2.next = next1;

					// now let curr1 and curr2 to point
					// to their immediate next pointers
					curr1 = curr2;
					curr2 = next2;
				}
				else
				{
					// if more nodes in first list
					if (next1.next != null)
					{
						next1 = next1.next;
						curr1 = curr1.next;
					}

					// else point the last node of first list
					// to the remaining nodes of second list
					else
					{
						next1.next = curr2;
						return h1;
					}
				}
			}
			return h1;
		}

	
		static Node merge(Node h1, Node h2)
		{
			if (h1 == null)
				return h2;
			if (h2 == null)
				return h1;

			
			if (h1.value < h2.value)
				return mergeUtil(h1, h2);
			else
				return mergeUtil(h2, h1);
		}
		public void printList(Node node)
		{
			while (node != null)
			{
				Console.Write(node.value + " ");
				node = node.next;
			}
		}

		public  void main()
		{
			Node head1 = new Node(10);
			head1.next = new Node(30);
			head1.next.next = new Node(50);

			

			Node head2 = new Node(0);
			head2.next = new Node(20);
			head2.next.next = new Node(40);

			
			Node mergedhead = merge(head1, head2);
			printList(mergedhead);
		}
	}

}

