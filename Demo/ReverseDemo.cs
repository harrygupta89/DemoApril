using System;
using System.Text;

namespace Demo
{
    class ReverseDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the String");
            string str = Console.ReadLine();
            string output = ReverseFunction(str);
            Console.WriteLine("The reversed string is : "+ output);
            Console.Read();
        }

        public static string ReverseFunction(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i= str.Length-1; i >= 0; i--)
                sb.Append(str[i]);            

            return sb.ToString();
        }
    }
}
