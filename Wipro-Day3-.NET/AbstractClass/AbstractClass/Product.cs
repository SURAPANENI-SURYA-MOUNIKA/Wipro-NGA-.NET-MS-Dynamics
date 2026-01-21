using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_3_AbstractClassesInAction
{
    abstract class Product : IDiscountTable
    //i am forced not to create object of product class
    {
        public int ProductID { get; set; } // getters and setters are used to access the private fields of a class
        public string ProductName { get; set; }

        public double CalculateDiscount(double price) //COMING FROM INTERFACE   
        {
            throw new NotImplementedException();
        }

        //Above declared properties are common for all products and is equivalent to normal class properties
        //like below normal private fields like below
        //private double price;

        //abstract method
        public abstract void DisplayProduct_Name_Details(); //no method body just declaration

        //canwe declared abstract method as private ? no we cannot declare abstract method as private
        //because private methods are not accessible outside the class

        //Normal method
        void displayProductDetailsonly()
        {
            Console.WriteLine("product name" + ProductName);
        }
    }
}

// can we have constructor in abstract class ? yes we can have constructor in abstract class
//Can we have firlds in abstract class ? yes we can have fields in abstract class


//When to use abstract class ?
//1. When we want to provide a common base class for other classes to inherit from.security purpose
//2. When we want to define a common interface for a group of related classes
//3. When we want to provide a default(partial) implementation for some methods and force derived classes to
//implement others.