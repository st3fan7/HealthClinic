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
        public static ViewTerm ConvertMedicalExaminationToMedicalExaminationView(MedicalExamination medicalExamination)
        {
            String[] dateTimeParts = medicalExamination.FromDateTime.ToString().Split(' ');
            // treba i vreme
            return new ViewTerm
            {
                Date = dateTimeParts[0],
                Time = medicalExamination.FromDateTime.ToString().Remove(medicalExamination.FromDateTime.ToString().Length - 3) + " - " + medicalExamination.ToDateTime.ToString().Remove(medicalExamination.ToDateTime.ToString().Length - 3),
                Room = medicalExamination.Room.RoomID,
                Doctor = medicalExamination.Doctor.Name + " " + medicalExamination.Doctor.Surname,
                Patient = medicalExamination.Patient.Name + " " + medicalExamination.Patient.Surname,
                Status = "Zauzet",
                Task = "Pregled",
                MakeInDoctor = false
            };

        }

        public static IList<ViewTerm> ConvertMedicalExaminationListToSurgeryViewList(IList<MedicalExamination> examinations)
            => ConvertEntityListToViewList(examinations, ConvertMedicalExaminationToMedicalExaminationView);
    }
}
