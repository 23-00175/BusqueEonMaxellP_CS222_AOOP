using System;

namespace SquarePattern {
    public class SquarePattern {
        static void Main() {
            int rowsColumns, skipRow;

            Console.Write("Enter n: ");
            rowsColumns = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y: ");
            skipRow = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rowsColumns; i++) {
                if (i == skipRow) {
                    Console.WriteLine("");
                    continue;
                }

                for (int j = 1; j <= rowsColumns; j++) { 
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
