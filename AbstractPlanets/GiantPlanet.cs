using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPlanets
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {

        //Private Instance Variables

        private string m_type;


        //Constructor

        public GiantPlanet(string name, double diameter, double mass, string type): base(name, diameter,mass)
        
        {
            m_type = type;
        }

        //public methods
        public bool HasMoons()
        {
            bool  hasMoons = MoonCount > 0 ? true: false;
            return hasMoons;
        }


        public bool HasRings()
        {
            bool hasRings = RingCount > 0 ? true : false;
            return hasRings;
        }



    }
}
