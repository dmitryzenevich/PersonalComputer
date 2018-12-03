using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalComputer
{
    class ComputerShop
    {
        public List<IProduct> Products { get; private set; }
        public ComputerShop(List<IProduct> products)
        {
            this.Products = products;
        }
        /// <summary> Продать продукт покупателю. </summary>
        /// <param name="product"> Продукт. </param>
        /// <param name="customer"> Покупатель. </param>
        public bool SaleProduct(IProduct product, Customer customer)
        {
            // Если у покупателя хватает денег...
            if (product.Price < customer.Balance)
            {
                // то взять у него деньги
                customer.ReduceBalance(product.Price);
                // и продать продукт.
                customer.Products.Add(product);
                return true;
            }
            Console.WriteLine("У покупателя не хватает денег.");
            return false; ;
        }
    }
}


