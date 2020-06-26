using HealthClinic.View.ViewModel;
using Model.Term;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.View.Converter
{
    class MedicalExaminationConverter : AbstractConverter
    {
        public static ViewMedicalExamination ConvertMedicalExaminationToMedicalExaminationView(MedicalExamination medicalExamination)
        {
            return new ViewMedicalExamination
            {
                Id = medicalExamination.GetId(),
                Patient = medicalExamination.Patient.Name + " " + medicalExamination.Patient.Surname,
                Doctor = medicalExamination.Doctor.Name + " " + medicalExamination.Doctor.Surname,
                ShortDescription = medicalExamination.ShortDescription,
                Room = medicalExamination.Room.RoomID,
                Urgency = medicalExamination.Urgency,
                Date = medicalExamination.FromDateTime.ToString("dd.MM.yyyy."),
                Time = medicalExamination.FromDateTime.ToString("HH:mm")

            };
        }

        public static IList<ViewMedicalExamination> ConvertMEListToMEViewList(IList<MedicalExamination> medicalExaminations)
            => ConvertEntityListToViewList(medicalExaminations, ConvertMedicalExaminationToMedicalExaminationView);

    }
}
