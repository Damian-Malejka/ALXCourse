using ALXCourse.Lessons.L2.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Lessons.M2.L2.Classes.Inheritance
{
    public class Bishop : ChessPiece
    {//czyli wywolujac konstruktor Bishop to uruchomi sie tez od razu konstruktor od ChessPiece
        public Bishop() : base() //base to constructor klasy chessPiece tam było isAlive ze najpierw tworzymy zywy pionk a pozniej ustawiamy typ
        {//te base jest jednak domyslnie
            Type = ChessFigureType.BISHOP;
        }
        public void Move()//tutaj zjawisko override bo to co robi Move tutaj rozni sie od tego z klasy ChessPiece
        {
            Console.WriteLine("The Bishop is moving...");
        }
    }
}
