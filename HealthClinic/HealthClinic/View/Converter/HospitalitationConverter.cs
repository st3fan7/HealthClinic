using HealthClinic.View.ViewModel;
using Model.Term;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.View.Converter
{
    class HospitalitationConverter : AbstractConverter
    {
        public static ViewHospitalitation ConvertHospitalitationToHospitalitationView(Hospitalitation hospitalitation)
        {
            return new ViewHospitalitation
            {
                Id = hospitalitation.GetId(),
                FromDateTime = hospitalitation.FromDateTime.ToString().Remove(hospitalitation.FromDateTime.ToString().Length - 3),
                ToDateTime = hospitalitation.ToDateTime.ToString().Remove(hospitalitation.ToDateTime.ToString().Length - 3),
                Room = hospitalitation.Room.RoomID,
                Doctor = hospitalitation.Doctor.Name + " " + hospitalitation.Doctor.Surname,
                Patient = hospitalitation.BedForLaying.Patient.Name+ " " + hospitalitation.BedForLaying.Patient.Surname,
                Status = "Slobodan",
                PatientJMBG = hospitalitation.BedForLaying.Patient.Jmbg
            };

        }

        public static IList<ViewHospitalitation> ConvertHospitalitationListToHospitalitationViewList(IList<Hospitalitation> hospitalitations)
            => ConvertEntityListToViewList(hospitalitations, ConvertHospitalitationToHospitalitationView);
    }
}
