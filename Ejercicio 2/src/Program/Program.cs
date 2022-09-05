using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            AppointmentService service = new AppointmentService();

           
            string appointmentResult = service.CreateAppointment(new Person("Steven Jhonson","5555-555-555"), "986782342", DateTime.Now, "Wall Street", new Doctor("Arnald"));
            Console.WriteLine(appointmentResult);



            string appointmentResult2 = service.CreateAppointment(new Person("Steven Jhonson","5555-555-555"), "", DateTime.Now, "Queen Street", new Doctor(""));
            Console.WriteLine(appointmentResult2);

            string appointmentResult3 = service.CreateAppointment(new Person("Steven Jhonson","5555-555-555"), "986782342", DateTime.Now, "Wall Street", new Doctor("Arnald"));
            Console.WriteLine(appointmentResult3);


        }
    }
}
