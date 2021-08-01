using System;
using System.Collections.Generic;
using System.Linq;


class MainClass {
  public static void Main (string[] args) {
    
    /*Console.WriteLine("Testing Address");
    Address addr1 = new Address();
    addr1.AddressLine1="1234 Main St";
    addr1.AddressLine2="Apt 102";
    addr1.City = "Cleveland";
    addr1.State = "azzffdsfd";
    addr1.Zipcode = "44143";

    addr1.Display();*/

    /*Console.WriteLine("Testing Person");
    Person p1 = new Person();
    p1.FirstName = "John";
    p1.LastName = "Smith";
    p1.PermanentAddress.AddressLine1 = "1234 Main St";
    p1.PermanentAddress.City = "Cleveland";
    p1.PermanentAddress.State = "OH";
    p1.PermanentAddress.Zipcode = "44143";
    p1.DateOfBirth = Convert.ToDateTime("07/13/1994");
    p1.Intro();
    p1.IsBirthday();  */  

    /*Console.WriteLine("Testing Student 1");
    Student s1 = new Student();
    s1.FirstName = "Kara";
    s1.LastName="Kaiser";
    s1.DateOfBirth = Convert.ToDateTime("01/01/2020");
    s1.PermanentAddress.AddressLine1 = "999 Mallard Dr";
    s1.PermanentAddress.City = "Parma";
    s1.PermanentAddress.State = "OH";
    s1.PermanentAddress.Zipcode = "44143";
    s1.GPA = 2.1;
    s1.School = "Cleveland State University";
    s1.Intro();
    s1.IsBirthday();
    s1.SetAcademicStanding();
    Console.WriteLine(s1.AcademicStanding);


    Console.WriteLine("Testing Student 2");
    Student s2 = new Student("Andrew", "Peggman");    
    s2.DateOfBirth = Convert.ToDateTime("01/01/1989");
    s2.PermanentAddress.AddressLine1 = "999 Mallard Dr";
    s2.PermanentAddress.City = "Parma";
    s2.PermanentAddress.State = "OH";
    s2.PermanentAddress.Zipcode = "44143";
    s2.GPA = 2.75;
    s2.School = "Ohio State University";
    s2.Intro();
    s2.IsBirthday();
    s2.SetAcademicStanding();
    Console.WriteLine(s2.AcademicStanding);*/

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
    
  }
}
