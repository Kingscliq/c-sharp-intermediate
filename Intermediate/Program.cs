﻿using Intermediate.Classes;
using Intermediate;

namespace Intermediate;

class Entry
{
    static void Main(string[] args)
    {
        var introduce = new Intro();

        introduce.GetName();
        introduce.Introduce("Mosh");


        var customer = new Customer();

        customer.Name = "Midax";

        var order = new Orders();
        customer.Orders.Add(order);

        foreach(Orders val in customer.Orders)
        {
            Console.WriteLine(val);
        }

        Console.WriteLine(customer.Name);
        //Console.WriteLine("Our customer name is {0} and his id is ID-0{1}", customer.Name, customer.Id);
    }
}

