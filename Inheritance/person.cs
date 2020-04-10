using System;
namespace Inheritance
{
    public class person
    {
        public string Name {get; set;}
        public int Age{get;set;}
        public person(string Name,int Age){
            this.Name=Name;
            this.Age=Age;
        }
        public void GetNameAndAge()
        {
            Console.WriteLine("The Person has name:{0} and Age {1}",Name,Age);
        }
    }
}