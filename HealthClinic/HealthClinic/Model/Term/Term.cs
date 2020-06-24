/***********************************************************************
 * Module:  Termin.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Term.Termin
 ***********************************************************************/

using System;

namespace Model.Term
{
    public abstract class Term
    {
        private DateTime fromDateTime;
        private DateTime toDateTime;

        protected DateTime FromDateTime { get => fromDateTime; set => fromDateTime = value; }
        protected DateTime ToDateTime { get => toDateTime; set => toDateTime = value; }

        /*protected Term(DateTime fromDateTime, DateTime toDateTime)
        {
            this.fromDateTime = fromDateTime;
            this.toDateTime = toDateTime;
        }*/
    }
}