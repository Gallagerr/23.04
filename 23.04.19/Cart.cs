using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._04._19
{
  public class Cart : Entity
  {
    public Cart()
    {
      Products = new List<Product>();
    }
    public ICollection<Product> Products { get; set; }
  }
}
