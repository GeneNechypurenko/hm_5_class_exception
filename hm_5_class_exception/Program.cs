using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace hm_5_class_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Website website = new Website();
                Console.Write("Enter Title: ");
                website.Title = Console.ReadLine();
                Console.Write("Enter URL: ");
                website.Url = Console.ReadLine();
                Console.Write("Enter Description: ");
                website.Description = Console.ReadLine();
                Console.Write("Enter IP Address: ");
                website.IpAdress = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine(website.ToString());

            }
            catch (NameIsEmptyException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("--------------------------");

            try
            {
                Magazine magazine = new Magazine();
                Console.Write("Enter Title: ");
                magazine.Title = Console.ReadLine();
                Console.Write("Enter Year of foundation: ");
                magazine.Year = Console.ReadLine();
                Console.Write("Enter Description: ");
                magazine.Description = Console.ReadLine();
                Console.Write("Enter Phone number: ");
                magazine.Phone = Console.ReadLine();
                Console.Write("Enter Email adress: ");
                magazine.Email = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine(magazine.ToString());
            }
            catch (NameIsEmptyException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("--------------------------");

            try
            {
                Shop shop = new Shop();
                Console.Write("Enter Title: ");
                shop.Title = Console.ReadLine();
                Console.Write("Enter Adress: ");
                shop.Adress = Console.ReadLine();
                Console.Write("Enter Description: ");
                shop.Description = Console.ReadLine();
                Console.Write("Enter Phone number: ");
                shop.Phone = Console.ReadLine();
                Console.Write("Enter Email adress: ");
                shop.Email = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine(shop.ToString());
            }
            catch (NameIsEmptyException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
