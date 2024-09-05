using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio03.Entities.Enums;
namespace Exercicio03.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
      
        public List<OrderItem> Products  {get; set;}

        public Order() { 
            
            Products = new List<OrderItem>();
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (var item in Products)
            {
                total += item.SubTotal(); 
            }
            return total;
        }

        public void AddProduct(OrderItem product) {
            Products.Add(product);        
        }
        public void RemoveProduct(OrderItem product)
        {
            Products.Remove(product);
        }

       
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Moment.ToString("dd/mm/yyyy HH:mm:ss"));
          
            return sb.ToString();
        }


     
        

      
    }
}
