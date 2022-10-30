using ALXCourse.Lessons.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Lessons.L2
{
    public class ChessFigure
    {
        public ChessFigureType FigureType;
        public ChessColor FigureColor;

        public ChessFigure() { } //można dać tak to znaczy to samo w sensie ze klamry w tej samej linijce bo itak puste jest

        public ChessFigure(ChessFigureType chessFigureType, ChessColor chessColor)
        {
            FigureType = chessFigureType;
            FigureColor = chessColor;
        }

    }
}
