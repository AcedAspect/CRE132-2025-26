using System;

        string password = "Password1";
        string attempt = Console.ReadLine();
        if (attempt == password)
        {
            Console.WriteLine("You May Enter");
        }
        else
        {
            Console.WriteLine("Leave");
        }