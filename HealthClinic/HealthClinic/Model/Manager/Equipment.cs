/***********************************************************************
 * Module:  Equipment.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Manager.Equipment
 ***********************************************************************/

using HealthClinic.Repository;
using System;

namespace Model.Manager
{
    public class Equipment : IIdentifiable<int>
    {
        private String code { get; set; }
        private String name { get; set; }
        private String typeOfEquipment { get; set; }
        private int amount { get; set; }

        private int id;

        public Equipment(int id)
        {
            this.id = id;
        }

        public Equipment()
        {
        }

        public Equipment(string code, string name, string typeOfEquipment, int amount, int id)
        {
            this.code = code;
            this.name = name;
            this.typeOfEquipment = typeOfEquipment;
            this.amount = amount;
            this.id = id;
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