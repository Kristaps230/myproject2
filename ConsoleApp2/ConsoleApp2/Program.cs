﻿using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int myNumber = 15;
            char myFavoriteLetter = 'A';
            bool isCar = true;
            double myConstant = 4.58;
            float myChangingNum = 2.46f;
            string name = "Kristaps";

            Console.WriteLine(myNumber);
            Console.WriteLine(myFavoriteLetter);
            Console.WriteLine(isCar);
            Console.WriteLine(myConstant);
            Console.WriteLine(myChangingNum);
            Console.WriteLine(name);

            Console.WriteLine(myConstant + myChangingNum);


            //----------------------------------------------------------------


            int myNumber1 = 4;
            int myNumber2 = 6;

            int sum1 = myNumber1 + myNumber2;

            Console.WriteLine(sum1);

            string name1 = "Hello ";
            string name2 = "from code";

            string namesTogether = name1 + name2;

            Console.WriteLine(namesTogether);


            int withPluses = 4;
            withPluses++;


            Console.WriteLine(withPluses);


            int divisionreminder1 = 10;
            int divisionreminder2 = 2;

            int divisionreminderResult = divisionreminder1 % divisionreminder2;

            Console.WriteLine(divisionreminderResult);


            //--------------------------------------------------------------------------------------




            int myNumber5 = 15;
            int myNumber6 = 17;

            bool isEqualNumber = myNumber5 == myNumber6;

            Console.WriteLine(isEqualNumber);


            string myText4 = "ABC";
            string myText5 = "ABC";


            bool isEqualText = myText4 == myText5;

            Console.WriteLine(isEqualText);


            int myNumber7 = 15;
            int myNumber8 = 17;

            bool isEqualNumber2 = myNumber7 > myNumber8;

            Console.WriteLine(isEqualNumber2);


            //----------------------------------------------------------------



            bool iAmTrue = true;
            bool iAmFalse = false;

            bool both = iAmTrue && iAmFalse;
            bool or = iAmTrue || iAmFalse;
            bool bothReversed = !both;

            Console.WriteLine(both);
            Console.WriteLine(or);
            Console.WriteLine(bothReversed);


            //-----------------------------------------------------------------



            int myNumber9 = 14;

            myNumber9 += 10;


            Console.WriteLine(myNumber9);


            //-----------------------------------------------------------------



            Console.WriteLine("Kads ir tavs vards?");


            string userName = Console.ReadLine();

            Console.WriteLine("Sveiks, " + userName);



            Console.WriteLine("Kads ir tavs vecums?");
            string ageText = Console.ReadLine();

            int age = int.Parse(ageText);
            int previosYearAge = age - 1;

            Console.WriteLine("Sveiks tev iepriekseja gada bija: " + previosYearAge);



            //-----------------------------------------------------------------------

            Console.WriteLine("========================================================");

            int maxNumber1 = 15;
            int maxNumber2 = 6;

            int maxResult = Math.Max(maxNumber1, maxNumber2);

            Console.WriteLine(maxResult);



            int absWithMinus = -45;
            int absAfter = Math.Abs(absWithMinus);

            Console.WriteLine(absAfter);


            double numberToRound = 14.258;
            double rounded = Math.Round(numberToRound, 2);

            Console.WriteLine(rounded);
















































        }
    }
}
