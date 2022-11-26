using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal NettoPrice { get; set; } //decimal 25 po przecinku double mniejsza dokładność
        public decimal Bruttoprice { get; set; }
        public bool IsFood { get; set; }

        public Product(string productName,decimal nettoPrice, bool isFood)
        {
            ProductName = productName;
            NettoPrice = nettoPrice;
            IsFood = isFood;
            if(IsFood)
            {
                Bruttoprice = NettoPrice + NettoPrice * 0.05M;//M bo decimal
            }
            else
            {
                Bruttoprice = NettoPrice + NettoPrice * 0.23M;
            }
        }

    }
}
