using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7
{
    class Flattering
    {
    
    
public class List
	{
		Node head; 

		
		public	class Node
		{
			public 	int data;
			public 	Node next, botton;

			public 	Node(int data)
			{
				this.data = data;
				next = null;
				botton = null;
			}
		}

		
		Node merge(Node a, Node b)
		{
			
			if (a == null)
				return b;

			
			if (b == null)
				return a;

		
			Node result;

			if (a.data < b.data)
			{
				result = a;
				result.botton = merge(a.botton, b);
			}

			else
			{
				result = b;
				result.botton = merge(a, b.botton);
			}

			result.next = null;
			return result;
		}

		Node flatten(Node root)
		{
		
			if (root == null || root.next == null)
				return root;

			
			root.next = flatten(root.next);

		
			root = merge(root, root.next);

			
			return root;
		}

		
		Node Push(Node head_ref, int data)
		{
			
			Node new_node = new Node(data);

			
			new_node.botton = head_ref;

			
			head_ref = new_node;

			
			return head_ref;
		}

		void printList()
		{
			Node temp = head;
			while (temp != null)
			{
				Console.Write(temp.data + " ");
				temp = temp.botton;
			}
			Console.WriteLine();
		}

		
		public void main()
		{
			List L = new List();

			
		
			L.head = L.Push(L.head, 7);
			L.head = L.Push(L.head, 5);

			L.head.next = L.Push(L.head.next, 20);
			L.head.next = L.Push(L.head.next, 10);

			L.head.next.next = L.Push(L.head.next.next, 50);
			L.head.next.next = L.Push(L.head.next.next, 22);
			

			

			
			L.head = L.flatten(L.head);

			L.printList();
		}
	}


}

}

