using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
	class ContrabandCar : Car //Ärver från klassen Car
	{
		public ContrabandCar()
		{
			passengers = Generator.Next(1, 4); //Genererar hur många passengers
			

		}
	}
}
