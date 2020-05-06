using System;
namespace Inheritance
{
    //declaring a class that inheritance from person
    public class Teacher : person
    {
        //declare props and set their val
        public string TeacherId{get;set;}
        public string Subject{get;set;}
        //declaring a contructor that takes 4 args with 2 base args
        public Teacher(string Name, int Age, string TeacherId,string Subject) : base(Name,Age)
        {
            //assign the value to local val of class
            this.Name=Name;
            this.Age=Age;
            this.TeacherId=TeacherId;
            this.Subject=Subject;
        }
    }
}