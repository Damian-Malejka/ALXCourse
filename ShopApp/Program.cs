using ShopApp.Models;
using System.Collections.Generic;

var products= new List<Product>();
products.Add(new Product("Mleko", 3.50M, true));
products.Add(new Product("Chleb", 5.0M, true));
products.Add(new Product("Komputer", 5000, false));
products.Add(new Product("Kawa", 35M, true));
products.Add(new Product("Bułka", 5M, true));

var shoppingCart = new ShoppingCart(products);

string productName;
string response;
bool brakProduktu;

Console.WriteLine("Dzień Dobry, witaj w aplikacji sklepu");

do
{
    brakProduktu = true;
    Console.Write("Użytkowniku wprowadź nazwę produktu: ");
    productName = Console.ReadLine();
    for(var i=0;i<products.Count; i++)
    {
        if(products[i].ProductName==productName)
        {
            shoppingCart.Products.Add(products[i]);
            brakProduktu = false;
        }
    }
    if(brakProduktu==true)
    {
        Console.WriteLine("Brak produktu w sklepie!");
    }
    Console.WriteLine();

    Console.Write("Użytkowniku czy chcesz kontynuować?[T][N]: ");
    response = Console.ReadLine();
 
} while(response == "T" || response == "t");

Console.Clear();
Console.WriteLine($"Liczba produktów: {shoppingCart.Products.Count()}");//Count metoda obiektu list liczaca liste elementów, ale jest ten Własciwość Count która się sama aktualizuje
foreach (Product item in shoppingCart.Products)
{
    Console.WriteLine("Nazwa produktu: " + item.ProductName+ ", cena netto: "+item.NettoPrice + ", cena brutto: " + item.Bruttoprice);
}

Console.WriteLine($"Całkowita cena netto: {shoppingCart.GetNettoPrice()}");
Console.WriteLine($"Całkowita cena brutto: {shoppingCart.GetBruttoPrice()}");

