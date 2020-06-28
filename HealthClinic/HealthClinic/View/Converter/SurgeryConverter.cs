using Model.Term;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthClinic.View.ViewModel;

namespace HealthClinic.View.Converter
{
    class SurgeryConverter : AbstractConverter
    {
        public static ViewTerm ConvertSurgeryToSurgeryView(Surgery surgery)
        {
            String[] dateTimeParts = surgery.FromDateTime.ToString().Split(' ');

            return new ViewTerm
            {
                Id = surgery.GetId(),
                Date = dateTimeParts[0],
                Time = surgery.FromDateTime.ToString().Remove(surgery.FromDateTime.ToString().Length - 3) + " - " + surgery.ToDateTime.ToString().Remove(surgery.ToDateTime.ToString().Length - 3),
                Room = surgery.Room.RoomID,
                Doctor = surgery.DoctorSpecialist.Name + " " + surgery.DoctorSpecialist.Surname,
                Patient = surgery.Patient.Name + " " + surgery.Patient.Surname,
                Status = "Zauzet",
                Task = "Operacija",
                MakeInDoctor = false,
                PatientJMBG = surgery.Patient.Jmbg
            };

        }

        public static IList<ViewTerm> ConvertSurgeryListToSurgeryViewList(IList<Surgery> surgeries)
            => ConvertEntityListToViewList(surgeries, ConvertSurgeryToSurgeryView);


    }
}
