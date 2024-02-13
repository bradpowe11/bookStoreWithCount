using System;

namespace bookStore
{
    class book
    {
        private static int _transactions=0;
        private int _Id;
        private string _Title;
        private string _Author;

        public book()
        {
            _Id = 0;
            _Author = "";
            _Title = "";
        }
        public book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }
        public int GetTrans()
        { 
            return _transactions; 
        }
        public int GetId()
        {
            return _Id;
        }
        public string GetTitle(string title)
        {
            return _Title;
        }
        public string GetAuthor(string author)
        {
            return _Author;
        }
        public void SetTrans()
        {
            _transactions++;
        }
        public void SetId(int id)
        {
            _Id = id;
        }
        public void SetTitle(string title)
        {
            _Title = title;
        }
        public void SetAuthor(string author)
        {
            _Author = author;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            book member10 = new book();
            member10.SetTrans();
            member10.SetId(10);
            member10.SetTitle("In God We Trust");
            member10.SetAuthor("Jean Shepherd");
            Console.WriteLine($"ID = {member10.GetId()}, Title = {member10.GetTitle(" ")}, Name = {member10.GetAuthor(" ")}");
            

            book member20 = new book();
            member20.SetTrans();
            Console.WriteLine("Please enter the book ID: ");
            member20.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the Title: ");
            member20.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the Author: ");
            member20.SetAuthor(Console.ReadLine());

            book member30 = new book(30, "Harry Potter", "J.K. Rowling");
            member30.SetTrans();
            Console.WriteLine($"ID = {member30.GetId()}, Title = {member30.GetTitle(" ")}, Name = {member30.GetAuthor(" ")}");

            Console.WriteLine("Please enter the book ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Please enter the Author: ");
            string author = Console.ReadLine();
            book member40 = new book(id, title, author);
            member40.SetTrans();

            Console.WriteLine($"The book has {member10.GetTrans()} new transactions");
            displayBooks(member10);
            displayBooks(member20);
            displayBooks(member30);
            displayBooks(member40);
        }
        static void displayBooks(book member)
        {
            Console.WriteLine("Here's your book information");
            Console.WriteLine($"ID: {member.GetId()}");
            Console.WriteLine($"Title: {member.GetTitle(" ")}");
            Console.WriteLine($"Author: {member.GetAuthor(" ")}");

        }
    }
}
