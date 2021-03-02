using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankingSystem
{

	public class IdGenerator
	{
		public int id = 1000;
		int count = 0;

		public IdGenerator()
		{
			id = id + count;
			count+=1;
			return id;
		}
	}
}
