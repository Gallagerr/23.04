﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._04._19
{
  public class Entity
  {
    public Guid Id { get; set; }

    public Entity()
    {
      Id = Guid.NewGuid();
    }
  }
}
