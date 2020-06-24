using HealthClinic.View.ViewModel;
using Model.DoctorMenager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.View.Converter
{
    class MedicamentConverter : AbstractConverter
    {
        public static ViewMedicament ConvertMedicamentToMedicamentView(Medicament medicament)
        {
            return new ViewMedicament
            {
                Code = medicament.Code,
                Name = medicament.Name,
                Producer = medicament.Producer,
                Quantity = medicament.Quantity,
                Ingredients = IngredientsToView(medicament)
            };
        }

        public static IList<ViewMedicament> ConvertMedicamentListToMedicamentViewList(IList<Medicament> medicaments)
            => ConvertEntityListToViewList(medicaments, ConvertMedicamentToMedicamentView);

        private static String IngredientsToView(Medicament medicament)
        {
            String ret = "";
            foreach (Ingredient ingredient in medicament.Ingredients)
            {
                ret += ingredient.Name + ", ";
            }
            return ret.Substring(0, ret.Length - 2);
        }
    }
}
