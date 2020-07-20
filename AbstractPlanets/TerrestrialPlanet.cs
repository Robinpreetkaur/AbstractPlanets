﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPlanets
{
    class TerrestrialPlanet:Planet,IHasMoons,IHabitable
    {

        //Private instance variable
        private bool m_oxygen;


        //Constructor 

        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen): 
            base(name, diameter, mass)
        {
            m_oxygen = oxygen;

        }


        //Public Methods 

        public bool HasMoons()
        {
            bool hasMoons = MoonCount > 0 ? true : false;
            return hasMoons;
        }

        public bool Habitable()
        {
            bool isHabitable = m_oxygen == true ? true : false;
            return isHabitable;
        }





    }
}
