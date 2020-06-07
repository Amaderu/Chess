using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        public static bool stat=true;
        static void Main(string[] args)
        {
            //Console.WriteLine("шрифт SimSun-ExtB и размер 28");
            //Console.OutputEncoding = Encoding.Unicode;
            Chess chess = new Chess();
            while (true)
            {
            	Console.WriteLine(chess.fen);
            	Print(ChessToAscii(chess));
            	string move = Console.ReadLine();
            	if(move=="") break;
                Console.Clear();
            	chess=chess.Move(move);
            }
            
        }

        static string ChessToAscii(Chess chess)
        {
            string text = "  +-----------------+\n";
        	for (int y = 7;y>=0; y --)
            {
                text += y + 1;
                text += " | ";
                for (int x = 0; x < 8; x++) {
                    text += chess.GetFigureAt(x, y)+" ";
                }
                text += "|\n";
            }
            text += "  +-----------------+\n";
            text += "    a b c d e f g h  \n";
            return text;
        }

        static void Print(string text)
        {
            ConsoleColor oldForeColor = Console.ForegroundColor;
            foreach (char c in text)
            {
                if (c >= 'a' && c <= 'z')
                    Console.ForegroundColor = ConsoleColor.Red;
                else if (c >= 'A' && c <= 'Z')
                    Console.ForegroundColor = ConsoleColor.White;
                else
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(c);
            }
            Console.ForegroundColor = oldForeColor;
            Console.SetCursorPosition(0, 12);
        }

        //public static void BoardColor(string text)
        //{ 
        //    int index = 0; 
        //    ConsoleColor oldBackColor = Console.BackgroundColor;
        //    for (int y = 1; y < 9; y++)
        //    {
        //        for (int x = 4; x < 19; x += 2)
        //        {
        //            if (text[index] >= 'a' && text[index] <= 'z')
        //                Console.ForegroundColor = ConsoleColor.Red;
        //            else if (text[index] >= 'A' && text[index] <= 'Z')
        //                Console.ForegroundColor = ConsoleColor.White;
        //            else
        //                Console.ForegroundColor = ConsoleColor.DarkCyan;
        //            oldBackColor = FlipBoardColor(oldBackColor);
        //            Console.BackgroundColor = oldBackColor;
        //            Console.SetCursorPosition(x, y);
        //            Console.Write(text[index]);
        //            index += 2;
        //        }
        //    }

        //}
        //protected static ConsoleColor FlipBoardColor(ConsoleColor color)
        //{
        //    if (color == ConsoleColor.Black) color = ConsoleColor.White;
        //    else if (color == ConsoleColor.White) color = ConsoleColor.Black;
        //    return color;
        //}
    }
}
