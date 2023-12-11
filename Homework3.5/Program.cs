
/*Створити клас Printer. У тілі класу створіть метод void Print(string value), що виводить на екран значення аргументу.
 * Реалізуйте можливість того, щоб у разі успадкування від даного класу інших класів, та виклику відповідного методу їх екземпляра, 
 * рядки, передані як аргументи методів, виводилися різними кольорами. Обов'язково використовуйте типи.*/

namespace Homework3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrinterColor printer = new PrinterColor(ConsoleColor.Red);
            printer.Print("some text");

          
            PrinterColor printer1 = new PrinterColor(ConsoleColor.Green);
            printer1.Print("some text 2");

            Console.ReadKey();
        }
    }
}