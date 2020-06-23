/***********************************************************************
 * Module:  IssueOfMedicaments.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Doctor.IssueOfMedicaments
 ***********************************************************************/

using HealthClinic.Repository;
using Model.PatientDoctor;
using System;
using System.Collections;

namespace Model.Doctor
{
    public class IssueOfMedicaments : IIdentifiable<int>
    {
        private String receipt;
        private int id;
        private MedicalRecord medicalRecord;
        private AllActors.Doctor doctor;
        public System.Collections.ArrayList medicament;

        public string Receipt { get => receipt; set => receipt = value; }
        public MedicalRecord MedicalRecord { get => medicalRecord; set => medicalRecord = value; }
        public AllActors.Doctor Doctor { get => doctor; set => doctor = value; }

        public IssueOfMedicaments(int id)
        {
            this.id = id;
        }

        public IssueOfMedicaments()
        {
        }

        public IssueOfMedicaments(int id, string receipt, MedicalRecord medicalRecord, AllActors.Doctor doctor, ArrayList medicament)
        {
            this.Receipt = receipt;
            this.id = id;
            this.MedicalRecord = medicalRecord;
            this.Doctor = doctor;
            this.medicament = medicament;
        }

        public IssueOfMedicaments(string receipt, MedicalRecord medicalRecord, AllActors.Doctor doctor, ArrayList medicament)
        {
            this.Receipt = receipt;
            this.MedicalRecord = medicalRecord;
            this.Doctor = doctor;
            this.medicament = medicament;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// Property for collection of Model.DoctorMenager.Medicament
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.ArrayList Medicament
        {
            get
            {
                if (medicament == null)
                    medicament = new System.Collections.ArrayList();
                return medicament;
            }
            set
            {
                RemoveAllMedicament();
                if (value != null)
                {
                    foreach (Model.DoctorMenager.Medicament oMedicament in value)
                        AddMedicament(oMedicament);
                }
            }
        }

        /// <summary>
        /// Add a new Model.DoctorMenager.Medicament in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddMedicament(Model.DoctorMenager.Medicament newMedicament)
        {
            if (newMedicament == null)
                return;
            if (this.medicament == null)
                this.medicament = new System.Collections.ArrayList();
            if (!this.medicament.Contains(newMedicament))
                this.medicament.Add(newMedicament);
        }

        /// <summary>
        /// Remove an existing Model.DoctorMenager.Medicament from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveMedicament(Model.DoctorMenager.Medicament oldMedicament)
        {
            if (oldMedicament == null)
                return;
            if (this.medicament != null)
                if (this.medicament.Contains(oldMedicament))
                    this.medicament.Remove(oldMedicament);
        }

        /// <summary>
        /// Remove all instances of Model.DoctorMenager.Medicament from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllMedicament()
        {
            if (medicament != null)
                medicament.Clear();
        }      

    }
}