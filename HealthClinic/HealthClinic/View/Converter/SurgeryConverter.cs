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
            return new ViewTerm
            {
                Time = surgery.FromDateTime.ToString() + " - " + surgery.ToDateTime.ToString(),
                Room = surgery.Room.ToString(),
                Doctor = surgery.DoctorSpecialist.ToString(),
                Patient = surgery.Patient.ToString(),
                Status = "Zauzet",
                Task = "Operacija",
                MakeInDoctor = false
            };

        }

        public static IList<ViewTerm> ConvertSurgeryListToSurgeryViewList(IList<Surgery> surgeries)
            => ConvertEntityListToViewList(surgeries, ConvertSurgeryToSurgeryView);

        //private static String IngredientsToView(Surgery surgery)
        //{
        //    String ret = "";
        //    foreach (Ingredient ingredient in medicament.Ingredients)
        //    {
        //        ret += ingredient.Name + ", ";
        //    }
        //    return ret.Substring(0, ret.Length - 2);
        //}

    }
}
