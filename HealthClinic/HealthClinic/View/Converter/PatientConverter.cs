using HealthClinic.View.ViewModel;
using Model.AllActors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.View.Converter
{
    class PatientConverter : AbstractConverter
    {
        public static ViewPatient ConvertPatientToPatientView(Patient patient)
        {
            return new ViewPatient
            {
                Id = patient.GetId(),
                Username = patient.UserName,
                Password = patient.Password,
                Name = patient.Name,
                Surname = patient.Surname,
                Jmbg = patient.Jmbg,
                DateOfBirth = patient.DateOfBirth.ToString(),
                ContactNumber = patient.ContactNumber,
                EmailAddress = patient.EMail,
                City = patient.City.ToString(),
                GuestAccount = patient.GuestAccount,
                MedicalRecord = patient.MedicalRecord.ToString()
            };
        }
        public static IList<ViewPatient> ConvertPatientListToPatientViewList(IList<Patient> patients)
            => ConvertEntityListToViewList(patients, ConvertPatientToPatientView);
    }
}
