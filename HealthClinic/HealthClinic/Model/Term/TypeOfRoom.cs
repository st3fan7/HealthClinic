/***********************************************************************
 * Module:  TypeOfRoom.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Term.TypeOfRoom
 ***********************************************************************/

using System;

namespace Model.Term
{
    public class TypeOfRoom
    {
        private String nameOfType { get; set; }

        public TypeOfRoom()
        {
        }

        public TypeOfRoom(string nameOfType)
        {
            this.nameOfType = nameOfType;
        }
    }
}