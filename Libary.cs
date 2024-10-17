using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.cs
{
    public class Libary
    {
        public Book[] Books = { };
        public void AddBook(Book book) {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }
        public Book GetFilteredBooks(string genre) {
            Book foundBook = null;
            foreach (var item in Books)
            {
                if (item.Genre == genre) {
                    foundBook = item;
                }
            }
            return foundBook;
        } 
        public Book[] GetFilteredBooks(int minPrice, int maxPrice)
        {
            Book[] foundedbooks = new Book[0];
            foreach (var item in Books)
            {
                if(item.Price > minPrice && item.Price < maxPrice)
                {
                    Array.Resize(ref foundedbooks, foundedbooks.Length + 1);
                    foundedbooks[foundedbooks.Length - 1] = item;
                    return foundedbooks;
                }
            } return foundedbooks;
        }
    }
        
    
    
}
