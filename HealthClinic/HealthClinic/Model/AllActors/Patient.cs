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
      
      public MedicalRecord medicalRecord;
   
   }
}