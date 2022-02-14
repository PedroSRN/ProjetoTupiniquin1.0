using System;

namespace robo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int posicaoX , posicaoY , posicaoX2, posicaoY2;
            char direcao, direcao2; 
            

            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" --- Robô Tupiniquin 1.0 --- [-_-]/");
            Console.WriteLine("-----------------------------------");
            
            Console.Write("Digite a posicação X inicial do robô 1: ");
            posicaoX = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a posição Y inicial do robo 1: ");
            posicaoY = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a direção Inicial do robô 1 (N, S, L, O): ");
            direcao = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Digite o comando que o robô terá que fazer (M = mover, E = virar em 90° a esquerda, D = virar em 90° a direita ): ");
            string comando = Console.ReadLine();
            char[] instrucoes = comando.ToCharArray();

            //---------------------------------------------------ROBO 2--------------------------------------------------------------------
            Console.WriteLine("");
            Console.Write("Digite a posicação X inicial do robô 2: ");
            posicaoX2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a posição Y inicial do robo 2: ");
            posicaoY2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a direção Inicial do robô 2 (N, S, L, O): ");
            direcao2 = Convert.ToChar(Console.ReadLine());

            Console.Write("Digite o comando que o robô 2 terá que fazer (M = mover, E = virar em 90° a esquerda, D = virar em 90° a direita ): ");

            string comando2 = Console.ReadLine();
            char[] instrucoes2 = comando2.ToCharArray();

            
                for (int i = 0; i < instrucoes.Length; i++)
                {
                    if (instrucoes[i] == 'M') // Move o robo 
                    {
                        if (direcao == 'N')
                        {
                            posicaoY = posicaoY + 1;
                        }

                        else if (direcao == 'S')
                        {
                            posicaoY = posicaoY - 1;
                        }
                        
                        else if (direcao == 'O')
                        {
                            posicaoX = posicaoX - 1;
                        }

                        else if (direcao == 'L')
                        {
                            posicaoX = posicaoX + 1;
                        }
                    }

                    if (instrucoes[i] == 'E')  //virar a Esquerda
                    {
                        if (direcao == 'N')
                        {
                            direcao = 'O';
                        }

                        else if (direcao == 'S')
                        {
                            direcao =  'L';
                        }

                        else if (direcao == 'O')
                        {
                             direcao = 'S';
                        }

                        else if (direcao == 'L')
                        {
                            direcao = 'N';
                        }

                    }

                    if (instrucoes[i] == 'D') //virar a Direita
                    {
                        if (direcao == 'N')
                        {
                            direcao = 'L';
                        }

                        else if (direcao == 'S')
                        {
                            direcao = 'O';
                        }

                        else if (direcao == 'O')
                        {
                            direcao = 'N';
                        }

                        else if (direcao == 'L')
                        {
                            direcao = 'S';
                        }

                    }


                }

// MOVIMENTAÇÃO ROBÔ 2
            for (int i = 0; i < instrucoes2.Length; i++)
            {
                if (instrucoes2[i] == 'M') // Move o robo 
                {
                    if (direcao2 == 'N')
                    {
                        posicaoY2 = posicaoY2 + 1;
                    }

                    else if (direcao2 == 'S')
                    {
                        posicaoY2 = posicaoY2 - 1;
                    }

                    else if (direcao2 == 'O')
                    {
                        posicaoX2 = posicaoX2 - 1;
                    }

                    else if (direcao2 == 'L')
                    {
                        posicaoX2 = posicaoX2 + 1;
                    }
                }

                if (instrucoes2[i] == 'E')  //virar a Esquerda
                {
                    if (direcao2 == 'N')
                    {
                        direcao2 = 'O';
                    }

                    else if (direcao2 == 'S')
                    {
                        direcao2 = 'L';
                    }

                    else if (direcao2 == 'O')
                    {
                        direcao2 = 'S';
                    }

                    else if (direcao2 == 'L')
                    {
                        direcao2 = 'N';
                    }

                }

                if (instrucoes2[i] == 'D') //virar a Direita
                {
                    if (direcao2 == 'N')
                    {
                        direcao2 = 'L';
                    }

                    else if (direcao2 == 'S')
                    {
                        direcao2 = 'O';
                    }

                    else if (direcao2 == 'O')
                    {
                        direcao2 = 'N';
                    }

                    else if (direcao2 == 'L')
                    {
                        direcao2 = 'S';
                    }

                }


            }
            Console.WriteLine("");
            Console.WriteLine("Posições finais dos Robôs");
            Console.WriteLine("");
            Console.WriteLine("posição final do robo 1 é: " + posicaoX + "," + posicaoY + " " + direcao);
            Console.WriteLine("");
            Console.WriteLine("posição final do robo 2 é: " + posicaoX2 + "," + posicaoY2 + " " + direcao2);
            Console.ReadLine();
            
            
        }
    }
}
