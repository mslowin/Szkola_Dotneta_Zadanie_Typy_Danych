using Math = System.Math;

namespace SzkolaDotnetaZadanieTypyDanych 
{
	internal class Program
	{
		private static void Main()
		{
			// Zadanie 1:
			string name;
			string lastName;
			int age;
			char sex;
			string pesel;
			string workNumber;

			// Zadanie 2:
			var letter1 = "a";
			var letter2 = "b";
			var letter3 = "c";

			Console.WriteLine(letter3 + letter2 + letter1);

			// Zadanie 3:
			var height = 10;
			var width = 20;

			var diagonal = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(width, 2));

			Console.WriteLine(diagonal);

			// Zadanie 4:
		}
	}
}