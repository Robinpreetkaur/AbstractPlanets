////--------------------------------------
//// Author's Name : Robinpreet kaur
///  Author’s student number :301100296 
///  Date last Modified : 21 July,2020 
///  Program description : Assignment based on classes and interfaces of COMP-123 
///                       interfaces---IHabitable.cs,IHasMoons.cs,IHasRings.cs
///                       abstract class---Planet.cs
///                       subclasses----GiantPlant.cs and TerrestrialPlanet.cs
/// -----------------------------------------------------

using System;




namespace AbstractPlanets
{
    class Program
    {

       
        static void Main(string[] args)
        {
              
              Console.WriteLine("++++++ Giant Planet +++++"); 
              //creating object for GiantPlanet
             GiantPlanet giantPlanet = new GiantPlanet("Jupiter",139820,1.898E27,"gas");
             //  calling ToString Method for object created
            Console.WriteLine(giantPlanet.ToString());



            Console.WriteLine("+++++ Terrestrial Planet +++++");
            //creating object for TerrestrialPlanet
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 12742, 5.972e24,true);
            //calling ToString Method
            Console.WriteLine( terrestrialPlanet.ToString());

        }

        public void WaitForAnyKey()//other method to accept any key

        {
            
            Console.ReadKey();
        }


    }
}
