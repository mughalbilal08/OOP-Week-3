using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorOfClassAndConstructor.BL
{
    class product
    {
        public string name;
        public string category;
        public int price;
        public int quantityS;
        public int quantityM;

        public product()
        {

        }
        public product(product p)
        {
            name = p.name;
            category = p.category;
            price = p.price;
            quantityS = p.quantityS;
            quantityM = p.quantityM;
        }
     
        public string highest(List<product> p)
        {
            int highest = 0;
            string name = "";
            for (int x = 0; x < p.Count; x++)
            {
                if (highest < p[x].price)
                {
                    highest = p[x].price;
                    name = p[x].name;
                }
            }
            return name;
        }
        public float taxPrice(product s)
        {
            float tax=0;
            
                if (s.category == "grocery")
                {
                    tax = s.price * 10 / 100;
                }
                if (s.category == "fruits")
                {
                    tax = (s.price * 5) / 100;
                }
                else
                {
                    tax = s.price * 15 / 100;
                }
            
            return tax;
        }
        public string ord (product s)
        {
            string order = " ";
            if (s.quantityM < 10)
            {
                order = s.name;
            }
            return order;
        }
        

    }
}
