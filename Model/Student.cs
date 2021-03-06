using System;
using System.Collections.Generic;


namespace Model
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Names { get; set; }
        public string Curp { get; set; }
        public DateTime Birthdate { get; set; }
        public bool Gender { get; set; }
        public int Discount { get; set; }
        public string Suburb { get; set; }
        public string Municipality { get; set; }
        public int Locality { get; set; }
        public string Disability { get; set; }
        public string Address { get; set; }

        IEnumerable<Tutor> Tutors { get; set; }
    }
}
