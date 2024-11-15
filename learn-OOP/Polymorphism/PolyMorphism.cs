

using System;

namespace learn_OOP.Polymorphism
{
    #region Overloading

   
    public class Calculator { 
    
     public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }

    }
    #endregion

    #region Overriding

   
    public class Shape    {
        
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    
    public class Circle : Shape
    {
        
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    // Derived class: Square
    public class Square : Shape
    {        
        public override void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }
    }
    #endregion
}
