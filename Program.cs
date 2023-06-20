using SecurefirstBank;
using SecurefirstBank.Customer_Implimentations;

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
        break;
        //LogOut.LogMeOut();
    }
    //else
    //{
    //    Console.WriteLine("Wrong details");
    //}
}

