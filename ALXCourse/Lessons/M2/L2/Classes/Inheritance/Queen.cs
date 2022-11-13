using ALXCourse.Lessons.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Lessons.M2.L2.Classes.Inheritance
{
    public class Queen : ChessPiece //tutaj po dwukropku klasa wiec mamy doczynienia z dziedziczeniem
    {
        public Queen():base()//te base jest jednak domyslnie
        {
            Type = ChessFigureType.QUEEN;
        }
        public  void Move()//tutaj zjawisko override bo to co robi Move tutaj rozni sie od tego z klasy ChessPiece
        {
            Console.WriteLine("The Queen is moving...");
        }//klasa Queen dziedziczy property po ChessPiece i metode Move tez ale tutaj stosujemy override
    }
}
