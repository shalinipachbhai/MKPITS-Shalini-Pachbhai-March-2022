using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_class_book
{
    class Book
    {
        int bookid;
        String title,author;
        int price;
        //creating a constructor with no parameters
        public Book()
        {
            bookid=1;
            title="oracle";
            author="james";
            price=250;
        }
        public void display()
        {
            Console.WriteLine("book id="+bookid);
            Console.WriteLine("book title="+title);
            Console.WriteLine("book author="+author);
            Console.WriteLine("book price="+price);
        }

    }
    class program
    {
        static void main(string[]args)
        {
            Book b=new Book;//this will call constructor automatically
            b.display();
            Console.ReadLine();
        }
    }
}