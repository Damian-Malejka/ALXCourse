namespace ALXCourse.Lessons.M2.L2.Interfaces
{
    ///INTERFEJSY zaczynamy od literki dużej literki i
    public interface IHello//takie funkcjonalności chcemy żeby ta nasza klasa miała  
    {
        void SayHello();///INTERFEJSY NIE MOWIA JAK FUNKCJA BEDZIE DZIALAC, MOWIA TYLKO ZE TAKIE BEDA
        void SayHello(string name);
        void SayGoodMorning();
        void SayGoodMorning(string name);
    }
}
