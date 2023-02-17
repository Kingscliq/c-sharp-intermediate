using Intermediate.Classes;
using Intermediate;

namespace Intermediate;

class Entry
{
    static void Main(string[] args)
    {
        var introduce = new Intro();

        introduce.GetName();
        introduce.Introduce("Mosh");


        var customer = new Customer("Merit", 1);

        Console.WriteLine("Our customer name is {0} and his id is ID-0{1}", customer.Name, customer.Id);
    }
}

