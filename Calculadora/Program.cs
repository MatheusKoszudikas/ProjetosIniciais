using System;

class Program
{
    static void Main()
    {
        bool sair = false;

        do
        {
            MostrarMenu();
            char escolha = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (escolha)
            {
                case '1':
                    RealizarOperacao(Somar);
                    break;
                case '2':
                    RealizarOperacao(Subtrair);
                    break;
                case '3':
                    RealizarOperacao(Multiplicar);
                    break;
                case '4':
                    RealizarOperacao(Dividir);
                    break;
                case '5':
                    RealizarOperacao(RestoDaDivisao);
                    break;
                case '6':
                    RealizarOperacao(Potenciacao);
                    break;
                case '0':
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        } while (!sair);
    }
    static void MostrarMenu()
    {
        Console.WriteLine("### Calculadora ###");
        Console.WriteLine("1 - Somar \n2 - Subtrair \n3 - Multiplicar \n" +
        "4 - Dividir \n5 - Resto da Divisão \n6 - Potenciação \n0 - Sair \n");
    }
    static void RealizarOperacao(Func<double, double, double> operacao)
    {
        Console.Write("Digite o primeiro valor: ");
        double valor1;
        if (!double.TryParse(Console.ReadLine(), out valor1))
        {
            Console.WriteLine("Valor inválido. Tente novamente.");
            return;
        }

        Console.Write("Digite o segundo valor: ");
        double valor2;
        if (!double.TryParse(Console.ReadLine(), out valor2))
        {
            Console.WriteLine("Valor inválido. Tente novamente.");
            return;
        }

        try
        {
            double resultado = operacao(valor1, valor2);
            Console.WriteLine("Resultado: " + resultado);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Não é possível dividir por zero.");
        }

        Console.WriteLine("Pressione Enter para continuar...");
        Console.ReadLine();
    }

    static double Somar(double a, double b) => a + b;
    static double Subtrair(double a, double b) => a - b;
    static double Multiplicar(double a, double b) => a * b;
    static double Dividir(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException();

        return a / b;
    }

    static double RestoDaDivisao(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException();

        return a % b;
    }

    static double Potenciacao(double baseValue, double exponent) => Math.Pow(baseValue, exponent);
}