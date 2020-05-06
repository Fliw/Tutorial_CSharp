using System;
namespace Inheritance
{
    //declare that this student is inheritance from person
    public class student : person
    {
        //declare props and set their value
        public string StudentId{get;set;}
        public string Email{get;set;}
        //the contructor take 3 args and comparing original args in base (Person)
        public student(string Name, int Age, string StudentId, string Email) : base (Name,Age)
        {
            //set their value
            this.Name=Name;
            this.Age=Age;
            this.StudentId=StudentId;
            this.Email=Email;
        }
    }
}