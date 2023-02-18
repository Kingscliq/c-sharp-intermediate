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


        //var customer = new Customer();

        //customer.Name = "Midax";

        //var order = new Orders();
        //customer.Orders.Add(order);

        //foreach(Orders val in customer.Orders)
        //{
        //    Console.WriteLine(val);
        //}

        //Console.WriteLine(customer.Name);
        //Console.WriteLine("Our customer name is {0} and his id is ID-0{1}", customer.Name, customer.Id);

        var customer = new CustomerInfo();

        customer.SetBirthDate(new DateTime(1997, 1, 3));
        Console.WriteLine(customer.GetBirthDate());

        var person = new Person();

        person.BirthDate = new DateTime(1998, 08, 07);
        var cookie = new HttpCookie();

        cookie["name"] = "Kingsley Ezenwa";

        Console.WriteLine("My Cookie name value is: {0}", cookie["name"]);



        Console.WriteLine(person.Age);


        var text = new Text();
        Text.AddHyperLink("http://uml.com/u");

        var dbMigrator = new DbMigrator(new Logger());

        var logger = new Logger();

        var installer = new Installer(logger);


        dbMigrator.Migrate();
        installer.Install();
        
    }
}

