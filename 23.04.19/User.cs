using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._04._19
{
  public class User : Entity
  {
    public string Login { get; set; }
    public string Password { get; set; }
    public Cart Cart { get; set; } = new Cart();
    public void Print()
    {
      Console.WriteLine($"Login    : {Login}");
      Console.WriteLine($"Password : {Password}");
    }
  }
}
