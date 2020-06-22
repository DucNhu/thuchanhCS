using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP
{
    public abstract class Product
    {
        public int id;
        public string name;
        public double price;
        public string producer;

        public Product(int Id, string Name, double Price, string Producer)
        {
            id = Id;
            name = Name;
            price = Price;
            producer = Producer;
        }
        public abstract double computeTax();
    }
    //MobilePhone
    class MobilePhone : Product
    {
        public MobilePhone(int id, string name, double price, string producer) : base(id, name, price, producer) { }
        public override double computeTax()
        {
            return price * 10/100;
        }
    }
    //Book
    class Book : Product
    {
        public Book(int id, string name, double price, string producer) : base(id, name, price, producer) { }
        public override double computeTax()
        {
            return price * 8/100;
        }
    }
    class run
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>();

            MobilePhone mymobile = new MobilePhone(101, "lumia", 90.05, "nokia");
            MobilePhone mymobile2 = new MobilePhone(10, "lumia2", 9.05, "nokia");
            MobilePhone mymobile3 = new MobilePhone(11, "lumia3", 9.5, "nokia");
            Book myBook = new Book(102, "herry potter", 3.0, "DN");
            Book myBook2 = new Book(103, "herry potte2", 3.5, "DN");
            Book myBook3 = new Book(104, "herry potte3", 3.6, "DN");

            //Add ArrayList
            product.Add(mymobile);
            product.Add(mymobile2);
            product.Add(mymobile3);
            product.Add(myBook);
            product.Add(myBook2);
            product.Add(myBook3);
            //foreach(Product myEach in product)
            //{
                double myComtax = mymobile.computeTax()+ mymobile2.computeTax()+ mymobile3.computeTax() + myBook.computeTax() + myBook2.computeTax() + myBook3.computeTax();
                Console.WriteLine("{0}", myComtax);
            //}
            Console.Read();
        }
    }
}
