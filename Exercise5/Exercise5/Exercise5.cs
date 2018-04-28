using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Exercise5
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        //1. Find all elements of an array with a value less than 5.
        public int[] GetElementsByQ1()
        {
            return numbers.Where(i => i < 5).ToArray();
        }

        //2. Returns digits whose name is shorter than their value.
        public string[] GetElementsByQ2()
        {
            return digits.Where((d, index) => d.Length < index).ToArray();
        }

        //3. The first 3 elements of the array.
        public int[] GetElementsByQ3()
        {
            return numbers.Where((d, index)=> index < 3).ToArray();
        }

        //4. Get all but the first four elements of the array.
        public int[] GetElementsByQ4()
        {
            return numbers.Skip(4).ToArray();
        }

        //5. Return elements starting from the beginning of the array 
        //   until a number is read whose value is not less than 6.
        public int[] GetElementsByQ5()
        {
            return numbers.TakeWhile(d => d <6).ToArray();
        }

        //6. Return elements starting from the beginning of the array 
        //   until a number is hit that is less than its position in the array.
        public int[] GetElementsByQ6()
        {
            return numbers.TakeWhile((d, index) => d > index).ToArray();
        }

        //7. Find the first element in the array that starts with 'f'.
        public string GetElementsByQ7()
        {
            return digits.Where(d => d.IndexOf("f")>=0).First();
        }

        //8. Find the last element in the array that starts with 'f'.
        public string GetElementsByQ8()
        {
            return digits.Where(d => d.IndexOf("f") >= 0).Last();
        }

        //9. Retrieve the second number small than 5 from an array.
        public int GetElementsByQ9()
        {
            return numbers.Where(d => d < 5).Skip(1).First();
        }

        //10. Retrieve the second number greater than 5 from an array.
        public int GetElementsByQ10()
        {
            return numbers.Where(d => d > 5).Skip(1).First();
        }
    }
}
