using System;

namespace Methods
{
    class Program
    {
        #region Task1   
        // Task1 -- Divided or not divided by 3 an 7
        //static void Main(string[] args)
        //{
        //    int n = 42;
        //    var result = Division(n);
        //    Console.WriteLine(result);
        //}

        //public static string Division(int n)
        //{
        //    if (n % 3 == 0 && n % 7 == 0)
        //    {
        //        return "divided by 3 and 7.";
        //    }
        //    else
        //    {
        //        return "not divided by 3 and 7.";
        //    }
        //}
        #endregion
        #region Task2
        //Task2 -- Sum of the n and m numbers
        //static void Main(string[] args)
        //{
        //    int n = 22;
        //    int m = 56;
        //    EvenNumber(n, m);
        //}

        //public static void EvenNumber(int n, int m)
        //{
        //    int sum;
        //    if (n % 2 == 0 && m % 2 == 0)
        //    {
        //        sum = n + m;
        //        Console.WriteLine(sum); 
        //    }
        //    else
        //    {
        //        Console.WriteLine("Both of them are not even number. Please enter the correct numbers.");
        //    }
        //}
        #endregion
        #region Task3
        //Task3 -- Count of the odd numbers
        //static void Main(string[] args)
        //{
        //    int n = 4;
        //    int m = 20;
        //    var result = Count(n, m);
        //    Console.WriteLine("Count = " + result);
        //}

        //public static int Count(int n, int m)
        //{
        //    int count = 0;
        //    for (int i = n; i <= m; i++)
        //    {
        //        if (i % 2 == 1)
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
        #endregion
        #region Task4
        // Task4 -- Sum of the odd numbers
        //static void Main(string[] args)
        //{
        //    int n = 4;
        //    int m = 22;
        //    var result = Sum(n, m);
        //    Console.WriteLine("Sum = " + result);
        //}

        //public static int Sum(int n, int m)
        //{
        //    int sum = 0;
        //    for (int i = n; i <= m; i++)
        //    {
        //        if (i % 2 == 1)
        //        {
        //            sum += i;
        //        }
        //    }
        //    return sum;
        //}
        #endregion
        #region Task5
        //Task5 -- Sum of the odd numbers in array
        //static void Main(string[] args)
        //{
        //    int[] numbers = { 2, 17, 24, 18, 29, 32, 35, 4, 6, 9 };
        //    var result = ArraySumOfOddNumbers(numbers);
        //    Console.WriteLine("Sum = " + result);
        //}

        //public static int ArraySumOfOddNumbers(int[] numbers)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] % 2 == 1)
        //        {
        //            sum += numbers[i];
        //        }
        //    }
        //    return sum;
        //}
        #endregion
        #region Task6
        //Task6 -- Count of the even numbers in array
        //static void Main(string[] args)
        //{
        //    int[] numbers = { 34, 21, 67, 45, 52, 23, 11, 12, 15, 128 };
        //    var result = ArrayCountOfEvenNumbers(numbers);
        //    Console.WriteLine("Count = " + result);
        //}

        //public static int ArrayCountOfEvenNumbers(int[] numbers)
        //{
        //    int count = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] % 2 == 0)
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
        #endregion
        #region Task7
        // Prime or Composite number
        //static void Main(string[] args)
        //{
        //    int n = 17;
        //    var result = PrimeCompositeNumber(n);
        //    Console.WriteLine(result);
        //}

        //public static string PrimeCompositeNumber(int n)
        //{
        //    int count = 1;
        //    if (n <= 1)
        //    {
        //        return "Enter the correct number.";
        //    }
        //    else
        //    {
        //        for (int i = 2; i < n; i++)
        //        {
        //            if (n % i == 0)
        //            {
        //                count = 0;
        //                break;
        //            }
        //        }
        //        if (count == 1)
        //            return "It is the prime number.";
        //        else
        //            return "It is the composite number.";
        //    }
        #endregion
        #region Task8
        // Task8 -- n is equal to any power of 2 or not
        //public static void Main(string[] args)
        //{
        //    int n = 1;
        //    var result = IsEqualToPowerOf2(n);
        //    Console.WriteLine(result);
        //}

        //public static string IsEqualToPowerOf2(int n)
        //{
        //    if (n<=1)
        //    {
        //        return "Enter the correct number.";
        //    }
        //    else
        //    {
        //        int i = 2;
        //        while (i<n)
        //        {
        //            i *= 2;
        //        }
        //        if (n == i)
        //        {
        //            return "n is equal to any power of 2.";
        //        }
        //        else
        //        {
        //            return "n is not equal to any power of 2";
        //        }
        //    }
        //}
        #endregion
        #region Task9
        // Multiplication of the numbers between 1-20 in array
        //public static void Main(string[] args)
        //{
        //    int[] numbers = { 2, 1, 13, 35, 16, 48, 23, 20, 9 };
        //    var result = Multiplication(numbers);
        //    Console.WriteLine("Multiplication = " + result);
        //}

        //public static int Multiplication(int[] numbers)
        //{
        //    int mult = 1;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] >= 1 && numbers[i] <= 20)
        //        {
        //            mult *= numbers[i];
        //        }
        //    }
        //    return mult;
        //}
        #endregion
        #region Task10
        // Calculation the square of sum of the even numbers in array
        //public static void Main(string[] args)
        //{
        //    int[] numbers = { 3, 20, 6, 15, 12, 7, 19, 5, 21, 4 };
        //    var result = SquareOfSumOfTheEvenNumbers(numbers);
        //    Console.WriteLine("Square = " + result);
        //}

        //public static int SquareOfSumOfTheEvenNumbers(int[] numbers)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] % 2 == 0)
        //            sum += numbers[i];
        //    }
        //    int square = sum * sum;
        //    return square;
        //}
        #endregion
    }
}
        