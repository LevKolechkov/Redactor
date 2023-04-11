using System;


namespace Redactor
{
  internal interface IOriginator
  {
    Memento GetMemento();
    void SetMemento(object memento);
  }
}
