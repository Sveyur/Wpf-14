using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_14
{
    public enum ProductCategories
    {
        Еда,
        Одежда,
        БытоваяТехника
    }
    public class Product
    {
        public string ProductName { get; set; }
        public uint ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public ProductCategories ProductCategory { get; set; }
        
    }
}

