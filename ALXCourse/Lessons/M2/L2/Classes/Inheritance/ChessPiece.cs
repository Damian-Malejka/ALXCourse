using ALXCourse.Lessons.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Lessons.M2.L2.Classes.Inheritance
{
    public abstract class ChessPiece //nie ma sensu tworzyc obiektu klasy chessPiece bo nie ma takiej figure
    {
        public ChessColor? Color { get; set; }//to wziete z enumow z kiedys
        public ChessFigureType? Type { get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public bool IsAlive { get; set; }

        public ChessPiece()
        {
            IsAlive = true;
        }

        public void Move()
        {
            Console.WriteLine("Chess Piece is moving...");
        }

        public void Present()
        {
            Console.WriteLine($"Color {Color}");
            Console.WriteLine($"XPosition {XPosition}");
            Console.WriteLine($"YPosition {YPosition}");
            Console.WriteLine($"Type {Type}");
            Console.WriteLine($"IsAlive {IsAlive}");
        }
    }
}
