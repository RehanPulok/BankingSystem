using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankingSystem
{

	public class IdGenerator
	{
		
		public int IdGenerator()
		{
			int id = 1000;
			id++;
			return id;
		}
	}
}
