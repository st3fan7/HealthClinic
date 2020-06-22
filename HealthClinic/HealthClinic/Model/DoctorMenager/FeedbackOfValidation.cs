/***********************************************************************
 * Module:  FeedbackOfValidation.cs
 * Author:  Stefan
 * Purpose: Definition of the Class DoctorMenager.FeedbackOfValidation
 ***********************************************************************/

using System;

namespace Model.DoctorMenager
{
    public class FeedbackOfValidation
    {
        private String comment { get; set; }

        public FeedbackOfValidation()
        {
        }

        public FeedbackOfValidation(string comment)
        {
            this.comment = comment;
        }
    }
}