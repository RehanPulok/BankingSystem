using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankingSystem
{

	public class IdGenerator
	{
		private int id = 1000;
		

		public static int IdGenerator()
		{
			id++;
			return id;
		}
	}
}
