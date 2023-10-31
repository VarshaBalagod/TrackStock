using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace StockTraker.DAL.DTO
{
    public class CategoryDetailDTO
    {
        public  int CategoryId { get; set; }
        public  string CategoryName { get; set; }
    }
}
