using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListaDeCompras.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        //todo trocar para enum
        public string QuantityUnityMeasure { get; set; }
        public decimal Price { get; set; }
    }
}
