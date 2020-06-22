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
        private String receipt { get; set; }

        private int id;
        public PatientDoctor.MedicalRecord medicalRecord { get; set; }
        public AllActors.Doctor doctor { get; set; }

        public System.Collections.ArrayList medicament;

        public IssueOfMedicaments(int id)
        {
            this.id = id;
        }

        public IssueOfMedicaments()
        {
        }

        public IssueOfMedicaments(string receipt, int id, MedicalRecord medicalRecord, AllActors.Doctor doctor, ArrayList medicament)
        {
            this.receipt = receipt;
            this.id = id;
            this.medicalRecord = medicalRecord;
            this.doctor = doctor;
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