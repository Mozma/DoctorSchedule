using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorSchedule
{
    class Program
    {
        static void Main(string[] args)
        {

            var doctor = new Doctor("Иван", "Иванович");

            doctor.newPatient(new Patient("Петр", "Петров"), 10);
            doctor.newPatient(new Patient("Петр", "Петрoв"), 10);
            doctor.printSchedule();

            Console.ReadLine();
        }
    }
}
