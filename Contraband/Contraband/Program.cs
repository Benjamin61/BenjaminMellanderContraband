using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
	class Program
	{
		static void Main(string[] args)
		{
			Random MainGenerator = new Random();
			List<ContrabandCar> contraband = new List<ContrabandCar>(); //Gör en tom lista där alla ContrabandCars kommer att lagras
			List<CleanCar> Clean = new List<CleanCar>(); //Tom lista där clean cars kommer att lagras
			List<Car> Cars = new List<Car>(); //Gör en lista där alla instanser av bilarna lagras

			int answer = 0; //Gör 1 int där spelarens parsade input lagras
			bool success = false;
			while (success == false)
			{
				Console.Write("Hur många bilar ska skapas? ");
				string inputNum = Console.ReadLine(); //spelares input laras

				success = int.TryParse(inputNum, out answer); //Försöker göra om spelares input till 1 int

				if (success && answer < 1) //Om parsen lyckas och svaret är under 1 så får man skriva in svaret igen
				{
					Console.WriteLine("Försök igen");
					success = false;
				}
			}

			for (int i = 0; i < answer; i++) //Skapar x antal bilar beroende på hur många man valde att generera
			{
				Car Car = new Car(); //Ny instans
				Cars.Add(Car); //Lägger till Car i listen Cars

				
				
			}
			Console.WriteLine("Genererade bilar: " + Cars.Count); //Räknar storleken på cars
			Console.WriteLine("Klicka enter för att få veta hur många av repsketive sort som genererades");
			Console.ReadKey();
			int CleanAmount = MainGenerator.Next(0, answer); //Randomizar antalet clean amount. Nånting mellan 0 och spelarens input
			
			
			
			for (int i = 0; i < CleanAmount; i++)  //Skapar x antal bilar beroende på hur många man valde att generera
			{
				CleanCar CleanCars = new CleanCar();
				Clean.Add(CleanCars); //Lägger till en CleanCar i listan över CleanCars
			}
			Console.WriteLine("Genererade " + Clean.Count + " Clean bilar"); //Skriver ut hur många clean cars som lades till i den nya listen
			int contrabandAmount = answer - CleanAmount; //Gör en ny int för contraband cars som är totala - antalet clean

			for (int i = 0; i < contrabandAmount; i++)
			{
				ContrabandCar contrabandCars = new ContrabandCar(); //Ny ContrabandCar för varje värde som i är mindre än inten contrabandAmont
				contraband.Add(contrabandCars); //Lägger till contraband cars i listan 
			}
			Console.WriteLine("Genererade " + contraband.Count + " Contraband bilar");
			
			Console.ReadLine();
			
		}
	}
}
