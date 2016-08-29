using System;
using System.Collections.Generic;

namespace CardAttendenceTracker
{
    public class Student
    {
        public enum AttendenceFlag
        {
            ABSENT, PRESENT, LATE
        }
        public string LastName
        {
            get; set;
        }
        public string FirstName
        {
            get; set;
        }
           public string Username
        {
            get; set;
        }
        public string CardNumber
        {
            get; set;
        }
        public Dictionary<DateTime,AttendenceFlag> Swipe
        {
            get;
        }

        public Student() : this(null, null, null, null) { }

        public Student(string last, string first, string user, string card)
        {
            LastName = last;
            FirstName = first;
            Username = user;
            CardNumber = card;
            Swipe = new Dictionary<DateTime, AttendenceFlag>();
        }

        public override string ToString()
        {
            return LastName + ", " + FirstName + " (" + Username + ")";
        }
    }
}
