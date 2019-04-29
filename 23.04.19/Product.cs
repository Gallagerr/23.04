using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._04._19
{
  public class Product : Entity
  {
    public string Name { get; set; }
    public double Cost { get; set; }

    public void Print()
    {
      Console.WriteLine($"{Name} : {Cost}");
    }
  }
}
