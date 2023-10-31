using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTraker.DAL.DTO
{
    public class ProductDTO
    {
       public List<ProductDetailDTO> Products { get; set; }
       public  List<CategoryDetailDTO> Categories { get; set; }
    }
}
