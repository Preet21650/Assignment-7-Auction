using System;

namespace Assignment_7_Auction
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] Items = new Item[5];
            Items[0] = new Item("Iphone", 1000);
            Items[1] = new Item("Ipad", 1500);
            Items[2] = new Item("Airpods", 7000);
            Items[3] = new Item("Headphones", 500);
            Items[4] = new Item("Speakers", 200);

            for (int i = 0; i < Items.Length; i++)
            {
                Console.WriteLine(Items[i].GetDes());
            }

            

        }
    }
}
