using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Core.Models;

namespace TheShop.Core.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> product { get; set; }
        public IEnumerable<ProductCategory> productCategories { get; set; }
    }
}
