using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
	class CleanCar : Car //Ärver från klassen Car
	{

		public CleanCar()
		{
			 passengers = Generator.Next(1, 3);
			//Console.WriteLine("Bilen har " + passengers);
			
			//Console.WriteLine("Bilen har inget stöldgods!");
			
		}
	}
}
