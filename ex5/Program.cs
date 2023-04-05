using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ex;

            Console.WriteLine("escolha um exercicio");
            ex = int.Parse(Console.ReadLine());

            switch (ex)
            {
                case 1:
                    Console.Write("Digite um número inteiro: ");
                    int num = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= num; i++)
                    {
                        Console.Write(i + ", ");
                    }
                    break;

                //------------------------------------------------------------------

                case 2:
                    Console.Write("Digite um número inteiro: ");
                    int numC2 = int.Parse(Console.ReadLine());

                    for (int i = 2; i <= numC2; i += 2)
                    {

                        Console.Write(i + ", ");
                    }
                    break;

                //-----------------------------------------------------------

                case 3:

                    Console.Write("Digite um número inteiro menor que 1000: ");
                    int num3 = int.Parse(Console.ReadLine());

                    if (num3 < 1000)
                    {
                        for (int i = 1000; i >= num3; i--)
                        {
                            if (num3 % 2 == 0)
                                Console.Write(i + ", ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("O número digitado é maior ou igual a 1000.");
                    }
                    break;

                //--------------------------------------------------------

                case 4:
                    double soma = 0, numC4;

                    for (; soma < 200; )
                    {
                        Console.Write("Digite um número inteiro: ");
                        numC4 = double.Parse(Console.ReadLine());

                        if (numC4 > 0)
                        {
                            soma += numC4;
                            Console.WriteLine("Número positivo! Soma atual: " + soma);
                        }
                        else
                        {
                            Console.WriteLine("Número negativo ou zero.");
                        }
                    }
                    break;

                //--------------------------------------------------------------------------------------------------

                case 5:

                    int numC5;

                    Console.Write("Digite um número inteiro: ");
                    numC5 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Divisores de " + numC5 + ":");

                    for (int i = 1; i <= numC5; i++)
                    {
                        if (numC5 % i == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;

                //----------------------------------------------------------------------------------------------

                case 6:


                    int maior = int.MinValue;
                    int menor = int.MaxValue;

                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write("Digite o " + i + "º número: ");
                        int numero6 = int.Parse(Console.ReadLine());

                        if (numero6 > maior)
                        {
                            maior = numero6;
                        }

                        if (numero6 < menor)
                        {
                            menor = numero6;
                        }
                    }

                    Console.WriteLine("O maior número digitado foi: " + maior);
                    Console.WriteLine("O menor número digitado foi: " + menor);
                    Console.ReadKey();
                    break;

                //--------------------------------------------------------------------------------------------------------------------------------

                case 7:
                    int somaPares = 0;
                    int somaImpares = 0;

                    Console.Write("Digite um número (0 para sair): ");
                    int numero = int.Parse(Console.ReadLine());
                    if (numero % 2 == 0)
                    {
                        somaPares += numero;
                    }
                    else
                    {
                        somaImpares += numero;
                    }
            

                    Console.WriteLine("A soma dos números pares é: " + somaPares);
                    Console.WriteLine("A soma dos números ímpares é: " + somaImpares);
                    Console.ReadKey();

                    break;
            }
        }
    }


}
 
    

