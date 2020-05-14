using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.Model
{
    public class Term
    {
        //public string termTime { get; set; }

        private string termTime;

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

    }
}
