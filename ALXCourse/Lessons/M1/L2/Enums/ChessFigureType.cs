using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Lessons.L2.Enums
{
    public enum ChessFigureType  //to są zdefiniowane przypadki
    {
        PAWN, //PIONEK              W TYPIE WYLICZENIOWYM ENUM PISZEMY WIELKIEMI LITERAMI //0
        BISHOP, //goniec//1
        KNIGHT, //KONIK//2
        ROOK, //wieża//3
        QUEEN,//królowa//4
        KING//król//5                  ENUM TO TABLICA TAKICH WARIANTOW wszystkie przypadki NIE MA WIECEJ PRZYPADKÓW
    }
}
