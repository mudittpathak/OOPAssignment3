using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public class SLL : LinkedListADT
	{
		private Node head;
		private int size;

		public SLL()
		{
			head = null;
			size = 0;
		}

		public void Append(object data)
		{
			if (head == null)
			{
				head = new Node(data);
			}
			else
			{
				Node current = head;
				while (current.next != null)
				{
					current = current.next;
				}
				current.next = new Node(data);
			}
			size++;
		}

        public void Clear()
		{
			head = null;
			size = 0;
		}

        public bool Contains(object data)
		{
			return IndexOf(data) != -1;
		}

        public void Delete(int index)
		{
			if (index < 0 || index >= size)
			{
				throw new IndexOutOfRangeException();
			}
			if (index == 0)
			{
				head = head.next;
			}
			else
			{
				Node current = head;
				for (int i = 0; i < index - 1; i++)
				{
					current = current.next;
				}
				current.next = current.next.next;
			}
			size--;
		}

        public int IndexOf(object data)
		{
			Node current = head;
			for (int i = 0; i < size; i++)
			{
				if (current.data.Equals(data))
				{
					return i;
				}
				current = current.next;
			}
			return -1;
		}

        public void Insert(object data, int index)
		{
			if (index < 0 || index > size)
			{
				throw new IndexOutOfRangeException();
			}
			if (index == 0)
			{
				Prepend(data);
			}
			else
			{
				Node current = head;
				for (int i = 0; i < index - 1; i++)
				{
					current = current.next;
				}
				Node newNode = new Node(data);
				newNode.next = current.next;
				current.next = newNode;
				size++;
			}
		}

        public bool IsEmpty()
		{
			return size == 0;
		}

        public void Prepend(object data)
		{
			Node newNode = new Node(data);
			newNode.next = head;
			head = newNode;
			size++;
		}

        public void Replace(object data, int index)
		{
			if (index < 0 || index >= size)
			{
				throw new IndexOutOfRangeException();
			}
			Node current = head;
			for (int i = 0; i < index; i++)
			{
				current = current.next;
			}
			current.data = data;
		}

        public object Retrieve(int index)
		{
			if (index < 0 || index >= size)
			{
				throw new IndexOutOfRangeException();
			}
			Node current = head;
			for (int i = 0; i < index; i++)
			{
				current = current.next;
			}
			return current.data;
		}

        public int Size()
		{
			return size;
		}
    }
}
