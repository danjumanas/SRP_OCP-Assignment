using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_OCP_Assignment
{

    // class that implements OCP, it can be extended but not modified
    public class OCP                              
    {            
        public void Customer(List<Hotel> hotelCustomers)
        {
            Console.WriteLine("enter number of nights");
            int numberOfNights = int.Parse(Console.ReadLine());
            
            //instantiating the Message Class
            Message message = new Message();
            message.Msg(numberOfNights);
            double fee = 0;
            

            //looping through the list
            foreach (var account in hotelCustomers)
            {
                fee += account.HotelFee(numberOfNights);
                Console.WriteLine(fee);

            }

           
            
        }
    }


    // abstract class that helps implement OCP
    public abstract class Hotel                                
    {

        //abstract method to calculate fee over number of nights
        public abstract int HotelFee(int numberOfNights);       

    }

    //inheriting abstract class
    public class HotelRegular : Hotel                   
    {
        public override int HotelFee(int numberOfNights)
        {
            //implementing abstract method to calculate fee using try catch
            try
            {
                int result = 10000 * numberOfNights;
                return result;
            }
            catch (Exception message)
            {

                throw message;
            }
        }
    }

    public class HotelDeluxe : Hotel
    {
        public override int HotelFee(int numberOfNights)
        {
            //implementing abstract method to calculate fee using try catch
            try
            {
                int result = 10000 * numberOfNights;
                return result;
            }
            catch (Exception message)
            {

                throw message;
            }
        }
    }


}
