using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.cs
{
    public class Product
    {
        public string name;
        public int no;


        int _price;
        public int price;
        int _count;
        public int count;
        public int Price { 
            get {
            return _price;
                    } 
            set {  
               if(value < 0) { Console.WriteLine("qiymet menfi ola bilmez"); } else
                {
                    _price = value;
                }
            }
           
        }
        public int Count { 
            get {
                return _count;
            
            }
            set {
                if(value>0) {
                    value = _count;
                }
                else
                {
                    Console.WriteLine("Count menfi ola bilmez");
                }
            }
        }
    }
}
