using System;
using System.Collections.Generic;
using System.IO;

namespace DoctorSchedule
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            var doctors = new List<Doctor>();

            genDoctors(doctors, 6);
            genPatient(doctors, 20);

            printScheduleCommand(doctors);

            Console.ReadLine();
        }

        private static void genPatient(List<Doctor> doctors, int amount)
        {
            
            string[] names = File.ReadAllLines("Names.txt");



            for (var i = 0; i < amount; i++)
            {
                var rnd1 = rnd.Next(doctors.Count);
                var time = rnd.Next(8, 16);

                var ind = rnd.Next(names.Length);
                var del = names[ind].LastIndexOf(" ");

                doctors[rnd1].newPatient(new Patient(names[ind].Substring(0, del), names[ind].Substring(del + 1)), time);
            }            
        }

        private static void genDoctors(List<Doctor> doctors, int amount)
        {
            string[] names = File.ReadAllLines("Names.txt");

           

            for (var i = 0; i < amount; i++)
            {
                var ind = rnd.Next(names.Length);
                var del = names[ind].LastIndexOf(" ");

                doctors.Add(new Doctor(names[ind].Substring(0, del), names[ind].Substring(del + 1)));
            }
        }

        public static void printScheduleCommand(List<Doctor> doctors)
        {
            Console.WriteLine(new string('=', 70));
            Console.WriteLine("{1,5}  |{0,8}     | 8:00| 9:00|10:00|11:00|12:00|13:00|14:00|15:00|","ФИО","ID");
            Console.WriteLine(new string('=', 70));

            foreach (var doctor in doctors)
            {
                Console.Write("{1,5}  |{0,13}|", doctor.getShortName(), doctor.ID);

                for (var i = 8; i < 16; i++) {
                    Console.Write("{0,5}|", doctor.checkTime(i));
                }

                Console.Write("\n");
            }
            Console.WriteLine(new string('=', 70));
        }
        public static void startCommand(Doctor doc)
        {
            doc.printFullName();
            doc.printSchedule();
        }
    }
}
