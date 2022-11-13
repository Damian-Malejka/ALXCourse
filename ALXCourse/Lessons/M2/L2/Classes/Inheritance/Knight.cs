using ALXCourse.Lessons.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Lessons.M2.L2.Classes.Inheritance
{
    public class Knight:ChessPiece
    {
        public Knight() : base()//te base jest jednak domyslnie
        {
            Type = ChessFigureType.KNIGHT;
        }
        public void Move()//tutaj zjawisko override bo to co robi Move tutaj rozni sie od tego z klasy ChessPiece
        {
            Console.WriteLine("The Knight is moving...");
        }
    }
}
