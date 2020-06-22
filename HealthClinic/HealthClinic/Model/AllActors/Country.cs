/***********************************************************************
 * Module:  State.cs
 * Author:  Stefan
 * Purpose: Definition of the Class AllActors.State
 ***********************************************************************/

using System;

namespace Model.AllActors
{
    public class Country
    {
        private String name { get; set; }
        private String code { get; set; }

        public Country()
        {
        }

        public Country(string name, string code)
        {
            this.name = name;
            this.code = code;
        }
    }
}