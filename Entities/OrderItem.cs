using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Entities
{
    internal class OrderItem
    {
        public string Name {  get; set; }   
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem()
        {

        }
        public OrderItem(string name,int quantity, double price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }
        public double SubTotal()
        {
            return Quantity * Price;
        }

      
        public override string ToString()
        {

            return $"{Name}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {Quantity}, Subtotal: {SubTotal().ToString("F2", CultureInfo.InvariantCulture)}";


        }
    }
}
