

//Simply abstraction is a process of hiding unnecessary things from users or we can say just show the necessary things.
//    In a proper definition manner, we can say Abstraction is the process of showing only essential/necessary features 
//    of an entity/object to the outside world and hide the other irrelevant information.



/**Difference Between Abstract Class and Interface:
An abstract class can have both abstract and concrete methods, while an interface only defines the signatures of methods and does not provide any implementation.
A class can inherit from only one abstract class, but it can implement multiple interfaces.**/

using System;

namespace learn_OOP.Abstraction
{
        
    public abstract class Vehicle
    {        
        public abstract void StartEngine();
             
        public void DisplayType()
        {
            Console.WriteLine("This is a vehicle.");
        }
    }

    // Derived class (inheriting from Vehicle)
    public class Car : Vehicle
    {
        
        public override void StartEngine()
        {
            Console.WriteLine("The car engine is starting.");
        }
    }

    
    public class Motorcycle : Vehicle
    {
        
        public override void StartEngine()
        {
            Console.WriteLine("The motorcycle engine is starting.");
        }
    }

  


}
