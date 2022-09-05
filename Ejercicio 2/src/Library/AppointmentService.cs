using System;
using System.Text;
using System.Linq;
using System.Collections;
namespace Library
{
    public class AppointmentService
    {
        /* 
        Si se añaden datos de la persona, debe cambiar AppointmentService. Si se añaden datos del doctor,
        debe cambiar AppointmentService. Por lo tanto, no cumple con srp. Como cada idenficador debe ser unico,
        en algun lugar se debe almacenar los ids. Se creo un arraylist dentro de appointmentservice, que funciona 
        como un gestor de agendas. También se creo la clase Doctor y la Clase persona porque en ambos se pueden agregar
        datos 

        */

        ArrayList IdList=new ArrayList();


        public AppointmentService(){

            this.IdList.Add("UNO");

        }

        public string CreateAppointment(Person person, string id, DateTime date, string appoinmentPlace, Doctor doctor)
        {


            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            String msg="";
            Boolean isValid = true;

            if (string.IsNullOrEmpty(person.Name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }
            else
            {
               
                if (IdList.Contains(id))
                {

                    isValid = false;
                    stringBuilder.Append("Unable to schedule appointment, 'id' is repeated\n");
                    
                }

            }

            if (string.IsNullOrEmpty(person.PhoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctor.Name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid==true)
            {
                IdList.Add(id);
                stringBuilder.Append("Appointment scheduled");
            }
            msg=stringBuilder.ToString();
                        
            return msg;
        }

    }
}
