using System;
using System.Collections.Generic;


namespace DoctorSchedule
{
    class Doctor : Person
    {
        static Random rnd = new Random();
        public int DoctorID { get; set; }

        private double WorkStart { get; set; }
        private double WorkEnd { get; set; }
        
        public Doctor(string name, string surname) : base(name, surname)
        {
            WorkStart = 8;
            WorkEnd = 16;
            DoctorID = rnd.Next(1000);

            createSchedule();
        }

        Dictionary<double, string> schedule = new Dictionary<double, string>();
        private void createSchedule()
        {
            double workTime = WorkEnd - WorkStart;
            for (var i = 0; i < workTime; i++)
            {
                schedule.Add(WorkStart + i, null);
            }
    
        }

        public void printSchedule()
        {
            foreach(var time in schedule)
            {
               

                Console.WriteLine("{0, 10}:00 - {1}", time.Key, time.Value);
            }
        }

        public void newPatient(Patient patient, double time) 
        {
           
            if (schedule[time] == null)
            {
                schedule[time] = $"{patient.Name} {patient.Surname} ({patient.ID})";
            }

        }
    
    }
}
