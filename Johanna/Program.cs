using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Johanna {
	class Program {
		static void Main(string[] args) {
			bool valueFound = false;

			Random rand = new Random();
			int hiddenValue = rand.Next(0, 100);
			
			int count = 0;
			try {
				while (!valueFound) {
					Console.WriteLine($"gissa ett värder? (0-100) {count}");
					string currentInput = Console.ReadLine();
					count++;
					int currentGess = int.Parse(currentInput);

					if (hiddenValue < currentGess) {
						Console.WriteLine("go down!");
					}
					else if (hiddenValue == currentGess) {
						Console.WriteLine("Yaya " + hiddenValue + " this is your " + count);
						valueFound = true;
					}
					else {
						Console.WriteLine("go up!");
					}
				}
			}
			catch (Exception e) {
				Console.WriteLine("you fool I said betwin 0 and 100!!!!!!");
				Console.ReadKey();
			}
			Console.WriteLine("DONE!");
		}

		private static void RoundCarp() {
			//värdent som skall avrundas
			string valIn = Console.ReadLine();
			double valInDec = double.Parse(valIn);  // förvandal from str to double
													//värdet som skall till dec
			string roundTo = Console.ReadLine();
			int roundToInInt = int.Parse(roundTo);  // förvandal from str to heltal
			double roundedVal = Math.Round(valInDec, roundToInInt); //return value
			Console.WriteLine(roundedVal);          //print
		}
	}
}
