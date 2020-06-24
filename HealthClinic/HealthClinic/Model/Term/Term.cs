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
       // private DateTime fromDateTime;
       // private DateTime toDateTime;

        protected static DateTime FromDateTime;
        protected static DateTime ToDateTime;

        public Term(DateTime fromDateTime, DateTime toDateTime)
        {
            FromDateTime = fromDateTime;
            ToDateTime = toDateTime;
        }

        public Term()
        {
            
        }
    }
}