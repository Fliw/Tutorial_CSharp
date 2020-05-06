using System;
namespace Inheritance
{
    //make a class
    public class person
    {
        //declare an props and set their value by constructor
        public string Name {get; set;}
        public int Age{get;set;}
        //contructor
        public person(string Name,int Age){
            this.Name=Name;
            this.Age=Age;
        }
        //custom method
        public void GetNameAndAge()
        {
            Console.WriteLine("The Person has name:{0} and Age {1}",Name,Age);
        }
    }
}