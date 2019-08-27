using System;
using System.Text;

namespace CodeWarsLvl7
{
    class Program
    {
        public static double SumArray(double[] array)
        {
            double sumofArray = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sumofArray += array[i];
            }
            return sumofArray;
        }
        public static string Solve(string s) // return same case
        {
            int lower = 0;
            int higher = 0;
            foreach (char w in s)
            {
                if (w >= 'a' && w <= 'z')
                {
                    lower++;
                }
                else if (w >= 'A' && w <= 'Z')
                {
                    higher++;
                }
            }
            if (lower > higher) return s.ToLower();
            if (lower < higher) return s.ToUpper();
            return s;
        }
            static void Main(string[] args)
        {
            int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            double[] numbers = {3,5,6,3,6,5,4 };
            Console.WriteLine(GroupByCommas(5)); //Grouping integers by commas, Lvl 6 problem
            Console.WriteLine(SumArray(numbers)); //Sum of an array, Lvl 8 problem
            Console.WriteLine(CreatePhoneNumber(integers)); // Create a phone number with 10 digits, Lvl 6 problem
            Console.WriteLine(Solve("CshaRp")); // Returns same case based on which case shows up more, Lvl 7 problem
        }
        public static string CreatePhoneNumber(int[] numbers)
        {
            string result = string.Join("", numbers);   // Turns int array into a string a
            StringBuilder sb = new StringBuilder(result);
            sb.Insert(0, "(");
            sb.Insert(4, ")");
            sb.Insert(5, " ");
            sb.Insert(9, "-");
            return sb.ToString();
        }
        public static string GroupByCommas(int n) 
        {
            string comma = n.ToString();
            StringBuilder sb = new StringBuilder(comma);
            if (comma.Length == 4)
            {
                sb.Insert(1, ",");
            }
            if (comma.Length == 5)
            {
                sb.Insert(2, ",");
            }
            if (comma.Length == 6)
            {
                sb.Insert(3, ",");
            }
            if (comma.Length == 7)
            {
                sb.Insert(1, ",");
                sb.Insert(5, ",");
            }
            if (comma.Length == 8)
            {
                sb.Insert(2, ",");
                sb.Insert(6, ",");
            }
            if (comma.Length == 9)
            {
                sb.Insert(3, ",");
                sb.Insert(7, ",");
            }
            if (comma.Length == 10)
            {
                sb.Insert(1, ",");
                sb.Insert(5, ",");
                sb.Insert(9, ",");
            }
            return sb.ToString();
        }
    }
}
