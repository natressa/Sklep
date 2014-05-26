using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sklep
{
    public class Product
    {
        public string NAME{get; set;}
        public string SIZE{get; set;}
        public int PRICE{get; set;}

        
    
        public Product(string n, int p, string s)
        {
            this.NAME = n;
            this.PRICE = p;
            this.SIZE = s;
        }
        public Product(){}
    

    }
}
