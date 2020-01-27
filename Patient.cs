using System;


namespace DoctorSchedule
{
    class Patient : Person
    { 
        public int ID { get; set; }


        static Random rnd = new Random();
        public Patient(string name, string surname) : base(name, surname)
        {
            ID = rnd.Next(10000);
        }
    }
}
