using System;
namespace Inheritance
{
    public class student : person
    {
        public string StudentId{get;set;}
        public string Email{get;set;}
        public student(string Name, int Age, string StudentId, string Email) : base (Name,Age)
        {
            this.Name=Name;
            this.Age=Age;
            this.StudentId=StudentId;
            this.Email=Email;
        }
    }
}