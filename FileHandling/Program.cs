using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Billing_and_InventorySystem performFileHandling = new Billing_and_InventorySystem();
            Console.WriteLine("Enter the User DETAILS ....");
            performFileHandling.User_Module();
            Console.WriteLine("************************************************");
            Console.WriteLine();
           
            Console.WriteLine("Enter the Category DETAILS ....");
            performFileHandling.Category_Module();
            Console.WriteLine("************************************************");
            Console.WriteLine();
            Console.WriteLine("Enter the Product DETAILS ....");
            performFileHandling.Product_Module();
            Console.WriteLine("************************************************");
            
            Console.WriteLine();
            Console.WriteLine("Enter the PURCHASE AND Sales DETAILS ....");
            performFileHandling.Purchase_and_Sales_Module();
            Console.WriteLine("Please Enter Any key to Quit This Window");



            Console.ReadKey();  
        }
    }
}
