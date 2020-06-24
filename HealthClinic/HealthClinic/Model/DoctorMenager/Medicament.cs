/***********************************************************************
 * Module:  Medicament.cs
 * Author:  Stefan
 * Purpose: Definition of the Class OtherClasses.Medicament
 ***********************************************************************/

using HealthClinic.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Documents;

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

        private List<Ingredient> ingredients;
        public List<Ingredient> Ingredients { get => ingredients; set => ingredients = value; }

        public Medicament(int id)
        {
            this.id = id;
        }

        public Medicament(int id, string code, string name, string producer, State stateOfValidation, int quantity, List<Ingredient> ingredients)
        {
            this.code = code;
            this.name = name;
            this.producer = producer;
            this.stateOfValidation = stateOfValidation;
            this.quantity = quantity;
            this.id = id;
            this.ingredients = ingredients;
        }

        public Medicament(string code, string name, string producer, State stateOfValidation, int quantity, List<Ingredient> ingredients)
        {
            this.code = code;
            this.name = name;
            this.producer = producer;
            this.stateOfValidation = stateOfValidation;
            this.quantity = quantity;
            this.ingredients = ingredients;
        }

        public Medicament(string name)
        {           
            this.name = name;         
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