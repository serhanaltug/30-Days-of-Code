using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication1
{
    abstract class Book
    {
        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();


    }

    class MyBook : Book {

        private int price;

        public MyBook(String t, String a, int p) : base(t, a)
        {
            price = p;
        }

        override public void display()
        {
            Console.WriteLine("Title: " + title + "\nAuthor: " + author + "\nPrice: " + price);            
        }
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
            Console.ReadLine();
        }
    }

}
