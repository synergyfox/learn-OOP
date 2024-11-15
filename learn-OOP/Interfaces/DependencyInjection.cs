

using System;
using System.Net;
using System.Reflection;

namespace learn_OOP.Interfaces
{

    //reasin we are using dependency injection is to make the code more flexible and reusable  like we can easily cook aany meal without modifiying the meal class


    /**    Key Concepts:**/
        //Constructor Injection: The cooking methods(Baking or Grilling) are injected into the meal classes(Pizza or Steak) via the constructor.
        //Loose Coupling: Pizza and Steak do not depend on specific cooking methods.The method is injected, making it easier to change the cooking process.

    public interface ICookingMethod
    {
        void Cook();
    }

    
    public class Baking : ICookingMethod
    {
        public void Cook()
        {
            Console.WriteLine("Baking the meal...");
        }
    }

    public class Grilling : ICookingMethod
    {
        public void Cook()
        {
            Console.WriteLine("Grilling the meal...");
        }
    }

    public interface IMeal
    {
        void PrepareMeal();
    }


    public class Pizza : IMeal
    {
        private readonly ICookingMethod _cookingMethod;
        
        public Pizza(ICookingMethod cookingMethod)
        {
            _cookingMethod = cookingMethod;
        }

        public void PrepareMeal()
        {
            Console.WriteLine("Preparing Pizza...");
            _cookingMethod.Cook();  
        }
    }

    public class Steak : IMeal
    {
        private readonly ICookingMethod _cookingMethod;

        public Steak(ICookingMethod cookingMethod)
        {
            _cookingMethod = cookingMethod;
        }

        public void PrepareMeal()
        {
            Console.WriteLine("Preparing Steak...");
            _cookingMethod.Cook();
        }
    }

}
