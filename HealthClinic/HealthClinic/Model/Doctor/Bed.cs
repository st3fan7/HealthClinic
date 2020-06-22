/***********************************************************************
 * Module:  Krevet.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Term.Krevet
 ***********************************************************************/

using System;

namespace Model.Doctor
{
    public class Bed
    {
        private bool taken { get; set; }

        private int id;

        public Model.AllActors.Patient patient { get; set; }

        public Bed(int id)
        {
            this.id = id;
        }

        public Bed()
        {
        }

        public Bed(bool taken, int id, AllActors.Patient patient)
        {
            this.taken = taken;
            this.id = id;
            this.patient = patient;
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