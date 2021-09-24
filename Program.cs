using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Program show = new Program(); // Creating Object
            Console.WriteLine("\t\t\t\t\t  Hey,Welcome to Simple Calculator!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\tWhat's your first name?");
            Console.Write("\t\t\t\t->> ");
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\tWhat's your last name?");
            Console.Write("\t\t\t\t->> ");
            string last_name = Console.ReadLine();
            string output = name + " " + last_name;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("\t\t\t\tWelcome to this simple Calculator Made by C#, MR. ");
            Console.Write(output);
            Console.Write("\n");
            Console.Write("\t\t\t\tPress Enter to Continue...");
            Console.ReadKey();
            Console.Clear();
            show.show();
        }
        public void show()
        {
            Program show = new Program();
            Program add = new Program(); // Creating Object
            Program mul = new Program(); // Creating Object
            Program div = new Program(); // Creating Object
            Program sub = new Program();
            Program Power = new Program();
            Program mod = new Program();
            Program fact = new Program();// Creating Object
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\tThere are Six Functions of this Calculator -");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t ->> 1. Addition");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t ->> 2. Multiplication");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t ->> 3. Division");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t ->> 4. Subtraction");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t ->> 5. Power");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t ->> 6. Factorial");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t ->> 7. Modulas");
            Console.WriteLine("\t\t\t\t ->> Which one to choose?");
            Console.WriteLine("");
            Console.Write("\t\t\t\t ->> ");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    add.add();
                    break;
                case 2:
                    mul.mul();
                    break;
                case 3:
                    div.div();
                    break;
                case 4:
                    sub.sub();
                    break;
                case 5:
                    Power.power();
                    break;
                case 6:
                    fact.factorial();
                    break;
                case 7:
                    mod.modulas();
                    break;
                default:
                    Console.WriteLine("\t\t\t\t");
                    Console.WriteLine("\t\t\t\tWrong Input");
                    Console.WriteLine("");
                    Console.Write("\t\t\t\tPress any key to Continue");
                    Console.ReadKey();
                    show.show();
                    break;

            }

        }
        public void add()
        {
            Program add = new Program(); // Creating Object
            Program show = new Program();
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t  Addition");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("\t\t\t\tPlease input first number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("\t\t\t\tPlease input second number : ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("");
            Console.Write("\t\t\t\tAddition of these numbers are : ");
            Console.WriteLine(sum);
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\tDo you wish to Calculate another one?");
            Console.WriteLine("");
            Console.Write("\t\t\t\tY (Yes) / N (NO) / E (Exit)");
            if (Console.ReadKey(true).KeyChar == 'y')
            {
                add.add();
            }
            else if (Console.ReadKey(true).KeyChar == 'n')
            {
                show.show();
            }
            else if (Console.ReadKey(true).KeyChar == 'e')
            {
                return;
            }
        }
        public void mul()
        {
            Program show = new Program();
            Program mul = new Program(); // Creating Object
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t  Multiplication");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("\t\t\t\tPlease input first number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("\t\t\t\tPlease input second number : ");
            int num2 = int.Parse(Console.ReadLine());
            int mult = num1 * num2;
            Console.WriteLine("");
            Console.Write("\t\t\t\tMultiplication of these numbers are : ");
            Console.WriteLine(mult);
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\tDo you wish to Calculate another one?");
            Console.WriteLine("");
            Console.Write("\t\t\t\tY (Yes) / N (NO) / E (Exit)");
            if (Console.ReadKey(true).KeyChar == 'y')
            {
                mul.mul();
            }
            if (Console.ReadKey(true).KeyChar == 'n')
            {
                show.show();
            }
            if (Console.ReadKey(true).KeyChar == 'e')
            {
                return;
            }

        }
        public void div()
        {
            Program show = new Program();
            Program div = new Program();
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t  Division");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("\t\t\t\tPlease input first number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("\t\t\t\tPlease input second number : ");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("\t\t\t\tDivisor cannot be zero");
                Console.Write("\t\t\t\tPlease enter another value : ");
                int num3 = int.Parse(Console.ReadLine());
                int div2 = num1 / num3;
                Console.WriteLine("");
                Console.Write("\t\t\t\tDivision of these numbers are : ");
                Console.WriteLine(div2);
                Console.WriteLine("");
                Console.WriteLine("\t\t\t\tDo you wish to Calculate another one?");
                Console.WriteLine("");
                Console.Write("\t\t\t\tY (Yes) / N (NO) / E (Exit)");
                if (Console.ReadKey(true).KeyChar == 'y')
                {
                    div.div();
                }
                if (Console.ReadKey(true).KeyChar == 'n')
                {
                    show.show();
                }
                if (Console.ReadKey(true).KeyChar == 'e')
                {
                    return;
                }

            }
            int div1 = num1 / num2;
            Console.WriteLine("");
            Console.Write("\t\t\t\tDivision of these numbers are : ");
            Console.WriteLine(div1);
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\tDo you wish to Calculate another one?");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\tY (Yes) / N (NO) / E (Exit)");
            if (Console.ReadKey(true).KeyChar == 'y')
            {
                div.div();
            }
            if (Console.ReadKey(true).KeyChar == 'n')
            {
                show.show();
            }
            if (Console.ReadKey(true).KeyChar == 'e')
            {
                return;
            }

        }
        public void sub()
        {
            Program show = new Program(); // Creating Object
            Program sub = new Program();
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t  Substraction");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("\t\t\t\tPlease input first number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("\t\t\t\tPlease input second number : ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 - num2;
            Console.WriteLine("");
            Console.Write("\t\t\t\tSubstraction of these numbers are : ");
            Console.WriteLine(sum);
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\tDo you wish to Calculate another one?");
            Console.WriteLine("");
            Console.Write("\t\t\t\tY (Yes) / N (NO) / E (Exit)");
            if (Console.ReadKey(true).KeyChar == 'y')
            {
                sub.sub();
            }
            else if (Console.ReadKey(true).KeyChar == 'n')
            {
                show.show();
            }
            else if (Console.ReadKey(true).KeyChar == 'e')
            {
                return;
            }
        }
        public void modulas()
        {
            Program mod = new Program(); // Creating Object
            Program show = new Program();
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t  Modulus");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("\t\t\t\tPlease input first number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("\t\t\t\tPlease input second number : ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 % num2;
            Console.WriteLine("");
            Console.Write("\t\t\t\tModulus of these numbers are : ");
            Console.WriteLine(sum);
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\tDo you wish to Calculate another one?");
            Console.WriteLine("");
            Console.Write("\t\t\t\tY (Yes) / N (NO) / E (Exit)");
            if (Console.ReadKey(true).KeyChar == 'y')
            {
                mod.modulas();
            }
            else if (Console.ReadKey(true).KeyChar == 'n')
            {
                show.show();
            }
            else if (Console.ReadKey(true).KeyChar == 'e')
            {
                return;
            }
        }



        public void power() {
            Program Power = new Program();
            Program show = new Program();
            Console.Clear();
            double num, num2;
            Console.WriteLine("\t\t\t\t\t  Power");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("\t\t\t\tEnter the Number : ");
            num = double.Parse(Console.ReadLine());
            Console.Write("\t\t\t\tGive the Exponent : ");
            num2 = double.Parse(Console.ReadLine());
            double value1 = Math.Pow(num, num2);
            Console.Write("\t\t\t\tPower of {0} is : {1} ", num, value1);         
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\tDo you wish to Calculate another one?");
            Console.WriteLine("");
            Console.Write("\t\t\t\tY (Yes) / N (NO) / E (Exit)");
            if (Console.ReadKey(true).KeyChar == 'y')
            {
                Power.power();
            }
            else if (Console.ReadKey(true).KeyChar == 'n')
            {
                show.show();
            }
            else if (Console.ReadKey(true).KeyChar == 'e')
            {
                return;
            }

        }

        public void factorial()
        {
            Program fact = new Program();
            Program show = new Program();
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t  Factorial");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("\t\t\t\tPlease Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                int fact1 = 1;
                Console.WriteLine("");
                Console.WriteLine("\t\tPlease enter a positive number to find factorial and try again.");
                Console.WriteLine("");
                Console.Write("\t\t\t\tPlease Enter Again : ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                for (int i=1; i<=num1; i++)
                {  
                    fact1 = fact1 * i;
                }
                Console.WriteLine("");
                Console.WriteLine("\t\t\t\tFactorial of {0} is : {1}", num1, fact1);
                Console.WriteLine("");
                Console.WriteLine("\t\t\t\tDo you wish to Calculate another one?");
                Console.WriteLine("");
                Console.Write("\t\t\t\tY (Yes) / N (NO) / E (Exit)");
                if (Console.ReadKey(true).KeyChar == 'y')
                {
                    fact.factorial();
                }
                else if (Console.ReadKey(true).KeyChar == 'n')
                {
                    show.show();
                }
                else if (Console.ReadKey(true).KeyChar == 'e')
                {
                    return;
                }


            }
            int factorial1 = 1;
            for (int j = 1; j <= num; j++)
            {
                
                factorial1 = factorial1 * j;
                
            }
            Console.WriteLine("");     
            Console.WriteLine("\t\t\t\tFactorial of {0} is : {1}", num, factorial1) ;
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\tDo you wish to Calculate another one?");
            Console.WriteLine("");
            Console.Write("\t\t\t\tY (Yes) / N (NO) / E (Exit)");
            if (Console.ReadKey(true).KeyChar == 'y')
            {
                fact.factorial();
            }
            else if (Console.ReadKey(true).KeyChar == 'n')
            {
                show.show();
            }
            else if (Console.ReadKey(true).KeyChar == 'e')
            {
                return;
            }
        }
    }   
    
}
