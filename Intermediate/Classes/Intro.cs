using System;
namespace Intermediate.Classes
{
    public class Intro
    {
        public string Name = "Kingsley";

        public void GetName()
        {
            Console.WriteLine(Name);
        }

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, My Name is {1}", to, Name);
        }
    }
}

