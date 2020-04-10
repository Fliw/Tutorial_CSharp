using System;
namespace Inheritance
{
    public class Teacher : person
    {
        public string TeacherId{get;set;}
        public string Subject{get;set;}
        public Teacher(string Name, int Age, string TeacherId,string Subject) : base(Name,Age)
        {
            this.Name=Name;
            this.Age=Age;
            this.TeacherId=TeacherId;
            this.Subject=Subject;
        }
    }
}