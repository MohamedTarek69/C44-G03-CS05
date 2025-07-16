using System.Security.Cryptography;

namespace Session_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------- Part 01 ---------------------------------------------------
            #region Looping | Iteration Statements

            #region for - foreach

            //                0  1  2  3  4
            //int[] Numbers = { 1, 2, 3, 4, 5 };

            //Console.WriteLine($"Number 0 is {Numbers[0]}");
            //Console.WriteLine($"Number 1 is {Numbers[1]}");
            //Console.WriteLine($"Number 2 is {Numbers[2]}");
            //Console.WriteLine($"Number 3 is {Numbers[3]}");
            //Console.WriteLine($"Number 4 is {Numbers[4]}");

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    //if (i == 2)
            //        //continue;
            //        //break;
            //        //Numbers[i] += 10;
            //        Console.WriteLine($"Number {i} is {Numbers[i]}");
            //}

            //foreach (int Item in Numbers)
            //{
            //    Console.WriteLine(Item + 10);
            //}

            #endregion

            //--------------------------------------------------- Part 02 ---------------------------------------------------
            #region While - do while
            //Console.Write("Enter a number : ");
            //bool IsParse = int.TryParse(Console.ReadLine(), out int Number);
            //// 2 - 10 
            //// 5 - 10
            //// 12
            //if (IsParse == true)
            //{
            //    while (Number <= 10)
            //    {
            //        Console.WriteLine(Number);
            //        Number++;
            //    }
            //}

            //bool IsParse;
            //int Number;
            //do
            //{
            //    Console.Write("Enter Even Number : ");
            //    IsParse = int.TryParse(Console.ReadLine(), out Number);

            //} while (Number % 2 == 1 ||  !IsParse);

            //Console.WriteLine($"{Number} is an Even Number");

            //3 % 2 = 1 odd
            //5 % 2 = 1 odd
            //7 % 2 = 1 odd
            //8 % 2 = 0 even

            #endregion

            #endregion

            //--------------------------------------------------- Part 03 ---------------------------------------------------
            #region string
            #region Example 01
            //string Name;

            //Name = new string("Route"); //10 bytes

            //Console.WriteLine($"Name = {Name}");
            //Console.WriteLine($"HashCode = {Name.GetHashCode()}");

            //string Name02 = "Route";

            //Console.WriteLine($"Name02 = {Name02}");
            //Console.WriteLine($"HashCode02 = {Name02.GetHashCode()}");

            #endregion

            #region Example 02
            //string Name01 = "Amr";
            //string Name02 = "May";

            //Console.WriteLine($"Name01 = {Name01}");
            //Console.WriteLine($"HashCode01 = {Name01.GetHashCode()}");

            //Console.WriteLine($"Name02 = {Name02}");
            //Console.WriteLine($"HashCode02 = {Name02.GetHashCode()}");

            //Name02 = Name01;
            //Console.WriteLine("After Assign");
            //Console.WriteLine($"Name01 = {Name01}");
            //Console.WriteLine($"HashCode01 = {Name01.GetHashCode()}");

            //Console.WriteLine($"Name02 = {Name02}");
            //Console.WriteLine($"HashCode02 = {Name02.GetHashCode()}");

            //Name01 = "Omar";
            //Console.WriteLine("After change value of name01");
            //Console.WriteLine($"Name01 = {Name01}");
            //Console.WriteLine($"HashCode01 = {Name01.GetHashCode()}");

            //Console.WriteLine($"Name02 = {Name02}");
            //Console.WriteLine($"HashCode02 = {Name02.GetHashCode()}");

            #endregion

            #region Example 03
            //string message = "Hello"; // 10 bytes
            //Console.WriteLine($"Message = {message}");
            //Console.WriteLine($"Message HashCode = {message.GetHashCode()}");

            //message += " Route";
            //Console.WriteLine("After Change");
            //Console.WriteLine($"Message = {message}");
            //Console.WriteLine($"Message HashCode = {message.GetHashCode()}");

            #endregion

            #endregion

            //--------------------------------------------------- Part 04 ---------------------------------------------------
            #region String Methods
            //string message = " Hello Route "; // size => 17
            //Console.WriteLine(message.Length); // 17
            //Console.WriteLine(message.ToUpper()); // 17
            //Console.WriteLine(message.ToLower()); // 17
            //Console.WriteLine(message.Trim()); // 17
            //Console.WriteLine(message.TrimEnd()); // 17
            //Console.WriteLine(message.TrimStart()); // 17
            //Console.WriteLine(message.Substring(4, 5)); // 17
            //Console.WriteLine(message.Replace('e', 't')); // 17
            //Console.WriteLine(message.Contains('f')); // 17

            #endregion

        }
    }
}
