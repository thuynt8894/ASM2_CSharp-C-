using System;
using System.Collections.Generic;

namespace ConsoleApplication1.ASM2
{
    public class Program
    {
        public static void Main4(string[] args)
        {
            List<String>list = new List<string>();
            list.Add("1");
            
            Products products1 = new Products(1, "Samsung",467878, 15, "Img1", "Chup anh dep","Thu"1);
            
            Cart cart = new Cart();
            
            cart.AddPro(products1);
            
                cart.RemovePro();
        }
    }
}