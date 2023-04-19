using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class DrawTable
    {
            public static void DrawBoard(bool[,] board)
            { 
                bool[,] gameBoard = board;
                int width = board.GetLength(0);
                int height = board.GetLength(0);

                while (true)
                {
                    Console.Clear();
                    StringBuilder s = new StringBuilder();
                    for (int y = 0; y<height;y++)
                    {
                        for (int x = 0; x<width; x++)
                        {
                            if(gameBoard[x,y])
                            {
                                s.Append("|X|");
                            }
                            else
                            {
                                s.Append("___");
                            }
                        }
                        s.Append("\n");
                    }
                    Console.WriteLine(s.ToString());
                    gameBoard = Logic.GameLogic(gameBoard);
                    Thread.Sleep(300);
                }
            }
    }
}// Esta clase cumple con el principio SRP, ya que tiene una única responsabilidad: dibujar el tablero del juego en la consola. También sigue el principio Expert, ya que tiene acceso a la información del tablero a través del parámetro que recibe. La clase no tiene ninguna razón para cambiar más allá de la forma en que se dibuja el tablero o cómo se accede a la información del mismo.
