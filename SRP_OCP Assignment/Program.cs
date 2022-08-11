using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_OCP_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Hotel> customers = new List<Hotel>();
            customers.Add(new HotelRegular());
            customers.Add(new HotelDeluxe());
            
            //Console.WriteLine("enter number of nights");
            //int numberOfNights = int.Parse(Console.ReadLine());

            OCP ocp = new OCP();
            ocp.Customer(customers);


            
        }
    }   
}
