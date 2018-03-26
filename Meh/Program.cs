using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bastun {
	class Program {
		//metod för att omvändla från fahrenheit till celsius

		public static double FahrToCels(double fahr) {
			// round it to the 1 decimal
			return Math.Round((fahr - 32) * 5 / 9, 1);
		}


		static void Main(string[] args) {
			try {
				Random r = new Random(); //init Rand
				Console.WriteLine("Please enter desired temperature in fahrenheit. (q Quit | rand for Random)"); // give info

				//init loop
				bool loop = true;

				while (loop) {
					//Read User input
					string input = Console.ReadLine();
					//conver user input to lower incase of Q or rAnD
					switch (input.ToLower()) {
						case "q": // End Loop for q
						loop = false; 
						break;
						case "rand": // give rand value
						//163.4 - 170
						var randomAsFuck = r.Next(163, 196) + r.NextDouble();
						Console.WriteLine("You guys and your funking RNGs " + FahrToCels(randomAsFuck) + "degres in celsius.");
						break;

						default: // in case of no cmds try parse
						double val = double.Parse(input); 
						double celVal = FahrToCels(val);
						Console.WriteLine("You choose " + val + " degres in fahrenheit which is " + celVal + " degres in celsius.");
						//if the temp is 73 ~ 77 end loop
						if (celVal < 77.0 && celVal > 73.0) {
							loop = false;
						}
						break;
					}


				}



			}
			//if parse Falses catch it
			catch (Exception e) {
				Console.WriteLine("Please enter numbers only.");
				Console.WriteLine(e.Message);
				
			}


			Console.WriteLine("press any key to coutinue");

			Console.ReadKey(true);

		}
	}
}
