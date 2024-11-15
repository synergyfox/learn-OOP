using System;

namespace learn_OOP.Interfaces
{
    /**
     * Key Features of Interfaces:
No Implementation:
An interface only contains method and property signatures, without any implementation.

Multiple Inheritance:
A class or struct can implement multiple interfaces, which allows for greater flexibility in design.

Method Signatures:
Interfaces can declare methods, properties, events, and indexers, but without any implementation.

Polymorphism: 
Interfaces allow different classes to provide their own implementations of the methods defined in the interface, supporting polymorphism.
    **/

    #region Simple Interface

    public interface IDrawable
    {
        void Draw(); // Method declaration without body
    }

    public class Rectangle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Rectangle.");
        }
    }

    public class Line : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Line.");
        }
    }
    #endregion


    #region Multiple Inheritance
    public interface IArithmeticOperations
    {
        double Add(double a, double b);
        double Subtract(double a, double b);
        double Multiply(double a, double b);
        double Divide(double a, double b);
    }

    public interface IScientificOperations
    {
        double SquareRoot(double a);
        double Power(double baseNumber, double exponent);
    }

    public class AdvancedCalculator : IArithmeticOperations, IScientificOperations
    {
        // Implementing IArithmeticOperations methods
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("Cannot divide by zero");
            return a / b;
        }

        // Implementing IScientificOperations methods
        public double SquareRoot(double a)
        {
            if (a < 0)
                throw new ArgumentException("Cannot calculate the square root of a negative number");
            return Math.Sqrt(a);
        }

        public double Power(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }
    }

    public class SimpleCalculator : IArithmeticOperations
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("Cannot divide by zero");
            return a / b;
        }
    }
    #endregion


}
