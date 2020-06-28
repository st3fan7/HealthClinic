using HealthClinic.View.ViewModel;
using Model.Term;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.View.Converter
{
    class SurgeryConverter : AbstractConverter
    {

        public static ViewSurgery ConvertSurgetyToSurgeryView(Surgery surgery)
        {
            return new ViewSurgery
            {
                Id = surgery.GetId(),
                Patient = surgery.Patient.Name + " " + surgery.Patient.Surname,
                Doctor = surgery.DoctorSpecialist.Name + " " + surgery.DoctorSpecialist.Surname,
                ShortDescription = surgery.ShortDescription,
                Room = surgery.Room.RoomID,
                Urgency = surgery.Urgency,
                Date = surgery.FromDateTime.ToString("dd.MM.yyyy."),
                Time = surgery.FromDateTime.ToString("HH:mm")

            };
        }

        public static IList<ViewSurgery> ConvertMEListToMEViewList(IList<Surgery> surgeries)
            => ConvertEntityListToViewList(surgeries, ConvertSurgetyToSurgeryView);

    }
}
