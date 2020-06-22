/***********************************************************************
 * Module:  Medicament.cs
 * Author:  Stefan
 * Purpose: Definition of the Class OtherClasses.Medicament
 ***********************************************************************/

using HealthClinic.Repository;
using System;
using System.Collections;

namespace Model.DoctorMenager
{
    public class Medicament : IIdentifiable<int>
    {
        private String code;
        private String name;
        private String producer;
        private State stateOfValidation;
        private int quantity;
        private int id;

        public System.Collections.ArrayList ingredient;

        public Medicament(string code, string name, string producer, State stateOfValidation, int quantity, int id, ArrayList ingredient)
        {
            this.code = code;
            this.name = name;
            this.producer = producer;
            this.stateOfValidation = stateOfValidation;
            this.quantity = quantity;
            this.id = id;
            Ingredient = ingredient;
        }
       
        /// <summary>
        /// Property for collection of Ingredient
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.ArrayList Ingredient
        {
            get
            {
                if (ingredient == null)
                    ingredient = new System.Collections.ArrayList();
                return ingredient;
            }
            set
            {
                RemoveAllIngredient();
                if (value != null)
                {
                    foreach (Ingredient oIngredient in value)
                        AddIngredient(oIngredient);
                }
            }
        }

        /// <summary>
        /// Add a new Ingredient in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddIngredient(Ingredient newIngredient)
        {
            if (newIngredient == null)
                return;
            if (this.ingredient == null)
                this.ingredient = new System.Collections.ArrayList();
            if (!this.ingredient.Contains(newIngredient))
                this.ingredient.Add(newIngredient);
        }

        /// <summary>
        /// Remove an existing Ingredient from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveIngredient(Ingredient oldIngredient)
        {
            if (oldIngredient == null)
                return;
            if (this.ingredient != null)
                if (this.ingredient.Contains(oldIngredient))
                    this.ingredient.Remove(oldIngredient);
        }

        /// <summary>
        /// Remove all instances of Ingredient from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllIngredient()
        {
            if (ingredient != null)
                ingredient.Clear();
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Producer
        {
            get { return producer; }
            set { producer = value; }
        }

        public State StateOfValidation
        {
            get { return stateOfValidation; }
            set { stateOfValidation = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

    }
}