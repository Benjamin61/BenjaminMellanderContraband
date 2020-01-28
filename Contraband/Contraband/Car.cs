using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
	class Car
	{
		protected bool isContraband = false; //En bool som används för att undersöka om bilen är en contraband eller inte
		public int passengers = 0;
		public int contrabandAmount = 0;
		 protected static Random Generator = new Random(); //Random generator

		public bool examine()
		{
			contrabandAmount = Generator.Next(0, 4);
			if (contrabandAmount >= 1)
			{
				isContraband = true; //Gör om boolen till true så att vi vet att det blev en contraband car
			}
			return isContraband;
		}

	}
}
