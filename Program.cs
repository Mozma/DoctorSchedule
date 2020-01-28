using System;
using System.Collections.Generic;

namespace DoctorSchedule
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //TODO: Создать генератор загруженности.
            //TODO: Создать массивы с именами и фамилиями.
            

            var doctors = new List<Doctor>();

            doctors.Add(new Doctor("Иван", "Иванов"));
            doctors.Add(new Doctor("Иван", "Иванов"));

            doctors[0].newPatient(new Patient("Петр", "Петров"), 10);

            if (!doctors[0].newPatient(new Patient("Петр", "Петрoв"), 10))
                Console.WriteLine("Добавлено");

            printScheduleCommand(doctors);

            Console.ReadLine();
        }


        public static void printScheduleCommand(List<Doctor> doctors)
        {
            Console.WriteLine(new string('=', 62));
            Console.WriteLine("{0,8}     | 8:00| 9:00|10:00|11:00|12:00|13:00|14:00|15:00|","ФИО");
            Console.WriteLine(new string('=',62));

            foreach (var doctor in doctors)
            {
                Console.Write("{0,13}|", doctor.getShortName());//, doctor.checkTime(9),checkTime(10)) ;

                for (var i = 8; i < 16; i++) {
                    Console.Write("{0,5}|", doctor.checkTime(i));
                }

                Console.Write("\n");
            }
            Console.WriteLine(new string('=', 62));
        }


        public static void startCommand(Doctor doc)
        {
            doc.printFullName();
            doc.printSchedule();
        }

        
    }
}
