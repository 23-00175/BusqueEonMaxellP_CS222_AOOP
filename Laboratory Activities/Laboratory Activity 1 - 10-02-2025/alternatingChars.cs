using System;

namespace AlternatingChars {
    public class AlternatingChars {
        static void Main() {
            char firstChar, secondChar;
            int size;

            Console.Write("First character: ");
            firstChar = Convert.ToChar(Console.ReadLine());
            Console.Write("Second character: ");
            secondChar = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter size: ");
            size = Convert.ToInt32(Console.ReadLine());       

            for (int i = 0; i < size; i++) {

                for (int j = 0; j < i; j++) {
                    Console.Write('-');
                }

                if (i % 2 == 0) 
                    Console.WriteLine(firstChar);
                else
                    Console.WriteLine(secondChar);
            }
        }
    }
}