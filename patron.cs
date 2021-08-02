using System;
using System.Collections.Generic;
using System.Linq;

class Patron : Person{

  public string LibraryId {get; set;}
  public virtual DateTime StartDate {get; set;}
  public virtual DateTime EndDate {get; set;}
  public bool IsAccountActive;
  private List<Book> RentalCart = new List<Book>();
  public int FineAmountDue;
  public string Title {get; set;}
  public string book_title {get; set;} 


  public Patron(string fname, string lname, string Id)
  {
    Console.WriteLine("Patron constructor");
    FineAmountDue = 0;
    StartDate = DateTime.Now;
    IsAccountActive = true;
    FirstName = fname;
    LastName = lname;
    LibraryId = Id;
  }

  public void Display()
  {
    Console.WriteLine("Patron Id=" + LibraryId + " Name=" + FirstName + " " + LastName);
  }

  public virtual void AddToRentalCart(Book book1, DateTime DateDue)
  {
    RentalCart.Add(book1);
    
    Console.WriteLine("Added to rental cart " + book1.book_title + " for patron " + FirstName + " " + LastName);
  }

  public void RemoveFromRentalCart(Book book1)
  {
    RentalCart.Remove(book1);
    
    Console.WriteLine("Removed from rental cart " + book1.book_title + " for patron " + FirstName + " " + LastName);
  }
}