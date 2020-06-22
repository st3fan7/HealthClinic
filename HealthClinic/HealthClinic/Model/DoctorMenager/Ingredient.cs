/***********************************************************************
 * Module:  Ingredient.cs
 * Author:  Stefan
 * Purpose: Definition of the Class DoctorMenager.Ingredient
 ***********************************************************************/

using System;

namespace Model.DoctorMenager
{
    public class Ingredient
    {
        private String name { get; set; }

        public Ingredient()
        {
        }

        public Ingredient(string name)
        {
            this.name = name;
        }
    }
}