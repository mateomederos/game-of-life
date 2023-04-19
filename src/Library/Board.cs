using System;
using System.Text;

namespace PII_Game_Of_Life
{
    public class Board
    {
       
        public bool[,] gameBoard {get;}
        public int boardWidth {get;}
        public int boardHeight {get;}

        public Board(bool[,] board)
        {
            this.gameBoard = board;
            this.boardWidth = board.GetLength(0);
            this.boardHeight = board.GetLength(1);
        }
        
        
        
    }
}

// Este código cumple con los principios Expert y SRP porque la clase Board tiene la responsabilidad de almacenar y proporcionar información sobre el estado actual del tablero de juego. La clase tiene una única razón para cambiar: si hay un cambio en la forma en que se almacena o se accede a la información del tablero. Además, la clase Board tiene toda la información necesaria para cumplir su responsabilidad de almacenar el estado del tablero, lo que hace que cumpla con el principio de Expert. Al mantener una responsabilidad clara y bien definida, este código es más fácil de mantener, escalar y modificar en el futuro.