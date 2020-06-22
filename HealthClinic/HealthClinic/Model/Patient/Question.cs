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
        private String questionText { get; set; }
        private GradeOfQuestion answer { get; set; }

        public Question()
        {
        }

        public Question(string questionText, GradeOfQuestion answer)
        {
            this.questionText = questionText;
            this.answer = answer;
        }
    }
}