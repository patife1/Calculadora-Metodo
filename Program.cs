using System;

class Program
{
    static void Main()
    {
        double num1, num2, result;
        string operation;

        Console.WriteLine("Calculadora");

        Console.Write("Digite o primeiro número: ");
        num1 = Convert.ToDouble(Console.ReadLine());

      
        Console.Write("Digite a operação (+, -, *, /): ");
        operation = Console.ReadLine();

       
        Console.Write("Digite o segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());

       
        if (operation == "+")
        {
            result = num1 + num2;
            Console.WriteLine($"Resultado: {num1} + {num2} = {result}");
        }
        else if (operation == "-")
        {
            result = num1 - num2;
            Console.WriteLine($"Resultado: {num1} - {num2} = {result}");
        }
        else if (operation == "*")
        {
            result = num1 * num2;
            Console.WriteLine($"Resultado: {num1} * {num2} = {result}");
        }
        else if (operation == "/")
        {
            if (num2 != 0)
            {
                result = num1 / num2;
                Console.WriteLine($"Resultado: {num1} / {num2} = {result}");
            }
            else
            {
                Console.WriteLine("Erro! Divisão por zero.");
            }
        }
        else
        {
            Console.WriteLine("Operação inválida!");
        }
    }
}
