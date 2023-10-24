using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CALCULADORA
            Console.WriteLine(@"Diga qual operação deseja Realizar:


                1 - Somar
                2 - Subtrair
                3 - Multiplicar
                4 - Dividir
                5 - Resto da Divisão
                6 - Potência
                7 - Fatorar um número
                8 - Fatorial de um número
                0 - Sair

            ");
            Console.Write("Digite sua Operação: ");
            int operacao = Convert.ToInt32(Console.ReadLine());

            switch (operacao)
            {
                case 1:

                    Somar();
                    break;
                case 2:
                    Subtrair();
                    break;
                case 3:
                    Multiplicar();
                    break;
                case 4:
                    Dividir();
                    break;
                case 5:
                    Modulo();
                    break;
                case 6:
                    Potencia();
                    break;
                case 7:
                    Fatorar();
                    break;
                case 8:
                    Fatorial();
                    break;

                default:
                    Sair();
                    break;
            }

            void Somar()
            {
                //FAÇA A SOMA ATÉ QUE CLIQUE EM ESC
                bool somar = true;
                double valores;
                double soma = 0;
                do
                {
                    //PEGAR OUTROS NUMEROS
                    Console.Write("\nDigite o numero a ser somado: ");
                    valores = Convert.ToDouble(Console.ReadLine());

                    //LOGICA PARA SOMAR OS VALORES DO ARRAY
                    soma += valores;

                    //PARAR O CONTTADO COM SOMAR == FALSE
                    Console.WriteLine("\nESC - sair / ENTER - continuar");
                    ConsoleKey keyExit = Console.ReadKey().Key;

                    if (keyExit == ConsoleKey.Escape)
                    {
                        somar = false;
                        //mostre o resultado da soma

                        Console.WriteLine("A Soma dos valores: " + soma);
                        Console.WriteLine("Aplicação de soma finalizada!");
                        //termine a aplicacao
                        Console.ReadLine();
                    }
                } while (somar);
            }
            void Subtrair()
            {
                double valorFinal, valorInicial;

                Console.Write("\nDigite quanto voce tem: ");
                valorInicial = Convert.ToDouble(Console.ReadLine());


                Console.Write("\nDigite o numero a ser subtraido: ");
                valorFinal = Convert.ToDouble(Console.ReadLine());

                valorInicial = valorInicial - valorFinal;

                //mostre o resultado da soma
                Console.WriteLine("A subtracao dos valores: " + valorInicial);
                Console.WriteLine("Aplicação de subtracao finalizada!");
                //termine a aplicacao
                Console.ReadLine();
            }

            void Multiplicar()
            {
                bool multiplicar = true;
                double valores;
                double multiplicacao = 1;
                do
                {
                    //PEGAR OUTROS NUMEROS
                    Console.Write("\nDigite o numero a ser multiplicado: ");
                    valores = Convert.ToDouble(Console.ReadLine());

                    //LOGICA PARA SOMAR OS VALORES DO ARRAY
                    multiplicacao *= valores;

                    //PARAR O CONTTADO COM SOMAR == FALSE
                    Console.WriteLine("\nESC - sair / ENTER - continuar");
                    ConsoleKey keyExit = Console.ReadKey().Key;

                    if (keyExit == ConsoleKey.Escape)
                    {
                        multiplicar = false;
                        //mostre o resultado da soma

                        Console.WriteLine("A Soma dos valores: " + multiplicacao);
                        Console.WriteLine("Aplicação de multiplicacao finalizada!");
                        //termine a aplicacao
                        Console.ReadLine();
                    }
                } while (multiplicar);
            }

            void Dividir()
            {
                double consequente, antecedente;

                Console.Write("\nDigite o antecendente: ");
                antecedente = Convert.ToDouble(Console.ReadLine());


                Console.Write("\nDigite o consequente: ");
                consequente = Convert.ToDouble(Console.ReadLine());

                antecedente /= consequente;

                //mostre o resultado da soma
                Console.WriteLine("A divisao dos valores: " + antecedente);
                Console.WriteLine("Aplicação de divisao finalizada!");
                //termine a aplicacao
                Console.ReadLine();
            }
            void Modulo()
            {
                double consequente, antecedente;

                Console.Write("\nDigite o antecendente: ");
                antecedente = Convert.ToDouble(Console.ReadLine());


                Console.Write("\nDigite o consequente: ");
                consequente = Convert.ToDouble(Console.ReadLine());

                antecedente %= (int)consequente;

                //mostre o resultado da soma
                Console.WriteLine("O resto da divisao: " + antecedente);
                Console.WriteLine("Aplicação de resto da divisao finalizada!");
                //termine a aplicacao
                Console.ReadLine();
            }
            void Potencia()
            {
                double basePot, expoente;

                Console.Write("\nDigite a base: ");
                basePot = Convert.ToDouble(Console.ReadLine());


                Console.Write("\nDigite o expoente: ");
                expoente = Convert.ToDouble(Console.ReadLine());


                //mostre o resultado da soma
                Console.WriteLine("A potencia e: " + Math.Pow(basePot, expoente));
                Console.WriteLine("Aplicação de potencia finalizada!");
                //termine a aplicacao
                Console.ReadLine();
            }
            void Fatorar()
            {
                int numero;
                int[] numberPrimes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43 };

                Console.Write("\nDigite o numero a ser fatorado: ");
                numero = Convert.ToInt32(Console.ReadLine());

                //LOGICA PARA FATORAR E MOSTRAR O NUMERO


                int FatorarNumero(int x)
                {
                    int numberParameter = 0;
                    for (int i = 0; i < numberPrimes.Length; i++)
                    {
                        if (x % numberPrimes[i] == 0)//x/y restar 0, entao e divisivel por ele como inteiro primo
                        {
                            numberParameter = numberPrimes[i];
                            numero /= numberParameter;
                            break;
                            //return x / numberPrimes[i];
                        }
                        else if (x == 1) return 1;
                        else
                        {
                            continue;
                        }
                    }

                    return numberParameter;
                }

                do
                {
                    Console.WriteLine($"{numero} | {FatorarNumero(numero)}");
                    if (numero == 1)
                    {
                        Console.WriteLine($"{numero} | {FatorarNumero(numero)}");
                    }

                } while (numero != 1);

                //termine a aplicacao
                Console.ReadLine();
            }

            void Fatorial()
            {
                Console.Write("Digite qual numero se quer o fatorial: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("O fatorial e: " + CalcularFatorial(numero));

                int CalcularFatorial(int x)
                {
                    if (x <= 1) return 1;
                    else return x * CalcularFatorial(x - 1);
                }
                
                //n lembra de codigo robert
            }
            void Sair() { }

            Console.WriteLine("Muito obrigado por usar a calculadora!");
            #endregion
        }
    }
}
