using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurefirstBank
{ 
    
    public class CustomerSignUP
    {
        public static string Names { get; set; }
        public static string Password { get; set; }
        public static string Email { get; set; }  

        public  static void  Register()
        {
            Console.WriteLine("\n\n-----------------WELCOME TO REGISTER PORTAL----------------");
            Console.Write("Enter your Name>>>");
            Names = Console.ReadLine();

            Console.Write("Enter your Email>>>");
            Email = Console.ReadLine();

            Console.Write("Enter your Password>>>");
            Password = Console.ReadLine();

            using (var writer = new StreamWriter("CustomerFile.txt",true))
            {
                writer.WriteLine($"| {Names} | {Email} | {Password} |");
            }
        }




    }
}
