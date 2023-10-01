using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7
{
    class PalindromicLL
    {
        /* C# program to check if linked list is palindrome */

		
		Node slow_ptr, fast_ptr, second_half;

		

		
		Boolean isPalindrome(Node head)
		{
			slow_ptr = head;
			fast_ptr = head;
			Node prev_of_slow_ptr = head;
			Node midnode = null; 
			Boolean res = true; 

			if (head != null && head.next != null)
			{
				
				while (fast_ptr != null && fast_ptr.next != null)
				{
					fast_ptr = fast_ptr.next.next;

					
					prev_of_slow_ptr = slow_ptr;
					slow_ptr = slow_ptr.next;
				}

				
				if (fast_ptr != null)
				{
					midnode = slow_ptr;
					slow_ptr = slow_ptr.next;
				}

				
				second_half = slow_ptr;
				prev_of_slow_ptr.next = null; 
				reverse(); 
				res = compareLists(head, second_half);

				
				reverse(); 

				if (midnode != null)
				{
					
					prev_of_slow_ptr.next = midnode;
					midnode.next = second_half;
				}
				else
					prev_of_slow_ptr.next = second_half;
			}
			return res;

			
		}

		void reverse()
		{
			Node prev = null;
			Node current = second_half;
			Node next;
			while (current != null)
			{
				next = current.next;
				current.next = prev;
				prev = current;
				current = next;
			}
			second_half = prev;
		}

		
		Boolean compareLists(Node head1, Node head2)
		{
			Node temp1 = head1;
			Node temp2 = head2;

			while (temp1 != null && temp2 != null)
			{
				if (temp1.value == temp2.value)
				{
					temp1 = temp1.next;
					temp2 = temp2.next;
				}
				else
					return false;
			}

		
			if (temp1 == null && temp2 == null)
				return true;

		
			return false;
		}
		
		public  void main()
		{

			




			/* Start with the empty list */
			Linkedlist llist = new Linkedlist();

			char[] str = { 'a', 'b', 'a', 'c', 'a', 'b', 'a' };

			for (int i = 0; i < 7; i++)
			{
				llist.insert(str[i]);
				llist.PrintList(llist);
				if (isPalindrome(llist.head) != false)
				{
					Console.WriteLine("Is Palindrome");
					Console.WriteLine("");
				}
				else
				{
					Console.WriteLine("Not Palindrome");
					Console.WriteLine("");
				}
			}
		}
	}
	

}
