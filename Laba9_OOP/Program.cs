using System;
using Laba9Lib;
namespace Laba9_OOP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("~Operations with a string~");
                Console.ResetColor();
                Console.Write("Input a string: ");
                string sentense = Console.ReadLine();
                Console.Write("Input a char: ");
                char ch = char.Parse(Console.ReadLine());
                String1 str = new String1(sentense, ch);
                //підписка на метод HandleOnCharFounded
                str.RegistrOnHowManyChars(String1.HandleOnCharFound);
                //виклик метода для підрахунку кількості входжень символа
                Console.ForegroundColor = ConsoleColor.Yellow;
                str.HowMany(sentense, ch);
                Console.ResetColor();
                Console.WriteLine($"There are {str.num} char(-s)");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("~Operations with integers~"); 
                Console.ResetColor();
                Console.Write("Input num1: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Input num2: ");
                int b = int.Parse(Console.ReadLine());
                EventClass operation = new EventClass(a, b);
                //підписка на подію: успішне ділення
                operation.OnDevision += EventClass.HandleOnDevision;
                operation.Sum();
                Console.WriteLine($"The result of adding: {operation.Result}");
                operation.Minus();
                Console.WriteLine($"The result of subtraction: {operation.Result}");
                operation.Multiply();
                Console.WriteLine($"The result of multiplication: {operation.Result}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                operation.Devision();
                Console.ResetColor();
                Console.WriteLine($"The result of devision: {operation.Result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
