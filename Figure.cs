using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    enum Figure
    {
        none,

        whiteKing = 'K',
        whiteQween = 'Q',
        whiteRook = 'R',
        whiteBishop = 'B',
        whiteKnight = 'N',
        whitePawn = 'P',

        blackKing = 'k',
        blackQween = 'q',
        blackRook = 'r',
        blackBishop = 'b',
        blackKnight = 'n',
        blackPawn = 'p',
    }
    static class FigureMethods {
        public static Color GetColor(this Figure figure) 
        {
            if (figure == Figure.none)
                return Color.none;
            return (figure == Figure.whiteKing ||
                    figure == Figure.whiteQween ||
                    figure == Figure.whiteRook ||
                    figure == Figure.whiteBishop ||
                    figure == Figure.whiteKnight ||
                    figure == Figure.whitePawn) ? Color.white : Color.black;
        }
    }

    //enum Figure
    //{
    //    none,

    //    whiteKing = '\u2654',
    //    whiteQween = '\u2655',
    //    whiteRook = '\u2656',
    //    whiteBishop = '\u2657',
    //    whiteKnight = '\u2658',
    //    whitePawn = '\u2659',

    //    blackKing = '\u265a',
    //    blackQween = '\u265b',
    //    blackRook = '\u265c',
    //    blackBishop = '\u265d',
    //    blackKnight = '\u265e',
    //    blackPawn = '\u265f',
    //}
}