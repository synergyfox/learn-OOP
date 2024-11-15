using learn_OOP.Abstraction;
using learn_OOP.Encapsulation;
using learn_OOP.Inheritance;
using learn_OOP.Interfaces;
using learn_OOP.Polymorphism;
using System;

namespace learn_OOP
{
    internal class Program
    {
        #region Inheritance

        
        public static void Run_Inheritance()
        {
           Grandfather grandfather = new Grandfather();            
            grandfather.WhoAmI();
            Console.WriteLine();
            

            Father father = new Father();            
            father.WhoAmI();
            Console.WriteLine();

            Son son = new Son();            
            son.WhoAmI();
            Console.WriteLine();

            Daughter daughter = new Daughter();
            daughter.WhoAmI("Daughter");
            Console.WriteLine();

            Console.ReadLine();

        }
        #endregion
        #region Abstraction
        public static void Run_Abstraction()
        {
          //  Vehicle vehicle = new Vehicle();


            Vehicle myCar = new Car();
            Vehicle myMotorcycle = new Motorcycle();


            myCar.StartEngine();
            myCar.DisplayType();

            myMotorcycle.StartEngine();
            myMotorcycle.DisplayType();

            Console.ReadLine();

        }

        #endregion
        #region Encapsulation
        public static void Run_Encapsulation()
        {
            
         Account account = new Account(10000,"Account Number","AbdulBasit","Current Account");
            account.Deposit(1000);
            account.Withdraw(500);
            Console.WriteLine("Account Balance: " + account.GetBalance());
            Console.ReadLine();


        }
        #endregion
        #region Interfaces

        public static void Run_Interface_Simple()
        {
            Rectangle rectangle = new Rectangle();
            Line line = new Line();
            line.Draw();
            rectangle.Draw();
            Console.ReadLine();
        }

        public static void Run_AdvancedCalculator()
        {
            AdvancedCalculator calculator = new AdvancedCalculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Subtract(1, 2));
            Console.WriteLine(calculator.Multiply(1, 2));
            Console.WriteLine(calculator.Divide(1, 2));
            Console.WriteLine(calculator.SquareRoot(4));
            Console.WriteLine(calculator.Power(2, 3));
            Console.ReadLine();
        }

    #endregion
        #region Polymorphism
    //Method Overloading
    public static void Run_Polymorphism_Overloading()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1.5, 2.5));
            Console.ReadLine();
        }

        public static void Run_Polymorphism_Overiding()
        {
            Shape myShape = new Shape();
            Shape myCircle = new Circle();
            Shape mySquare = new Square();

            myShape.Draw();  
            myCircle.Draw(); 
            mySquare.Draw();
            Console.ReadLine();

        }

        #endregion

        static void Main(string[] args)
            {

            // Run_Inheritance();
            // Run_Abstraction();
            //Run_Encapsulation();
            //Run_Polymorphism_Overloading();
            //Run_Polymorphism_Overiding();
            //Run_Interface_Simple();
            //Run_AdvancedCalculator();
        }
    }
}
