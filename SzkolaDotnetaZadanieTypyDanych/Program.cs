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
            int firstNumber;
            double secondNumber; // double bo nie potrzeba ogromnej precyzji w tym przypadku
            string text;

            firstNumber = 10;
            secondNumber = 15.5;
            text = "Szkoła Dotneta";


            // Zadanie 5:
            string? userName = null;
            string? userLastName = null;
            string? userAge = null;
            string? userWeight = null;
            string? userTelephoneNumber = null;
            string? userAddress = null;
            string? userHeight = null;
            string? userBankAccountBalance = null;

            Console.WriteLine("Poproszę podać swoje dane");

            while (CheckForNullOrEmpty(userName))
            {
                Console.Write("Imię: ");
                userName = Console.ReadLine();
            }

            while (CheckForNullOrEmpty(userLastName))
            {
                Console.Write("Nazwisko: ");
                userLastName = Console.ReadLine();
            }

            while (CheckForNullOrEmpty(userAge))
            {
                Console.Write("Wiek: ");
                userAge = Console.ReadLine();
            }

            while (CheckForNullOrEmpty(userWeight))
            {
                Console.Write("Waga: ");
                userWeight = Console.ReadLine();
            }

            while (CheckForNullOrEmpty(userTelephoneNumber))
            {
                Console.Write("Numer telefonu: ");
                userTelephoneNumber = Console.ReadLine();
            }

            while (CheckForNullOrEmpty(userAddress))
            {
                Console.Write("Adres zamieszkania: ");
                userAddress = Console.ReadLine();
            }

            while (CheckForNullOrEmpty(userHeight))
            {
                Console.Write("Wysokość: ");
                userHeight = Console.ReadLine();
            }

            while (CheckForNullOrEmpty(userBankAccountBalance))
            {
                Console.Write("Stan konta: ");
                userBankAccountBalance = Console.ReadLine();
            }

            int userAgeInt;
            double userWeightDouble;
            double userHeightDouble;
            decimal userBankAccountBalanceDecimal;
            Console.WriteLine("\r\nPrzekonwertowane wartości to: ");
            if (int.TryParse(userAge, out userAgeInt))
            {
                Console.WriteLine($"Wiek: {userAgeInt}");
            }
            if (double.TryParse(userWeight?.Replace('.', ','), out userWeightDouble))
            {
                Console.WriteLine($"Waga: {userWeightDouble}");
            }
            if (double.TryParse(userHeight?.Replace('.', ','), out userHeightDouble))
            {
                Console.WriteLine($"Wysokość: {userHeightDouble}");
            }
            if (decimal.TryParse(userBankAccountBalance?.Replace('.', ','), out userBankAccountBalanceDecimal))
            {
                Console.WriteLine($"Stan konta: {userBankAccountBalanceDecimal}");
            }
            // Reszta zostaje jako wartości wtypu string
        }

        private static bool CheckForNullOrEmpty(string? text)
        {
            return text == null || text == string.Empty;
        }
    }
}