using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    public class Cart
    {
        string result;
        IList<Product> productsList = new List<Product>();
        public void Add(Product prd)
        {
            productsList.Add(prd);
        }
        public string SumUp()
        {
            int count=productsList.Count;
            int price = 0;

            for(int i=0;i<count;i++)
            {
                price += productsList[i].PRICE;

            }
            string list = "[[W BUDOWIE]]";
            result = ("Zakupiono ["+count+"] produktów: "+list+"\n Do zaplaty: "+price);
            return result;
        }

    }
}
