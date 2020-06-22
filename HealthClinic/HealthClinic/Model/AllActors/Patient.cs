/***********************************************************************
 * Module:  Patient.cs
 * Author:  Stefan
 * Purpose: Definition of the Class AllActors.Patient
 ***********************************************************************/

using Model.PatientDoctor;
using System;

namespace Model.AllActors
{
    public class Patient : User
    {
        private Boolean guestAccount { get; set; }

        public MedicalRecord medicalRecord { get; set; }

        public Patient()
        {
        }

        public Patient(bool guestAccount, MedicalRecord medicalRecord)
        {
            this.guestAccount = guestAccount;
            this.medicalRecord = medicalRecord;
        }
    }
}