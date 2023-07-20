using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
	public class Person
	{
		public string Name { get; set; }
		public static int Count = 0;
		public Person()
		{
			Count++;
		}
	}
}
