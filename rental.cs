using System;
using System.Collections.Generic;
using System.Linq;

class Rental{

  public object Book {get; set;}
  public virtual DateTime DateRented {get; set;}
  public virtual DateTime DateDue {get; set;}

  public Rental(object Book, DateTime DateRented, DateTime DateDue)
  {

  }
}