using System;

namespace assignment2
{
    public enum Status 
    {
        New,
        Active,
        Dropout,
        Graduated
    }
    public class student
    {
        private Status status { get; }
        public int Id { get; }
        public String GivenName { get; set; }
        public String Surname { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime GraduationDate { get; set; }

        public student(int id, string givenname, string surname, DateTime startdate, DateTime graduationdate)
        {
            Id = id;
            GivenName = givenname;
            Surname = surname;
            //dateTime should show year, month, day, hour, minute, second
            StartDate = startdate;
            GraduationDate = graduationdate;
            //EndDate set to graduationdate, can be changed if they dropped out
            EndDate = graduationdate;
            status = Status.New;
        }


        public override string ToString() 
        {
            return "Student ID: " + Id + ", Student name: " + GivenName + " " + Surname + ", Status: " + status.ToString() + ", StartDate: " + StartDate + ", EndDate: " + EndDate + ", GraduationDate: " + GraduationDate;
        }
    }

    public record immutablestudent
    {
        public Status status { get; init; }
        public int Id { get; init; }
        public String GivenName { get; init; }
        public String Surname { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public DateTime GraduationDate { get; init; }
        public immutablestudent()
        {
            EndDate = GraduationDate;
            status = Status.New;
        }

        public override string ToString() 
        {
            return "Student ID: " + Id + ", Student name: " + GivenName + " " + Surname + ", Status: " + status.ToString() + ", StartDate: " + StartDate + ", EndDate: " + EndDate + ", GraduationDate: " + GraduationDate;
        }
    }
}
