
using System;
using System.Text;

public class Person
{


    public String Name { get; set;}
    public String PhoneNumber { get; set;}
    public Person(String name, String phoneNumber)
    {
        bool isValid = true;
        StringBuilder message = new StringBuilder();

        if (String.IsNullOrEmpty(name))
        {

            isValid = false;
            message.Append("El nombre no puede estar vacío.\n");

        }


        if (String.IsNullOrEmpty(phoneNumber))
        {

            isValid = false;
            message.Append("El número de telefono no puede estar vacío.");

        }

        if (isValid)
        {

            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }
        else
        {
            Console.WriteLine(message);


        }

    }

}