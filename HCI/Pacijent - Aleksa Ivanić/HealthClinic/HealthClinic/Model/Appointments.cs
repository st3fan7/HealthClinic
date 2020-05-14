using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.Model
{
    public class Appointments
    {
        private string termDate;
        private string termTime;
        private string doctor;

        public string Datum
        {
            get
            {
                return termDate;
            }
            set
            {
                if (value != termDate)
                {
                    termDate = value;
                }
            }
        }

        public string Termin
        {
            get
            {
                return termTime;
            }
            set
            {
                if (value != termTime)
                {
                    termTime = value;
                }
            }
        }

        public string Lekar
        {
            get
            {
                return doctor;
            }
            set
            {
                if (value != doctor)
                {
                    doctor = value;
                }
            }
        }
    }
}
