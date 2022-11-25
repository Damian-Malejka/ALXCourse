using ShootingRangeApp.Enums;
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
            ShowRecipt(akm47sgun, glockGun, magnumGun, waltherGun, xm15Gun);

        }

        public static void ShowRecipt(Akm47s akm47sgun, Glock glockGun, Magnum magnumGun, Walther waltherGun, Xm15 xm15Gun)
        {
            Console.Clear();
            Console.WriteLine("/////////////PARAGON/////////////");
            double suma = 0.0;
            if((akm47sgun.NumberOfSingleShoots != 0) || (akm47sgun.NumberOfMultipleShoots!=0))
            {
                Console.WriteLine($"\tOpłata za {GunsTypeNames.AKM47S} ");
                Console.WriteLine($"\t\tLiczba pojedyńczych strzałów: {akm47sgun.NumberOfSingleShoots} x {akm47sgun.SingleShootPrice}zł = {(akm47sgun.NumberOfSingleShoots * akm47sgun.SingleShootPrice)}");
                Console.WriteLine($"\t\tLiczba seryjnych strzałów: {akm47sgun.NumberOfMultipleShoots} x {akm47sgun.MultipleShootPrice}zł = {(akm47sgun.NumberOfMultipleShoots * akm47sgun.MultipleShootPrice)}");
                suma += (akm47sgun.NumberOfSingleShoots * akm47sgun.SingleShootPrice) + (akm47sgun.NumberOfMultipleShoots * akm47sgun.MultipleShootPrice);
            }
            if (glockGun.NumberOfSingleShoots != 0)
            {
                Console.WriteLine($"\tOpłata za {GunsTypeNames.GLOCK} ");
                Console.WriteLine($"\t\tLiczba pojedyńczych strzałów: {glockGun.NumberOfSingleShoots} x {glockGun.SingleShootPrice}zł = {(glockGun.NumberOfSingleShoots * glockGun.SingleShootPrice)}");
                suma += (glockGun.NumberOfSingleShoots * glockGun.SingleShootPrice);
            }
            if ((magnumGun.NumberOfSingleShoots != 0) || (magnumGun.NumberOfMultipleShoots != 0))
            {
                Console.WriteLine($"\tOpłata za {GunsTypeNames.MAGNUM} ");
                Console.WriteLine($"\t\tLiczba pojedyńczych strzałów: {magnumGun.NumberOfSingleShoots} x {magnumGun.SingleShootPrice}zł = {(magnumGun.NumberOfSingleShoots * magnumGun.SingleShootPrice)}");
                Console.WriteLine($"\t\tLiczba seryjnych strzałów: {magnumGun.NumberOfMultipleShoots} x {magnumGun.MultipleShootPrice}zł = {(magnumGun.NumberOfMultipleShoots * magnumGun.MultipleShootPrice)}");
                suma += (magnumGun.NumberOfSingleShoots * magnumGun.SingleShootPrice) + (magnumGun.NumberOfMultipleShoots * magnumGun.MultipleShootPrice);
            }
            if (waltherGun.NumberOfSingleShoots != 0)
            {
                Console.WriteLine($"\tOpłata za {GunsTypeNames.WALTHER} ");
                Console.WriteLine($"\t\tLiczba pojedyńczych strzałów: {waltherGun.NumberOfSingleShoots} x {waltherGun.SingleShootPrice}zł = {(waltherGun.NumberOfSingleShoots * waltherGun.SingleShootPrice)}");
                suma += (waltherGun.NumberOfSingleShoots * waltherGun.SingleShootPrice);
            }
            if ((xm15Gun.NumberOfSingleShoots != 0) || (xm15Gun.NumberOfMultipleShoots != 0))
            {
                Console.WriteLine($"\tOpłata za {GunsTypeNames.XM15} ");
                Console.WriteLine($"\t\tLiczba pojedyńczych strzałów: {xm15Gun.NumberOfSingleShoots} x {xm15Gun.SingleShootPrice}zł = {(xm15Gun.NumberOfSingleShoots * xm15Gun.SingleShootPrice)}");
                Console.WriteLine($"\t\tLiczba seryjnych strzałów: {xm15Gun.NumberOfMultipleShoots} x {xm15Gun.MultipleShootPrice}zł = {(xm15Gun.NumberOfMultipleShoots * xm15Gun.MultipleShootPrice)}");
                suma += (xm15Gun.NumberOfSingleShoots * xm15Gun.SingleShootPrice) + (xm15Gun.NumberOfMultipleShoots * xm15Gun.MultipleShootPrice);
            }

            Console.WriteLine("KOSZT CAŁKOWITY: " + suma + "zł");
            Console.WriteLine("\n\nDziękujemy i zapraszamy ponownie");
        }
    }
}
