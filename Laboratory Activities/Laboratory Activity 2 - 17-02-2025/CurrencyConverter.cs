/* Write a program that accepts an amount in one currency (e.g., USD) and
converts it to another currency (e.g., EUR), based on a fixed exchange rate
provided by the user.
*/

using System;

namespace CurrencyConverter {
    public class CurrencyConverter {
        public static void Main() {

            double usdAmount, exchangeRate, eurAmount;

            Console.Write("Enter amount in USD: ");
            usdAmount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter exchange rate from USD to EUR: ");
            exchangeRate = Convert.ToDouble(Console.ReadLine());
            
            eurAmount = usdAmount * exchangeRate;

            Console.WriteLine($"Amount in EUR: {eurAmount:F2}");
        }
    }
}