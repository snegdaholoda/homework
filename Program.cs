using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace dz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\nARTICLE");
            Article commodity1 = new Article("ak1598", "Red Apples", 4.20F, Article.ArticleType.Foods);
            Article commodity2 = new Article("lu385", "Marine Hat", 14.62F, Article.ArticleType.Clothes);
            Article commodity3 = new Article("g654", "Tea Table", 330F, Article.ArticleType.Furniture);
            Console.WriteLine(commodity1);
            Console.WriteLine(commodity2);
            Console.WriteLine(commodity3);


            Console.WriteLine("\n\n\nCLIENT");
            Client client1 = new Client("214", "Vasya Pupkin", "Forbes ave.,37,7,Sacramento,CA", "(661) 664-2011", 10, 1340);
            Console.WriteLine(client1);


            Console.WriteLine("\n\n\nREQUEST ITEM");
            RequestItem item1 = new RequestItem(commodity1, 3);
            Console.WriteLine(item1);



            Console.WriteLine("\n\n\nREQUEST-------------------------------------");

            List<RequestItem> ItemList1 = new List<RequestItem>();
            ItemList1.Add(item1);
            ItemList1.Add(new RequestItem() { RequestArticle = commodity2, Quantity = 1 });
            ItemList1.Add(new RequestItem() { RequestArticle = commodity3, Quantity = 2 });

            Request request1 = new Request("6534", client1, Request.PayType.Credit, ItemList1);
            request1.PrintRequest();

            Console.ReadKey();


        }
    }
        struct Article
        {
            string Product_code;
            string Name;
            public float Price;
            ArticleType Type;
            public enum ArticleType
            {
                Foods, Clothes, Furniture
            }
            public Article(string Product_code, string Name,
                float Price, Article.ArticleType Type)
            {
                this.Product_code = Product_code;
                this.Name = Name;
                this.Type = Type;
                this.Price = Price;
            }
            public Article DeepCopy(Article currentArticle)
            {
                Article newArticle = new Article();

                newArticle.Product_code = currentArticle.Product_code;
                newArticle.Name = currentArticle.Name;
                newArticle.Price = currentArticle.Price;
                newArticle.Type = currentArticle.Type;

                return newArticle;
            }
            public override string ToString()
            {
                return string.Format(" {3}  \t (#{0}) \t {1} \t ${2}", Product_code, Name, Price, Type);
            }
        }
        struct Client
        {
            string Client_code;
            string Full_name;
            string Address;
            string Phone_number;
            int Orders_count;
            double Total_amount;
            ClientType Type;

            public enum ClientType
            {
                rating_1, rating_2, rating_3, rating_4

            }

            public Client(string Client_code, string Full_name, string Address,
                string Phone_number, int Orders_count, double Total_amount)
            {
                this.Client_code = Client_code;
                this.Full_name = Full_name;
                this.Address = Address;
                this.Phone_number = Phone_number;
                this.Orders_count = Orders_count;
                this.Total_amount = Total_amount;

                if (this.Total_amount < 1000)
                {
                    this.Type = ClientType.rating_1;
                }
                else if (this.Total_amount > 1000 && this.Total_amount <= 5000)
                {
                    this.Type = ClientType.rating_2;
                }
                else if (this.Total_amount > 5000 && this.Total_amount <= 25000)
                {
                    this.Type = ClientType.rating_3;
                }
                else
                {
                    this.Type = ClientType.rating_4;
                }

            }
            public Client DeepCopy(Client currentClient)
            {
                Client newClient = new Client();

                newClient.Client_code = currentClient.Client_code;
                newClient.Full_name = currentClient.Full_name;
                newClient.Address = currentClient.Address;
                newClient.Phone_number = currentClient.Phone_number;
                newClient.Orders_count = currentClient.Orders_count;
                newClient.Total_amount = currentClient.Total_amount;
                newClient.Type = currentClient.Type;

                return newClient;
            }
        }
        struct RequestItem
        {
            public Article RequestArticle;
            public uint Quantity;

            public RequestItem(Article RequestArticle, uint Quantity)
            {
                this.RequestArticle = RequestArticle.DeepCopy(RequestArticle);
                this.Quantity = Quantity;
            }
            public RequestItem DeepCopy(RequestItem current)
            {
                RequestItem copied = new RequestItem();

                copied.RequestArticle = current.RequestArticle.DeepCopy(current.RequestArticle);
                copied.Quantity = current.Quantity;

                return copied;
            }
        }
        struct Request
        {
            string Order_code;
            Client Client;
            DateTime Order_date;
            List<RequestItem> ItemList;
            PayType Payment;

            public enum PayType
            {
                Cash, Credit
            }
            public double Sum
            {
                get
                {
                    double Sum = 0;
                    foreach (RequestItem item in ItemList)
                    {
                        Sum += item.Quantity * item.RequestArticle.Price;
                    }
                    return Sum;
                }
            }
            public Request(string Order_code, Client Client, Request.PayType Payment, List<RequestItem> ItemList)
            {
                this.Order_code = Order_code;
                this.Client = Client.DeepCopy(Client);
                this.Order_date = DateTime.Today;
                this.ItemList = ItemList.Select(item => (RequestItem)item.DeepCopy(item)).ToList();
                this.Payment = Payment;
            }
            public void PrintRequest()
            {
                Console.WriteLine("\n #{0} - {2}\n\n{1} \n\n Payment: {3} \n", Order_code, Client, Order_date.ToString("yyyy/MM/dd"), Payment);
                uint i = 0;
                foreach (RequestItem item in ItemList)
                {
                    i++;
                    Console.WriteLine("{0}.{1}", i, item);
                }
                Console.WriteLine("\nTotal Sum = {0}", Sum);
            }

        }
    
}