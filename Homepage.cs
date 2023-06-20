using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SecurefirstBank;

internal class Homepage
{
    public void MyHomePage()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Press 1 >> Register");
            Console.WriteLine("Press 2 >> Login");
            Console.WriteLine("Press 3 >> Log out");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                CustomerSignUP.Register();
            }
            if (choice == "2")
            {
                Login.LogMeIn();

            }
            if (choice == "3")
            {
                Console.WriteLine("Bye!");
               // break;
                //LogOut.LogMeOut();
            }
            //else
            //{
            //    Console.WriteLine("Wrong details");
            //}
       }

    }
}
   


