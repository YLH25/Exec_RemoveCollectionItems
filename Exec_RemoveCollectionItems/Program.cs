using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_RemoveCollectionItems
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int> {1 ,2 ,3,4,5,6,7,8 };
			list.Remove(1);
			list.Remove(2);
		}
	}
}
