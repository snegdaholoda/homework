using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_3._1
{
    abstract class Merchandise
    {
        public Merchandise(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double Price { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }


        public abstract void ShowInformation();
    }

   
    public interface IGoodsReceipt
    {
        void GoodsReceiptMerchandise(object ob);
    }

    public interface ISelling
    {
        void SellingMerchandise(object ob);
    }

    public interface IProductCancellation
    {
        void ProductCancellationMerchandise(object ob);
    }

    class HouseholdChemicals : Merchandise
    {
        public HouseholdChemicals(string name, double price, int quantity, string productGroup = "Бытовая химия")
            : base(name, price, quantity)
        {
            ProductGroup = productGroup;
        }

        string ProductGroup { get; set; }

        public override void ShowInformation()
        {
            Console.WriteLine("Группа товара:\t" + ProductGroup + "\nНаименование:\t" + Name + "\nЦена:\t\t" + Price + "\nКоличество\t" + Quantity);
        }
    }

    
    class Soap : HouseholdChemicals
    {
        public Soap(string name, double price, int quantity, bool expirationDate, string productGroup = "Бытовая химия")
            : base(name, price, quantity, productGroup)
        {
            ExpirationDate = expirationDate;
        }
        public bool ExpirationDate { get; set; }
    }

    class Shampoo : HouseholdChemicals
    {
        public Shampoo(string name, double price, int quantity, bool expirationDate, string productGroup = "Бытовая химия")
              : base(name, price, quantity, productGroup)
        {
            ExpirationDate = expirationDate;
        }
        public bool ExpirationDate { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Soap ob = new Soap("Мыло - Duru", 3.20, 10, true);
            ob.ShowInformation();
        }
    }
}

