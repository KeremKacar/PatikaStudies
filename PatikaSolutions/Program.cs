﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaSolutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte result1 = 2;
            sbyte result2 = 3;
            short result3 = 4;
            ushort result4 = 5;
            Int16 result5 = 6;
            Int32 result6 = 7;
            Int64 result7 = 8;
            int result8 = 9;
            uint result9 = 10;
            long result10 = 11;
            ulong result11 = 12;
            float result12 = 13;
            double result13 = 14;
            decimal result14 = 15;
            char result15 = 'A';
            string result16 = "Merhaba";
            bool result17 = true;
            bool result18 = false;
            DateTime result19 = DateTime.Now;
            //Console.WriteLine(result19);
            //Console.ReadLine();
            object result20 = 5;
            object result21 = "Hello";
            object result22 = true;
            object result23 = 25.85;
            string result24 = string.Empty; //null; ya da ""; da yapılabilir.
            result24 = "Kerem Kacar";
            string result25 = "Kerem";
            string result26 = "Kacar";
            string result27 = result25 + " " + result26;
            //Console.WriteLine(result27);
            //Console.ReadLine();
            int result28 = 5;
            int result29 = 6;
            int result30 = result28 * result29;
            //Console.WriteLine(result30);
            //Console.ReadLine();
            bool result31 = 10<2;
            //Console.WriteLine(result31);
            //Console.ReadLine();
            string result32 = "20";
            int result33 = 50;
            string result34 = result32 + result33.ToString();
            Console.WriteLine(result34);
            int result35 = result33 + Convert.ToInt32(result32);
            //Console.WriteLine(result35);
            //Console.ReadLine();

            string dateTime = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime);
            string hour = DateTime.Now.ToString("HH.mm");
            Console.WriteLine(hour);
            Console.ReadLine();
        }
    }
}
