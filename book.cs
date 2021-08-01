using System;
using System.Collections.Generic;
using System.Linq;

class Book{
  public string ISBN {get; set;}
  public string Title {get; set;}
  public string AuthorInfo {get; set;}
  public virtual DateTime PublishedOn {get; set;}
  public string PublishedBy {get; set;}
  public string book_title = "book";
  public string Author_name = "author";
  public string Remove_isbn = "";

  //public class Book {
    public Book(string ISBN, string Title, string AuthorInfo) 
    {
    PublishedOn = DateTime.Now;
    PublishedBy = "Unknown";
    book_title = Title;
    Author_name = AuthorInfo;
    Remove_isbn = ISBN;
    }

    public Book(string IBSN, string Title, string AuthorInfo, DateTime PublishedOn, string PublishedBy) 
    {
      book_title = Title;
      Author_name = AuthorInfo;
      Remove_isbn = ISBN;
    }
  //}

    public virtual void Display()
    {
    Console.WriteLine("Book " + book_title + " was written by " + Author_name + " and published on " + PublishedOn);
    }

}