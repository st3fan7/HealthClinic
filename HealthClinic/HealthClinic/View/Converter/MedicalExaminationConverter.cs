using HealthClinic.View.Model;
using Model.Term;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.View.Converter
{
    class MedicalExaminationConverter
    {
        private const string DATETIME_FORMAT = "dd.MM.yyyy. HH:mm";

        public static MedicalExaminationView ConvertMedicalExaminationToMedicalExaminationView(MedicalExamination medicalExamination)
          => new MedicalExaminationView
          {
              Id = medicalExamination.GetId(),
              StartTime = DateTime.Parse(medicalExamination.FromDateTime.ToString(DATETIME_FORMAT)),
              EndTime = DateTime.Parse(medicalExamination.ToDateTime.ToString(DATETIME_FORMAT)),
              Doctor = "Dr " + medicalExamination.Doctor.Name + " " + medicalExamination.Doctor.Surname,
          };
    }
}
