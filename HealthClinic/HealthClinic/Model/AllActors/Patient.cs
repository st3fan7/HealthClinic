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
        private Boolean guestAccount;

        private MedicalRecord medicalRecord;

        public bool GuestAccount { get => guestAccount; set => guestAccount = value; }
        public MedicalRecord MedicalRecord { get => medicalRecord; set => medicalRecord = value; }

        public Patient()
        {
        }

        public Patient(bool guestAccount, MedicalRecord medicalRecord)
        {
            this.GuestAccount = guestAccount;
            this.MedicalRecord = medicalRecord;
        }
    }
}