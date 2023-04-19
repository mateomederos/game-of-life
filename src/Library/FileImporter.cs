using System;
using System.IO;

namespace PII_Game_Of_Life
{
    public class FileImporter
    {
      
      public static bool[,] ReadFile()
      {
        string url = "../../assets/board.txt";
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');
        bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
        for (int  y=0; y<contentLines.Length;y++)
        {
            for (int x=0; x<contentLines[y].Length; x++)
            {
                if(contentLines[y][x]=='1')
                {
                    board[x,y]=true;
                }
            }
        }
        return board;
      }
    }
}
// Este código cumple con el principio de SRP porque su única responsabilidad es leer el archivo que contiene la configuración del tablero y convertirlo en una matriz de booleanos que luego se utiliza en la clase Board. Además, no tiene la responsabilidad de almacenar la matriz ni de realizar ninguna operación con ella, lo que se alinea con el principio de SRP. En cuanto al principio de experto, esta clase es experta en la lectura de archivos y la conversión de su contenido en una matriz de booleanos, lo que indica que esta clase tiene un alto nivel de conocimiento y experiencia en esta tarea específica.