using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Check what courses you qualify for.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            Console.Clear();

            var English = CheckEnglish();
            var Math = CheckMath();

            CheckForQualification(English, Math);

        }
        static Subject CheckEnglish()
        {
            var TookEnglish = false;
            Subject E = new Subject();
            while (!TookEnglish)
            {
                Console.WriteLine("Did you take English? (y/n)");
                try
                {
                    var EnglishOrNot = Char.ToLower(Char.Parse(Console.ReadLine()));
                    Console.Clear();
                    switch (EnglishOrNot)
                    {
                        case 'y':
                            TookEnglish = true;
                            Console.WriteLine("What was your final mark?");
                            E.Mark = Convert.ToDouble(Console.ReadLine());
                            E.Name = "English";
                            break;
                        case 'n':
                            Console.WriteLine("If you are a foreign student, you will need to complete an English proficiency test before checking what courses you qualify for at Belgium campus."); 
                            Console.ReadLine();
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Please enter a y for yes or n for no");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a single character.");
                    Console.ReadLine();
                }
                Console.Clear();
            }
            return E; 
        }
        static Subject CheckMath()
        {
            Console.Clear();
            Subject M = new Subject();
            var TookMath = false;
            while (!TookMath)
            {
                Console.WriteLine("Did you take Math or Math lit? (M/m)");
                try
                {
                    var MathOrMathLit = Char.Parse(Console.ReadLine()) ;
                    switch (MathOrMathLit)
                    {
                        case 'M':
                            Console.Clear();
                            Console.WriteLine("What was your final mark?");
                            M.Mark = Convert.ToDouble(Console.ReadLine());
                            M.Name = "Math";
                            TookMath = true;
                            break;
                        case 'm':
                            Console.Clear();
                            Console.WriteLine("What was your final mark?");
                            M.Mark = Convert.ToDouble(Console.ReadLine());
                            M.Name = "Math Lit";
                            TookMath = true;
                            break;
                        default:
                            Console.WriteLine("Please enter a M for Math or m for Math Lit");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Please enter a single character.");
                    Console.ReadLine();
                }
            }
            return M;

        }
        static void CheckForQualification(Subject Subject1 , Subject Subject2)
        {
            Console.Clear();
            Console.WriteLine("You qaulify for the following courses");
            if (Subject1.Mark > 50 && Subject2.Mark > 50 && Subject2.Name == "Math")
            {
                Console.WriteLine("\n - Bachelor of Computing\n - Bachelor of Information Technology \n - Diploma of Information Technology");
            }
            else
            {
                if (Subject2.Name == "Math Lit")
                {
                    Console.WriteLine("\n - Diploma of Information Technology \n - \n -");
                }
                else
                {
                    if (Subject2.Mark < 50)
                    {
                        Console.WriteLine(" - \n - \n -");
                        Console.WriteLine("\nYou will need to take the Mathematics bridging course and achieve 50% for BIT and 70% for BComp");
                    }
                }
            }
            Console.ReadLine();
        }
    }

    public class Subject
    {
        public double? Mark { get; set; }
        public string? Name { get; set; }
        public Subject(double mark, string name)
        {
            Mark = mark;
            Name = name;
        }
        public Subject()
        {
            
        }
    }
}
