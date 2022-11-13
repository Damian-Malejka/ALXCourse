using ALXCourse.Lessons.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Lessons.M2.L2.Classes.Inheritance
{
    public class King : ChessPiece
    {
        public bool Checked { get; set; }
        public King() : base() //najpierw korzystamy z kostruktora klasy ChessPiece tam jest isAlive i to tworzymy dla kazdej klasy pionkow
        {
            Checked = false;//czy król został zaszachowany
            Type = ChessFigureType.KING;
        }

        public void Move()//tutaj zjawisko override bo to co robi Move tutaj rozni sie od tego z klasy ChessPiece
        {
            Console.WriteLine("The King is moving...");
        }
    }
}
