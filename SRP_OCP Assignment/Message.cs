using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_OCP_Assignment
{
    /*a message class that can be called to send message in any part of code instead of having different classes having message functionality alongside their own functionality*/
    internal class Message
    {
        //message to be sent depending on the day,whether the customer is on the 1st day or on the last
        public void Msg(int numberOfNights)
        {
            //Console.WriteLine("enter number of nights");
            //int numberOfNights = int.Parse(Console.ReadLine());
            int dayOfWeek = (int)DateTime.Now.DayOfWeek;
            int endDay = dayOfWeek + numberOfNights;

            string text = "";

            try
            {
                for (int i = dayOfWeek; i <= dayOfWeek + numberOfNights; i++)
                {
                    if (i == dayOfWeek)
                    {
                        text = "welcome";
                    }
                    else if (i == dayOfWeek + numberOfNights)
                    {
                        text = "Goodbye, see you next time";
                    }
                    else
                    {
                        text = "keep enjoying your stay";
                    }
                }
            }
            catch (Exception message)
            {

                return;
            }

            Console.WriteLine(text);

            


        }
    }
}
