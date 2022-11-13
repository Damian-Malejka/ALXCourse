using ALXCourse.Lessons.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Lessons.M2.L2.Classes.Inheritance
{
    public class Rook:ChessPiece
    {
        public Rook():base() //te base jest jednak domyslnie
        {
            Type = ChessFigureType.ROOK;
        }
        public void Move()//tutaj zjawisko override bo to co robi Move tutaj rozni sie od tego z klasy ChessPiece
        {
            Console.WriteLine("The Rook is moving...");
        }
    }
}
