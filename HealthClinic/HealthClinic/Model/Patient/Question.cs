/***********************************************************************
 * Module:  Question.cs
 * Author:  Hacer
 * Purpose: Definition of the Class Patient.Question
 ***********************************************************************/

using System;

namespace Model.Patient
{
    public class Question
    {
        private String questionText;
        private GradeOfQuestion answer;
        private int id;
       

        public string QuestionText { get => questionText; set => questionText = value; }
        public GradeOfQuestion Answer { get => answer; set => answer = value; }

        public Question(int id)
        {
            this.id = id;
        }

        public Question()
        {
        }

        public Question(string questionText, GradeOfQuestion answer)
        {
            this.QuestionText = questionText;
            this.Answer = answer;
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