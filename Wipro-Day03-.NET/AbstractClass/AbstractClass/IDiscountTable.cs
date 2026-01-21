using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_3_AbstractClassesInAction
{
    internal interface IDiscountTable
    {
        //using this interafce we can implement discount table for products
        //so that we can have different discount strategies for different products

        double CalculateDiscount(double price);
        //These methods are by default public and abstract that means they are
        //customized by the implementing class



    }
}
//benefits of using interface over abstract class

//INterfaces are treated as a contract that defines a set of methods and properties that a class must implement
//1. Multiple inheritance : a class can implement multiple interfaces but can inherit from only one abstract class
//Class A : Interface1, Interface2
//Abstrct class B : AbstractClass1, AbstractClass2 // not allowed
//2. Flexibility : interfaces are more flexible as they allow to define a contract without any implementation details
//3. Loose coupling : interfaces promote loose coupling between classes as they define a contract that can be implemented by any class

//Ex practical use of INterface in simplementing security 
//1. Authentication and Authorization : interfaces can be used to define authentication and authorization mechanisms 
//for different types of users in an application
//2. Payment Gateway Integration : interfaces can be used to define payment gateway integration for different payment methods
//3. Logging and Auditing : interfaces can be used to define logging and auditing mechanisms for different types of events in an application