using System;

namespace interestCalculator {
    public class InterestCalculator {
        public static void Main() {

            double principalAmount, interestRate, simpleInterest;
            int years;

            Console.Write("Enter principal amount: ");
            principalAmount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter rate of interest: ");
            interestRate = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter time in years: ");
            years = Convert.ToInt32(Console.ReadLine());

            simpleInterest = (principalAmount * interestRate * years) / 100;

            Console.WriteLine("Simple Interest: " + simpleInterest);
        }
    }
}