using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static object str;

        static void Main(string[] args)
        {
            Console.WriteLine("What is the lenght of the wall?");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the width of the wall?");
            double y = double.Parse(Console.ReadLine());


            double z = x * y;

            Console.WriteLine("The surface area of of the wall: " + z + "m^2");

            // 1m2 = 0.112 litres

            double paintReq = z * 0.112;
            double result = Math.Round(paintReq);
            Console.WriteLine("The amount of paint needed: " + paintReq + "L");

            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////");

            // one bucket holds 1 litre 

            double BucketofPaint = 1;
            Console.WriteLine("One bucket of paint holds: " + BucketofPaint + "L");


            Console.WriteLine("Enter the units: L, mL, Oz ");
            string units= Console.ReadLine();

            if (units == "L")
            {
                double BucketRequired = Math.Ceiling(BucketofPaint * paintReq);
                Console.WriteLine("The number of paint buckets you need: " + BucketRequired + " units");
            }
            else
            if (units == "mL")
            {
                double BucketRequired = Math.Ceiling(1000 * paintReq/1000);
                Console.WriteLine("The number of paint buckets you need: " + BucketRequired + " units");
            }
            else 
            if (units == "Oz")
            {
                double BucketRequired = Math.Ceiling(33.814 * paintReq /33.814);
                Console.WriteLine("The number of paint buckets you need: " + BucketRequired + " units");
            }

            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////");

            Console.WriteLine("Enter number of coats");
            int coat = int.Parse(Console.ReadLine());
            double ct = Math.Ceiling(coat * paintReq);
            Console.WriteLine("The number of coats: " + ct + "");

            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////");

            //Price of paint buckets
            double price = 19.99;
            double p = (price * ct);
            Console.WriteLine("The total price for you: " + "£" + p + "");

            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////");

            Console.WriteLine("Enter radius of semi-circle: ");
            double radius = double.Parse(Console.ReadLine());
            double area = (Math.PI * radius * radius * 0.5);
            Console.WriteLine("The area of the semi-circle: " + area);
            double value = (area / 120);
            double R = Math.Ceiling(value);
            Console.WriteLine("The number of paint required for SC: {0}", value);
            Console.WriteLine("The number of paints buckets needed to purchase: {0}", R);

            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////");

            // The type of paint colours 

            string[] colours = { "blue", "white", "purple", "silver" };
            foreach (string s in colours)
            {
                Console.WriteLine(char.ToUpper(s[0]) + s.Substring(1));
            }

            Console.WriteLine("Select a paint colour from the list ");
            string usertype = Console.ReadLine();
            double priceofpaint;


            if (usertype == "blue")
            {
                priceofpaint = 9.99;
                Console.WriteLine("The price of Blue paint: £{0}", priceofpaint);
                double PR = (priceofpaint * ct);
                Console.WriteLine("The total price for you: " + "£" + PR + "");

            }
            else if (usertype == "white")
            {
                priceofpaint = 14.99;
                Console.WriteLine("The price of White paint: £{0}", priceofpaint);
                double PR = (priceofpaint * ct);
                Console.WriteLine("The total price for you: " + "£" + PR + "");
            }

            else if (usertype == "purple")
            {
                priceofpaint = 17.99;
                Console.WriteLine("The price of Purple paint: £{0}", priceofpaint);
                double PR = (priceofpaint * ct);
                Console.WriteLine("The total price for you: " + "£" + PR + "");

            }
            else if (usertype == "silver")
            {
                priceofpaint = 23.99;
                Console.WriteLine("The price of Silver paint: £{0}", priceofpaint);
                double PR = (priceofpaint * ct);
                Console.WriteLine("The total price for you: " + "£" + PR + "");

            }

            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////");

            // declare how long it would take to paint the walls

            Console.WriteLine("State the number of hours it will take to paint the balls ");
            double HRS = double.Parse(Console.ReadLine());
            if (HRS <= 5)
            {
                Console.WriteLine("The paint job can be completed today");
            }
            else if (HRS <= 10)
            {
                Console.WriteLine("The paint job can be completed in two days");
            }
            else if (HRS <= 15)

            {
                Console.WriteLine("The paint job can be completed in three days");
            }
            else if (HRS <= 20)
            {
                Console.WriteLine("The paint job will take over a week!");


            }


            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////");
           
            Console.WriteLine("Help will be required. Choose a day to determine availability");
            string help = (Console.ReadLine());
            switch(help.ToLower())
            {
                case "monday":
                    Console.WriteLine("No help on Monday");
                    break;
                case "tuesday":
                    Console.WriteLine("Tuesday available time: 4pm-6pm");
                    break;
                case "wednesday":
                    Console.WriteLine("Wednesday will cost you an extra £5.00 for service fee");
                    break;
                case "thursday":
                    Console.WriteLine("No help on Thursday");
                    break;
                case "friday":
                    Console.WriteLine("Available at all times on Friday");
                    break;
                case "saturday":
                    Console.WriteLine("Saturday available time: 11am-6pm");
                    break;
                case "sunday":
                    Console.WriteLine("No Help on Sunday");
                    break;
            }
            













            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 6);









                Console.ReadKey();




        }
    }
}
