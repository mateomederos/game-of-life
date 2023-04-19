using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {   
             bool[,] boardFile = FileImporter.ReadFile();
            Board board = new Board(boardFile);
            DrawTable.DrawBoard(board.gameBoard);
        }
    }
}

// El código cumple con el principio SRP ya que la clase Program tiene una única responsabilidad: ejecutar el juego de la vida. Además, cumple con el principio Expert, ya que utiliza las clases FileImporter, Board y DrawTable para obtener los datos del archivo, crear el tablero y mostrar la tabla en la consola, respectivamente, en lugar de manipular directamente los datos y la lógica del juego. Esto mejora el entendimiento y la manipulación del programa.