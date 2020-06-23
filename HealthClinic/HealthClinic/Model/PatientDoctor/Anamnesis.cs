// File:    Anamnesis.cs
// Author:  Stefan
// Created: subota, 16. maj 2020. 22:29:29
// Purpose: Definition of Class Anamnesis

using System;
using System.Collections;

namespace Model.PatientDoctor
{
    public class Anamnesis
    {
        private String description;
        public System.Collections.ArrayList diagnosis;
        public System.Collections.ArrayList symptoms;

        public string Description { get => description; set => description = value; }

        public Anamnesis()
        {
        }

        public Anamnesis(string description, ArrayList diagnosis, ArrayList symptoms)
        {
            this.Description = description;
            this.diagnosis = diagnosis;
            this.symptoms = symptoms;
        }

        /// <summary>
        /// Property for collection of Diagnosis
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.ArrayList Diagnosis
        {
            get
            {
                if (diagnosis == null)
                    diagnosis = new System.Collections.ArrayList();
                return diagnosis;
            }
            set
            {
                RemoveAllDiagnosis();
                if (value != null)
                {
                    foreach (Diagnosis oDiagnosis in value)
                        AddDiagnosis(oDiagnosis);
                }
            }
        }

        /// <summary>
        /// Add a new Diagnosis in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddDiagnosis(Diagnosis newDiagnosis)
        {
            if (newDiagnosis == null)
                return;
            if (this.diagnosis == null)
                this.diagnosis = new System.Collections.ArrayList();
            if (!this.diagnosis.Contains(newDiagnosis))
                this.diagnosis.Add(newDiagnosis);
        }

        /// <summary>
        /// Remove an existing Diagnosis from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveDiagnosis(Diagnosis oldDiagnosis)
        {
            if (oldDiagnosis == null)
                return;
            if (this.diagnosis != null)
                if (this.diagnosis.Contains(oldDiagnosis))
                    this.diagnosis.Remove(oldDiagnosis);
        }

        /// <summary>
        /// Remove all instances of Diagnosis from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllDiagnosis()
        {
            if (diagnosis != null)
                diagnosis.Clear();
        }


        /// <summary>
        /// Property for collection of Symptoms
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.ArrayList Symptoms
        {
            get
            {
                if (symptoms == null)
                    symptoms = new System.Collections.ArrayList();
                return symptoms;
            }
            set
            {
                RemoveAllSymptoms();
                if (value != null)
                {
                    foreach (Symptoms oSymptoms in value)
                        AddSymptoms(oSymptoms);
                }
            }
        }

        /// <summary>
        /// Add a new Symptoms in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddSymptoms(Symptoms newSymptoms)
        {
            if (newSymptoms == null)
                return;
            if (this.symptoms == null)
                this.symptoms = new System.Collections.ArrayList();
            if (!this.symptoms.Contains(newSymptoms))
                this.symptoms.Add(newSymptoms);
        }

        /// <summary>
        /// Remove an existing Symptoms from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveSymptoms(Symptoms oldSymptoms)
        {
            if (oldSymptoms == null)
                return;
            if (this.symptoms != null)
                if (this.symptoms.Contains(oldSymptoms))
                    this.symptoms.Remove(oldSymptoms);
        }

        /// <summary>
        /// Remove all instances of Symptoms from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllSymptoms()
        {
            if (symptoms != null)
                symptoms.Clear();
        }

    }
}