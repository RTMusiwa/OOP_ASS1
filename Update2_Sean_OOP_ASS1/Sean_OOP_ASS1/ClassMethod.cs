using System;
using System.Collections.Generic;

namespace Sean_OOP_ASS1
{
    //A class for each country
    class Country
    {
        //Data members
        public string Name { get; private set; } = ""; //set envapsulation preventing country name and population assignment
        public float Population { get; private set; } = 0.0f;
        public int Vote = 0; //Public variable for reassigning out of this class

        //Object Constructor
        public Country(string name, float population)
        {
            Name = name;
            Population = population;
        }
    }
}