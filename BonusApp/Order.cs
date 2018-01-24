using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Order
    {
        public List<Product> ProductList = new List<Product>();

        public DG_BonusProvider Bonus { get; set; }
        public void AddProduct(Product p)
        {
            ProductList.Add(p);
        }
        public double GetValueOfProducts()
        {
            double resultat = 0.0;
            foreach (Product p in ProductList)
            {
                resultat += p.Value;
            }
            return resultat;
        }
        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }
        public double GetTotalPrice()
        {
            double bonus = GetBonus();
            double GetValue = GetValueOfProducts();
            return GetValue + bonus;
        }
    }
}
