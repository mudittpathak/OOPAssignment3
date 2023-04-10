using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_3_skeleton
{
	public class Node
	{
		public Object data;
		public Node next;

		public Node(Object data)
		{
			this.data = data;
			this.next = null;
		}
	}
}
