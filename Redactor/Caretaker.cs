using System;
using System.Collections.Generic;

namespace Redactor
{
  class Caretaker
  {
    public List<Memento> Saves { get; set; }
    public Caretaker()
    {
      Saves = new List<Memento>();
    }
  }
}
