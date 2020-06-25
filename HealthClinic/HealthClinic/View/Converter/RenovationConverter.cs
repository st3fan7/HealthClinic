using HealthClinic.View.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.View.Converter
{
    class RenovationConverter : AbstractConverter
    {

        public static ViewRenovation ConvertRenovationToRenovationView(Model.Term.Renovation renovation)
        {
            return new ViewRenovation
            {
                Id = renovation.GetId(),
                Room = renovation.Room.RoomID,
                DataPeriod = renovation.FromDateTime.ToString() + " - " + renovation.ToDateTime.ToString(),
                Description = renovation.DescriptionOfRenovation
            };
        }

        public static IList<ViewRenovation> ConvertRenovationListToRenovationViewList(IList<Model.Term.Renovation> renovations)
            => ConvertEntityListToViewList(renovations, ConvertRenovationToRenovationView);
    }
}
