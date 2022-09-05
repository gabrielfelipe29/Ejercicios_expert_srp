
using System;
namespace Library
{
    public class Doctor
    {
        public String Name { get; set; }
        public Doctor(string name)
        {

            if (!String.IsNullOrEmpty(name))
            {

                this.Name = name;

            }
            else
            {

                Console.WriteLine("El nombre del doctor no puede estar vacío.");

            }
        }


    }
}