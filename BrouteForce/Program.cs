using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrouteForce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter pass");
            string s = Console.ReadLine();
            while(s.Length!=4)
            {
                Console.WriteLine("Password Lenth should be 4 chars! \n Please try again: ");
                s = Console.ReadLine();
            }
            SetPassword(s);
        }
        public static void SetPassword(string bf)
        {
            string s = "";
            string[] arr = new string[36];
            CreateTable(arr);

            int first = 0;
            int sec = 0;
            int third = 0;
            int fourth = 0;

            while(s!=bf)
            {
               if(first == 36)
               {
                   sec++;
                   first = 0;
               }
               if (sec == 36)
               {
                   third++;
                   sec = 0;
               }
               if (third == 36)
               {
                   fourth++;
                   third = 0;
               }
               if (fourth == 36)
               {
                   break;
               }
               Console.WriteLine(s);
               s = arr[first] + arr[sec] + arr[third] + arr[fourth];
               first++;
            }
            Console.WriteLine("Correct: " + s);
        }
        public static void CreateTable(string[]arr)//בונה טבלה
        {
            int j=97;
            for(int i=0;i<26;i++)//לפי טבלת האסקי
            {
                    arr[i] = "" + (char)j;
                    j++;   
            }
            j = 48;
            for(int i=26;i<arr.Length;i++)
            {
                arr[i] = "" + (char)j;
                j++;
            }
            
        }
    }
}
