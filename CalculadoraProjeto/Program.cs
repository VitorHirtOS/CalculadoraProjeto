using System;

namespace Calculator 
{

    class Calculadora
    {
        public static void Main(string[] args) // Função base. Métodos sempre com a primeria letra maiscula
        {
            Console.WriteLine("Escreva a operação");
            char operacao = Char.Parse(Console.ReadLine());

            Console.WriteLine("Escreva dois números para operação: ");
            long i = long.Parse(Console.ReadLine());
            long x = long.Parse(Console.ReadLine());

            long result = Calculadora.Math(operacao, i, x);
            Console.WriteLine($" O resultado da operação é = {result}");

            string frase = null; // Temos esta forma para passar os paramentros para nossa função de chamada ou passamos diretamente na função de chamada valores vazio 

            string frase2 = Calculadora.Text(""); // Podemos chamar funções que tem argumentos de tipos diferentes de void desta maneira

            // Frase(); -> caso a função é void podemos trazer o resultado dela desta forma 

            Test.Txt(); //  -> caso a função é void podemos trazer o resultado dela desta forma, unica diferença é que temos que colocar o nome da classe para exibir em outra classe

        }

        private static long Math(char operacao, long i, long x) // Métodos sempre com a primeria letra maiscula
        {
            switch (operacao)
            {
                case '+':
                    return i + x;
                case '-':
                    return i - x;
                case '*':
                    return i * x;
                case '/':
                    return i / x;
                case '%':
                    return i % x;
                default:
                    return 0;
            }
        }

        private static string Text(string frase) // Métodos sempre com a primeria letra maiscula
        {
            frase = "Hello, world";
            Console.WriteLine(frase);
            return frase;
        }


        class Test
        {
            public static void Txt()
            {
                for(var c = 0; c < 1; c--)
                {
                    Console.WriteLine("operação e dois valores: ");
                    string acao = Console.ReadLine(); 
                    long num = long.Parse(Console.ReadLine());
                    long num2 = long.Parse(Console.ReadLine());

                    switch (acao)
                    {
                        case "+":
                            Console.WriteLine(num + num2);
                            break;
                        case "-":
                            Console.WriteLine(num - num2);
                            break;
                        case "*":
                            Console.WriteLine(num * num2);
                            break;
                        case "/":
                            Console.WriteLine(num / num2);
                            break;
                        case "%":
                            Console.WriteLine(num % num2);
                            break;
                        default:
                            Console.WriteLine("Operação Inválida");
                            return;
                    }
                }
            }
        }

    }

}
