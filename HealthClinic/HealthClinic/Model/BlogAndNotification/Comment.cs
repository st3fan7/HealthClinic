/***********************************************************************
 * Module:  Comment.cs
 * Author:  Hacer
 * Purpose: Definition of the Class Blog.Comment
 ***********************************************************************/

using System;

namespace Model.BlogAndNotification
{
   public class Comment : Content
   {
      private int id;
      
      public Model.AllActors.Doctor doctor;
      
      /// <summary>
      /// Property for Model.AllActors.Doctor
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Model.AllActors.Doctor Doctor
      {
         get
         {
            return doctor;
         }
         set
         {
            this.doctor = value;
         }
      }
      public Model.AllActors.Patient patient;
      
      /// <summary>
      /// Property for Model.AllActors.Patient
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Model.AllActors.Patient Patient
      {
         get
         {
            return patient;
         }
         set
         {
            this.patient = value;
         }
      }
   
   }
}