using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.cs
{
    public class Book:Product
    {
         public string Genre;
        public Book(string genre, int no, int price , string name)
        { Genre = genre;
            this.no = no;   
            this.name = name;
            Price = price;
            
        }
        public void ShowFullInfo()
        {
            Console.WriteLine($"Genre:{Genre} NO:{no} Name:{name} ");
        }
    }
}
