using System;
namespace Test;

class Program
{
    static void Addition(double a, double b)
    {
        Console.WriteLine($"Your result is: {a + b}");
    }
    static void Subtraction(double a, double b)
    {
        Console.WriteLine($"Your result is: {a - b}");

    }
    static void Multiplication(double a, double b)
    {
        Console.WriteLine($"Your result is: {a * b}");

    }
    static void Division(double a, double b)
    {
        Console.WriteLine($"Your result is: {a / b}");

    }

    static void Calculate()
    {
        Console.Write("Select an operation (+, -, *, /): ");
        string answer = Console.ReadLine();
        string[] operations = { "+", "-", "*", "/" };
        bool isValid = false;
        foreach (string operation in operations)
        {
            if (answer == operation)
            {
                isValid = true;
                break;
            }
        }

        if (!isValid)
        {
            Console.WriteLine("Invalid operation");
            return;
        }

        Console.Write("Select number 1: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Select number 2: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        switch (answer)
        {
            case "+":

                Addition(num1, num2);
                break;

            case "-":

                Subtraction(num1, num2);
                break;

            case "*":

                Multiplication(num1, num2);
                break;

            case "/":

                Division(num1, num2);
                break;
        }

        Console.Write("do you want operation again? ");
        string rep = Console.ReadLine();

        while (rep == "Yes" || rep == "yes" || rep == "YES")
        {
            Calculate();
            break;
        }
    }

    static void Main(string[] args)
    {
        
        
        Calculate();
    }
}