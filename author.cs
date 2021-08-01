using System;
using System.Collections.Generic;
using System.Linq;

class Author : Person{
  private List<Book> BookList = new List<Book>();

  public Author()
  {
    PermanentAddress = new Address();
    Console.WriteLine("Author constructor");
  }

  public Author(string fname, string lname)
  {
    FirstName = fname;
    LastName = lname;
    PermanentAddress = new Address();
    Console.WriteLine("Author constructor");
  }

  public void DisplayInfo()
  {
    Console.WriteLine("Name: " + FirstName + " " + LastName);
    Console.WriteLine("Email: " + Email);
  }

  public void DisplayBooks()
  {
    foreach (Book b in BookList)
    {
      b.Display();
    }
  }

  public void AddBook(Book book1)
  {
    BookList.Add(book1);
  }

  public void RemoveBook(string ISBN)
  {
    Book b = BookList.Find(o=>o.Remove_isbn == ISBN);
    BookList.Remove(b);
    Console.WriteLine("Book: '" + b + "' was removed");
  }
}