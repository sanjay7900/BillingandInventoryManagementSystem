using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    public class Billing_and_InventorySystem
    {   
       public void User_Module() 
        {
            FileStream fst = new FileStream(@"D:\DotnetTraining\DemoRepo\user.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fst);
            Console.Write("Enter the UserId: ");
            sw.Write(Console.ReadLine());
            sw.Write(',');

            Console.Write("Enter the Fname: ");
            sw.Write(Console.ReadLine());
            sw.Write(',');

            Console.Write("Enter the Lname: ");
            sw.Write(Console.ReadLine());
            sw.Write(',');

            Console.Write("Enter the Email: ");
            sw.Write(Console.ReadLine());
            sw.Write(',');

            Console.Write("Enter the Phone: ");
            sw.Write(Console.ReadLine());
            sw.WriteLine("");
            sw.Close(); 
            fst.Close();
        }
        public void Category_Module()
        {
            FileStream fst = new FileStream(@"D:\DotnetTraining\DemoRepo\Category.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fst);
            Console.Write("Enter the CategoryId: ");
            sw.Write(Console.ReadLine());
            sw.Write(',');

            Console.Write("Enter the CategoryType: ");
            sw.Write(Console.ReadLine());

            sw.WriteLine("");
            sw.Close();
            fst.Close();
        }
        public void Product_Module()
        {
            
            FileStream fst = new FileStream(@"D:\DotnetTraining\DemoRepo\Product.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fst);
            Console.Write("Enter the Productid: ");
            sw.Write(Console.ReadLine());
            sw.Write(',');

            Console.Write("Enter the categorytype: ");
            sw.Write(Console.ReadLine());
            sw.Write(',');

            Console.Write("Enter the productname: ");
            sw.Write(Console.ReadLine());
            sw.Write(',');

            Console.Write("Enter the quantity: ");
            sw.Write(Console.ReadLine());
            sw.Write(',');

            Console.Write("Enter the price: ");
            sw.Write(Console.ReadLine());
            sw.WriteLine("");
            sw.Close();
            fst.Close();

        }
        public void Purchase_and_Sales_Module()
        {
            

            FileStream fst = new FileStream(@"D:\DotnetTraining\DemoRepo\PurchaseandSales.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fst);
            Console.Write("Enter the SalesId: ");
            sw.Write(Console.ReadLine());
            sw.Write(',');

            Console.Write("Enter the Productid: ");
            sw.Write(Console.ReadLine());
            sw.Write(',');

            Console.Write("Enter the price: ");
            sw.Write(Console.ReadLine());
            sw.Write(',');

            Console.Write("Enter the salesdate: ");
            sw.Write(Console.ReadLine());
            

            
            sw.WriteLine("");
            sw.Close();
            fst.Close();


        }
        //public void ReadFile()
        //{
        //    int[] marks = new int[2];
        //    int[] stuId=new int[2];
        //    string[] stuName=new string[2];

            

        //    FileStream readfile = new FileStream(@"D:\DotnetTraining\DemoRepo\myfile.txt", FileMode.Open, FileAccess.Read);
        //    StreamReader streamReader = new StreamReader(readfile);
        //    while(streamReader.Peek() > 0)
        //    {
        //       string line=streamReader.ReadLine();
        //        string[] mydata=line.Split(',');
        //        Console.WriteLine(mydata[0]+" "+mydata[1]+" "+mydata[2]);
        //        //stuId[0]=Convert.

        //    }
        //}
        


    }
}
