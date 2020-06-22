/***********************************************************************
 * Module:  Survey.cs
 * Author:  Hacer
 * Purpose: Definition of the Class Patient.Survey
 ***********************************************************************/

using HealthClinic.Repository;
using System;
using System.Collections;

namespace Model.Patient
{
    public class Survey : IIdentifiable<int>
    {
        private String title { get; set; }
        private DateTime publishingDate { get; set; }
        private String commentSurvey { get; set; }

        private int id;

        public Model.AllActors.Patient patient { get; set; }

        public System.Collections.ArrayList question;

        public Survey(int id)
        {
            this.id = id;
        }

        public Survey()
        {
        }

        public Survey(string title, DateTime publishingDate, string commentSurvey, int id, AllActors.Patient patient, ArrayList question)
        {
            this.title = title;
            this.publishingDate = publishingDate;
            this.commentSurvey = commentSurvey;
            this.id = id;
            this.patient = patient;
            this.question = question;
        }

        /// <summary>
        /// Property for collection of Question
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.ArrayList Question
        {
            get
            {
                if (question == null)
                    question = new System.Collections.ArrayList();
                return question;
            }
            set
            {
                RemoveAllQuestion();
                if (value != null)
                {
                    foreach (Question oQuestion in value)
                        AddQuestion(oQuestion);
                }
            }
        }

        /// <summary>
        /// Add a new Question in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddQuestion(Question newQuestion)
        {
            if (newQuestion == null)
                return;
            if (this.question == null)
                this.question = new System.Collections.ArrayList();
            if (!this.question.Contains(newQuestion))
                this.question.Add(newQuestion);
        }

        /// <summary>
        /// Remove an existing Question from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveQuestion(Question oldQuestion)
        {
            if (oldQuestion == null)
                return;
            if (this.question != null)
                if (this.question.Contains(oldQuestion))
                    this.question.Remove(oldQuestion);
        }

        /// <summary>
        /// Remove all instances of Question from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllQuestion()
        {
            if (question != null)
                question.Clear();
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