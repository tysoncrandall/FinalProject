using System;
using System.Collections.Generic;
using System.Linq;


class MainClass {
  public static void Main (string[] args) {

    Author a1 = new Author();
    a1.FirstName = "K";
    a1.LastName="Kaiser";
    a1.Email="123@gmail.com";
    a1.DateOfBirth = Convert.ToDateTime("01/01/2020");
    a1.PermanentAddress.AddressLine1 = "999 Mallard Dr";
    a1.PermanentAddress.City = "Parma";
    a1.PermanentAddress.State = "OH";
    a1.PermanentAddress.Zipcode = "44143";
    a1.DisplayInfo();

    Author a2 = new Author();
    a2.FirstName = "T";
    a2.LastName="Crandall";
    a2.Email="outlook.outlook@hotmail.com";
    a2.DateOfBirth = Convert.ToDateTime("01/01/2003");
    a2.PermanentAddress.AddressLine1 = "1200 Ohio Dr";
    a2.PermanentAddress.City = "Westlake";
    a2.PermanentAddress.State = "OH";
    a2.PermanentAddress.Zipcode = "44126";
    a2.DisplayInfo();
    
    Book b1 = new Book("978-3-16-148410-0", "Book 1", "Author 1");
    Book b2 = new Book("978-3-16-148410-1", "Book 2", "Author 2");
    Book b3 = new Book("978-3-16-148410-2", "Book 3", "Author 3");
    Book b4 = new Book("978-3-16-148410-3", "Book 4", "Author 4", DateTime.Parse("10/1/2017 12:00:00 AM"), "Tri-C Publications");
    Book b5 = new Book("978-3-16-148410-4", "Book 5", "Author 5", DateTime.Parse("10/1/2018 12:00:00 AM"), "Tri-C Publications");
    Book b6 = new Book("978-3-16-148410-5", "Book 6", "Author 6", DateTime.Parse("10/1/2019 12:00:00 AM"), "Tri-C Publications");

    a1.AddBook(b1);
    a1.AddBook(b3);
    a1.AddBook(b5);
    a1.DisplayBooks();

    a2.AddBook(b2);
    a2.AddBook(b4);
    a2.AddBook(b6);
    a2.DisplayBooks();

    a1.RemoveBook("978-3-16-148410-0");
    a1.DisplayBooks();
    
    Patron p1 = new Patron("Tyson" , "Crandall", "1111");
    p1.Title = "Harry Potter";
    p1.AddToRentalCart(b1, DateTime.Parse("10/1/2019 12:00:00 AM"));
    p1.Display();
    p1.AddToRentalCart(b2, DateTime.Parse("10/2/2019 12:00:00 AM"));
    p1.Display();
    p1.AddToRentalCart(b3, DateTime.Parse("10/3/2019 12:00:00 AM"));
    p1.Display();
    p1.AddToRentalCart(b4, DateTime.Parse("10/4/2019 12:00:00 AM"));
    p1.Display();
    p1.AddToRentalCart(b5, DateTime.Parse("10/5/2019 12:00:00 AM"));
    p1.Display();

    Patron p2 = new Patron("Ryan" , "H", "1211");
    p1.Display();

    Patron p3 = new Patron("Ben" , "S", "1121");
    p3.Display();

    Patron p4 = new Patron("James" , "H", "1121");
    p4.Display();

    Patron p5 = new Patron("Jason" , "C", "1112");
    p5.Display();

    p1.RemoveFromRentalCart(b3);
  }
}
