using ALXCourse.Lessons.L2.Enums;
using ALXCourse.Lessons.M2.L2.Classes.Inheritance;

namespace ALXCourse.Lessons.M2.L2
{
    public class L2Inheritance
    {
        public static void Run()
        {
            King king = new King();  // jak bysmy napisali King king = new King() jak bysmy zamiast pierwszego King dali ChessPiece to bysmy mieli np metode move z chesspiece albo np dla krola by nie było czy nie został zszachowany
            
            king.XPosition = 1;
            king.YPosition = 1;
            king.Color = ChessColor.WHITE;
            king.Move();
            king.Present();
            ConfirmLiveness(king);

            Queen queen = new Queen();
            queen.Move();
            queen.XPosition = 1;
            queen.YPosition = 1;
            queen.Color = ChessColor.WHITE;
            queen.Present();
            ConfirmLiveness(queen);

            Knight knight = new Knight();
            knight.Move();
            knight.XPosition = 1;
            knight.YPosition = 1;
            knight.Color = ChessColor.WHITE;
            knight.Present();
            ConfirmLiveness(knight);

            Bishop bishop = new Bishop();
            bishop.Move();
            bishop.XPosition = 1;
            bishop.YPosition = 1;
            bishop.Color = ChessColor.WHITE;
            bishop.Present();
            ConfirmLiveness(bishop);

            Pawn pawn = new Pawn();
            pawn.Move();
            pawn.XPosition = 1;
            pawn.YPosition = 1;
            pawn.Color = ChessColor.WHITE;
            pawn.Present();
            ConfirmLiveness(pawn);

            Rook rook = new Rook();
            rook.Move();
            rook.XPosition = 1;
            rook.YPosition = 1;
            rook.Color = ChessColor.WHITE;
            rook.Present();
            ConfirmLiveness(rook);

        }
        public static void ConfirmLiveness(ChessPiece chessPiece)//z racji ze mamy klase bazowa to mozemy uzywac tego uniwersalnie dla wszystkich klas
        {
            if(chessPiece.IsAlive)
            {
                Console.WriteLine("The piece is alive");
            }
            else
            {
                Console.WriteLine("The piece is not alive");
            }
        }
       

            
    }
}
