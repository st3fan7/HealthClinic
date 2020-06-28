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
                Name = patient.Name,
                Surname = patient.Surname,
                Jmbg = patient.Jmbg,
                DateOfBirthday = patient.DateOfBirth,
                City = patient.City.Name,
                Address = patient.City.Adress,
                Country = patient.City.Country.Name,
                PhoneNumber = patient.ContactNumber,
                EmailAddress = patient.EMail,
                Username = patient.UserName,
                Password = patient.Password,
                GuestAccount = patient.GuestAccount,
                MedicalRecord = patient.MedicalRecord.ToString()

            };
        }
        public static IList<ViewPatient> ConvertPatientListToPatientViewList(IList<Patient> patients)
            => ConvertEntityListToViewList(patients, ConvertPatientToPatientView);
    }
}
