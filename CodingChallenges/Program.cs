using System;

namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //string parenthesesInput = "(){}[]";

            //bool isValidParentheses = ValidParentheses.IsValid(parenthesesInput);

            //Console.WriteLine($"Valid Parentheses: {isValidParentheses}");


            //int[] sortedArray1 = { 1, 2, 5 };
            //Console.WriteLine($"{nameof(sortedArray1)}:");
            //Console.WriteLine($"{string.Join(", ", sortedArray1)}");

            //int[] sortedArray2 = { 4, 9, 11 };
            //Console.WriteLine($"{nameof(sortedArray2)}:");
            //Console.WriteLine($"{string.Join(", ", sortedArray2)}");

            //int[] sortedArray3 = MergeSortedArray.Merge(sortedArray1, sortedArray2);
            //Console.WriteLine($"{nameof(sortedArray3)}:");
            //Console.WriteLine($"{string.Join(", ", sortedArray3)}");


            //int[] array = { 1, 2, 5, 10 };
            //Console.WriteLine($""Array: {string.Join(", ", array)}");
            //int[] revertArray = RevertArray.Revert(array);
            //Console.WriteLine($"Revert Array: {string.Join(", ", revertArray)}");

            int[] array = { 1, 2, 5, 10 };
            int target = 7;

            Console.WriteLine($"Array: {string.Join(", ", array)}");
            Console.WriteLine($"Target: {target}");

            var result = TwoSum.Find(array, target);

            Console.WriteLine($"TwoSum Array: {string.Join(", ", result)}");

            Console.ReadLine();
        }
    }
}
