using System;

namespace CalculadoraCientifica
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Calculadora Científica");
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1. Soma");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Potência");
                Console.WriteLine("6. Raiz Quadrada");
                Console.WriteLine("7. Seno");
                Console.WriteLine("8. Cosseno");
                Console.WriteLine("9. Tangente");
                Console.WriteLine("0. Sair");
                Console.Write("Digite o número da operação desejada: ");

                string opcao = Console.ReadLine();

                if (opcao == "0")
                {
                    continuar = false;
                    Console.WriteLine("Saindo...");
                    break;
                }

                double numero1, numero2, resultado;

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o primeiro número: ");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        numero2 = Convert.ToDouble(Console.ReadLine());
                        resultado = numero1 + numero2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;

                    case "2":
                        Console.Write("Digite o primeiro número: ");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        numero2 = Convert.ToDouble(Console.ReadLine());
                        resultado = numero1 - numero2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;

                    case "3":
                        Console.Write("Digite o primeiro número: ");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        numero2 = Convert.ToDouble(Console.ReadLine());
                        resultado = numero1 * numero2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;

                    case "4":
                        Console.Write("Digite o primeiro número: ");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        numero2 = Convert.ToDouble(Console.ReadLine());
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                            Console.WriteLine("Resultado: " + resultado);
                        }
                        else
                        {
                            Console.WriteLine("Erro! Divisão por zero.");
                        }
                        break;

                    case "5":
                        Console.Write("Digite o número base: ");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o expoente: ");
                        numero2 = Convert.ToDouble(Console.ReadLine());
                        resultado = Math.Pow(numero1, numero2);
                        Console.WriteLine("Resultado: " + resultado);
                        break;

                    case "6":
                        Console.Write("Digite o número para calcular a raiz quadrada: ");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        if (numero1 >= 0)
                        {
                            resultado = Math.Sqrt(numero1);
                            Console.WriteLine("Resultado: " + resultado);
                        }
                        else
                        {
                            Console.WriteLine("Erro! Não é possível calcular a raiz quadrada de um número negativo.");
                        }
                        break;

                    case "7":
                        Console.Write("Digite o ângulo em graus para calcular o seno: ");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        resultado = Math.Sin(DegreeToRadian(numero1));
                        Console.WriteLine("Resultado: " + resultado);
                        break;

                    case "8":
                        Console.Write("Digite o ângulo em graus para calcular o cosseno: ");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        resultado = Math.Cos(DegreeToRadian(numero1));
                        Console.WriteLine("Resultado: " + resultado);
                        break;

                    case "9":
                        Console.Write("Digite o ângulo em graus para calcular a tangente: ");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        resultado = Math.Tan(DegreeToRadian(numero1));
                        Console.WriteLine("Resultado: " + resultado);
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        // Função para converter graus para radianos
        static double DegreeToRadian(double degree)
        {
            return degree * (Math.PI / 180);
        }
    }
}
