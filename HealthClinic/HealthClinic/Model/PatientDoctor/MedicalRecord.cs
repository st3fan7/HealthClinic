/***********************************************************************
 * Module:  MedicalRecord.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Doctor.MedicalRecord
 ***********************************************************************/

using HealthClinic.Repository;
using System;
using System.Collections;

namespace Model.PatientDoctor
{
    public class MedicalRecord : IIdentifiable<int>
    {
        private int id;
        private AllActors.Patient patient;
        private Anamnesis anamnesis;
        public System.Collections.ArrayList allergies;
        public System.Collections.ArrayList medicament;

        public AllActors.Patient Patient { get => patient; set => patient = value; }
        public Anamnesis Anamnesis { get => anamnesis; set => anamnesis = value; }

        public MedicalRecord(int id)
        {
            this.id = id;
        }

        public MedicalRecord()
        {
        }

        public MedicalRecord(int id, AllActors.Patient patient, Anamnesis anamnesis, ArrayList allergies, ArrayList medicament) : this(id)
        {
            this.Patient = patient;
            this.Anamnesis = anamnesis;
            this.allergies = allergies;
            this.medicament = medicament;
        }

        public MedicalRecord(AllActors.Patient patient, Anamnesis anamnesis, ArrayList allergies, ArrayList medicament)
        {
            this.Patient = patient;
            this.Anamnesis = anamnesis;
            this.allergies = allergies;
            this.medicament = medicament;
        }

        public void Review()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Property for collection of Allergies
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.ArrayList Allergies
        {
            get
            {
                if (allergies == null)
                    allergies = new System.Collections.ArrayList();
                return allergies;
            }
            set
            {
                RemoveAllAllergies();
                if (value != null)
                {
                    foreach (Allergies oAllergies in value)
                        AddAllergies(oAllergies);
                }
            }
        }

        /// <summary>
        /// Add a new Allergies in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddAllergies(Allergies newAllergies)
        {
            if (newAllergies == null)
                return;
            if (this.allergies == null)
                this.allergies = new System.Collections.ArrayList();
            if (!this.allergies.Contains(newAllergies))
                this.allergies.Add(newAllergies);
        }

        /// <summary>
        /// Remove an existing Allergies from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveAllergies(Allergies oldAllergies)
        {
            if (oldAllergies == null)
                return;
            if (this.allergies != null)
                if (this.allergies.Contains(oldAllergies))
                    this.allergies.Remove(oldAllergies);
        }

        /// <summary>
        /// Remove all instances of Allergies from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllAllergies()
        {
            if (allergies != null)
                allergies.Clear();
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

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }
    }
}