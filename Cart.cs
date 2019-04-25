using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApplication1.ASM2
{
    public class Cart
    {
        public int ID;
        public string Customers;
        public double GrandTotal;
        public List<Products> ProductsList;
        public string Country;
        public string City;

        public Cart()
        {

        }

        public Cart(int ID, string Customers, double GrandTotal, List<Products> ProductsList, string Country,
            string City)
        {
            this.ID = ID;
            this.Customers = Customers;
            this.GrandTotal = GrandTotal;
            this.ProductsList = ProductsList;
            this.Country = Country;
            this.City = City;
        }

        public void AddPro(Products products)
        {
            ProductsList.Add(products);
        }

        public void RemovePro()
        {
            int i = 0;
            foreach (var x in ProductsList)
            {
                Console.WriteLine(i + "." + x);
                i++;
            }

            Console.WriteLine("Nhap anh can xoa");
            int a = Convert.ToInt32(Console.ReadLine());
            ProductsList.RemoveAt(a);
        }

        public double Check()
        {
            if (this.City.Equals("Hà Nội || HCM"))
            {
                return this.GrandTotal = GrandTotal + GrandTotal * 1 / 100;
            }
            else if (!this.Country.Equals("Việt Nam"))
            {
                return this.GrandTotal = GrandTotal + GrandTotal * 2 / 100;
            }
            else
            {
                return this.GrandTotal = GrandTotal + GrandTotal * 5 / 100;
            }

        }
    }
}