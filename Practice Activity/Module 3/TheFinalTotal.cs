using System;

namespace TheFinalTotal {
    public class TheFinalTotal {
        public static void Main() {
            long total = 10; // Initial total

            Console.Write("Enter an integer: ");
            int inputInt1 = Convert.ToInt32(Console.ReadLine());

            if (inputInt1 == 0) {
                Console.WriteLine("Nothing happened.");
            } else if (inputInt1 > 0) { 
                if (inputInt1 % 2 == 0) {
                    Console.WriteLine("The number is even.");
                    inputInt1 *= inputInt1; // Square if even
                } else {
                    Console.WriteLine("The number is odd.");
                    inputInt1 = inputInt1 * inputInt1 * inputInt1; // Cube if odd
                }
                total += inputInt1;
            } else { 
                Console.Write("Enter another positive integer: ");
                int inputInt2 = Convert.ToInt32(Console.ReadLine());

                if (inputInt2 < 0) {
                    Console.WriteLine("Invalid input! The second integer must be positive.");
                } else {
                    long result = inputInt1;

                    for (int i = 0; i < inputInt2; i++) {
                        result *= result;
                    }

                    total += result;
                }
            }

            if (total != 0) {
                Console.WriteLine($"Value of Total: {total}");
            }
        }
    }
}
