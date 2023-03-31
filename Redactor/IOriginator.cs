using System;


namespace Redactor
{
  internal interface IOriginator
  {
    object GetMemento();
    void SetMemento(object memento);
  }
}
