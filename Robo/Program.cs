using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador1 = 0;
            int contador2 = 0;

            Console.WriteLine("- ROBÔ 1- \n");

            Console.WriteLine("Informe a posição inicial X: ");
            int inicialX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a posição inicial Y: ");
            int inicialY = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a posição de X: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a posição de Y: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a direção: ");
            char direcao = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.WriteLine("Informe os comandos: ");
            string movimentos = Console.ReadLine().ToUpper();

            int[] X = new int[inicialX];
            int[] Y = new int[inicialY];

            contador1 = numero1;
            contador2 = numero2;

            //Direção
            if (direcao != 'N' && direcao != 'O' && direcao != 'L' && direcao != 'S')
            {
                Console.WriteLine("Não corresponde a nenhuma direção!");
            }

            foreach (char movi in movimentos)
            {
                if (movi == 'E')
                {
                    switch (direcao)
                    {
                        case 'L':
                            direcao = 'N';
                            break;

                        case 'N':
                            direcao = 'O';
                            break;

                        case 'O':
                            direcao = 'S';
                            break;

                        case 'S':
                            direcao = 'L';
                            break;
                    }
                }
                else if (movi == 'D')
                {
                    switch (direcao)
                    {
                        case 'N':
                            direcao = 'L';
                            break;
                        case 'L':
                            direcao = 'S';
                            break;

                        case 'S':
                            direcao = 'O';
                            break;

                        case 'O':
                            direcao = 'N';
                            break;
                    }
                }
                else if (movi == 'M')
                {
                    switch (direcao)
                    {
                        case 'N':
                            if (contador2 < inicialY)
                            {
                                contador2++;
                            }
                            break;

                        case 'L':
                            if (contador1 < inicialX)
                            {
                                contador1++;
                            }
                            break;

                        case 'O':
                            if (contador1 > 0)
                            {
                                contador1--;
                            }
                            break;

                        case 'S':
                            if (contador2 > 0)
                            {
                                contador2--;
                            }
                            break;
                    }
                }
            }
            Console.Clear();
            Console.WriteLine($"{contador1} {contador2} {direcao}");

            int contador1R2 = 0;
            int contador2R2 = 0;

            Console.WriteLine("\n- ROBÔ 2- \n");

            Console.WriteLine("Informe a posição de X: ");
            int numero1R2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a posição de Y: ");
            int numero2R2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a direção: ");
            char direcaoR2 = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.WriteLine("Informe os comandos: ");
            string movimentosR2 = Console.ReadLine().ToUpper();

            contador1R2 = numero1R2;
            contador2R2 = numero2R2;

            //Direção
            if (direcaoR2 != 'N' && direcaoR2 != 'O' && direcaoR2 != 'L' && direcaoR2 != 'S')
            {
                Console.WriteLine("Não corresponde a nenhuma direção!");
            }

            foreach (char movi2 in movimentosR2)
            {
                if (movi2 == 'E')
                {
                    switch (direcaoR2)
                    {
                        case 'L':
                            direcaoR2 = 'N';
                            break;

                        case 'N':
                            direcaoR2 = 'O';
                            break;

                        case 'O':
                            direcaoR2 = 'S';
                            break;

                        case 'S':
                            direcaoR2 = 'L';
                            break;
                    }
                }
                else if (movi2 == 'D')
                {
                    switch (direcaoR2)
                    {
                        case 'N':
                            direcaoR2 = 'L';
                            break;
                        case 'L':
                            direcaoR2 = 'S';
                            break;

                        case 'S':
                            direcaoR2 = 'O';
                            break;

                        case 'O':
                            direcaoR2 = 'N';
                            break;
                    }
                }
                else if (movi2 == 'M')
                {
                    switch (direcaoR2)
                    {
                        case 'N':
                            if (contador2R2 < inicialY)
                            {
                                contador2R2++;
                            }
                            break;

                        case 'L':
                            if (contador1R2 < inicialX)
                            {
                                contador1R2++;
                            }
                            break;

                        case 'O':
                            if (contador1R2 > 0)
                            {
                                contador1R2--;
                            }
                            break;

                        case 'S':
                            if (contador2R2 > 0)
                            {
                                contador2R2--;
                            }
                            break;
                    }
                }
            }
            Console.Clear();

            Console.WriteLine($"{contador1R2} {contador2R2} {direcaoR2}");
            Console.ReadKey();
        }
    }
}
