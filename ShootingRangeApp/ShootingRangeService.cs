using ShootingRangeApp.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRangeApp
{
    public class ShootingRangeService
    {
        public static void Run()
        {
            /*var magnumka = new Magnum(1.2);
            Console.WriteLine(magnumka.GunName);
            Console.WriteLine($"Cena za jeden seryjny strzał: {magnumka.SingleShootPrice}");
            Console.WriteLine($"Liczba strzalów: {magnumka.NumberOfSingleShoots}");
            */
            int selectWeapon;
            Akm47s akm47sgun = new Akm47s(4, 0, 0);
            Glock glockGun = new Glock(2, 0);
            Magnum magnumGun = new Magnum(3, 0, 0);
            Walther waltherGun = new Walther(2.5, 0);
            Xm15 xm15Gun = new Xm15(5, 0, 0);
            
           int numberOfSingleShoots;
           int numberOfMultipleShoots;

            Console.WriteLine("WITAJ W SYSTEMIE OSBŁUGI STRZELNICY\n\n");
            char continueVar;
            do
            {
                Console.WriteLine("\n\t1: AKM47S\n\t2: GLOCK\n\t3: MAGNUM\n\t4: WALTHER\n\t5: XM15");
                Console.Write("\nWybierz rodzaj broni(1-5):");
                selectWeapon = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                switch(selectWeapon)
                {
                    case 1:
                        Console.Write("Wprowadź liczbę pojedyńczych strzałów: ");
                        numberOfSingleShoots = Int32.Parse(Console.ReadLine());
                        Console.Write("\nWprowadź liczbę strzałów seryjnych: ");
                        numberOfMultipleShoots = Int32.Parse(Console.ReadLine());
                        akm47sgun.NumberOfSingleShoots += numberOfSingleShoots;
                        akm47sgun.NumberOfMultipleShoots += numberOfMultipleShoots;
                        break;
                    case 2:
                        Console.Write("Wprowadź liczbę pojedyńczych strzałów: ");
                        numberOfSingleShoots = Int32.Parse(Console.ReadLine());
                        glockGun.NumberOfSingleShoots += numberOfSingleShoots;
                        break;
                    case 3:
                        Console.Write("Wprowadź liczbę pojedyńczych strzałów: ");
                        numberOfSingleShoots = Int32.Parse(Console.ReadLine());
                        Console.Write("\nWprowadź liczbę strzałów seryjnych: ");
                        numberOfMultipleShoots = Int32.Parse(Console.ReadLine());
                        magnumGun.NumberOfSingleShoots += numberOfSingleShoots;
                        magnumGun.NumberOfMultipleShoots += numberOfMultipleShoots;
                        break;
                    case 4:
                        Console.Write("Wprowadź liczbę pojedyńczych strzałów: ");
                        numberOfSingleShoots = Int32.Parse(Console.ReadLine());
                        waltherGun.NumberOfSingleShoots += numberOfSingleShoots;
                        break;
                    case 5:
                        Console.Write("Wprowadź liczbę pojedyńczych strzałów: ");
                        numberOfSingleShoots = Int32.Parse(Console.ReadLine());
                        Console.Write("\nWprowadź liczbę strzałów seryjnych: ");
                        numberOfMultipleShoots = Int32.Parse(Console.ReadLine());
                        xm15Gun.NumberOfSingleShoots += numberOfSingleShoots;
                        xm15Gun.NumberOfMultipleShoots += numberOfMultipleShoots;
                        break;
                    default:
                        Console.WriteLine("Wprowadziłeś błędny numer broni");
                        break;

                        Console.Write("Czy chcesz kontynuować zakupy? [T]tak :");
                        continueVar = Console.ReadKey().KeyChar;
                }
                Console.Write("Czy chcesz kontynuować zakupy? [T]tak :");
                continueVar = Console.ReadKey().KeyChar;
            } while(continueVar=='T' || continueVar == 't');

            var suma = 0;

        }
    }
}
