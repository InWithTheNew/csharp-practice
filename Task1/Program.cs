using System;

namespace Task1{

    class NumberThingy
    {


        static void Main(){

            var numbers1 = new NumberArray();

            string[] numbers = File.ReadAllLines("digits.txt");
            string[] numbersArray = numbers[0].Split(',');

            //Loop through input Array and add them to our object
            foreach(string i in numbersArray)
            {
                double numDouble = Convert.ToDouble(i);
                numbers1.AddNum(numDouble);
            }

            //print all of the results
            var returnVal = numbers1.ReturnNums(); // get all nums
            var listCount = numbers1.Count(); //task 1
            var totalValue = numbers1.SumAll(); // task 2
            var smallestNum = numbers1.SortAscending()[0]; // task 3
            var largestNum = numbers1.SortDescending()[0]; // task 4
            var evenNumbers = numbers1.CountEvenNumbers(); // task 5
            var oddNumbers = numbers1.CountOddNumbers(); //task 6


            //Console.WriteLine(string.Join("\n", returnVal));
            Console.WriteLine($"Total numbers in file: {listCount}");
            Console.WriteLine($"Sum of all numbers in file: {totalValue}");
            Console.WriteLine($"Smallest number: {smallestNum}");
            Console.WriteLine($"Largest number: {largestNum}");
            Console.WriteLine($"Even numbers: {evenNumbers}");
            Console.WriteLine($"Odd numbers: {oddNumbers}");

        }
    }
}
