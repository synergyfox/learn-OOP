using System;


namespace learn_OOP.Inheritance
{
    #region Example -1

    public class Grandfather
    {

        public Grandfather()
        {
            Console.WriteLine("Grandfather constructor");
        }

        public void WhoAmI()
        {
            Console.WriteLine("I am Grandfather");
            
        }

        ~Grandfather()
        {
            Console.WriteLine("Grandfather destructor");
        }
    }
        public class Father : Grandfather
    {
        public Father()
        {
            Console.WriteLine("Father constructor");
        }

        public void WhoAmI()
        {
            Console.WriteLine("I am Father");
        }

        public void WhoAmI(string IAM)
        {
            Console.WriteLine($"I am {IAM}");
        }


        ~Father()
        {
            Console.WriteLine("Father destructor");
        }
    }

    public class Son : Father
    {
        public Son()
        {
            Console.WriteLine("Son constructor");
        }

        public  void WhoAmI()
        {
            Console.WriteLine("I am Son");
        }

        ~Son()
        {
            Console.WriteLine("Son destructor");
        }
    }


    public class Daughter : Father
    {
        public Daughter()
        {
            Console.WriteLine("Daughter constructor");        
        }    
        
        ~Daughter()
        {
            Console.WriteLine("Daughter Destructor");
        }
    }
    #endregion





}
