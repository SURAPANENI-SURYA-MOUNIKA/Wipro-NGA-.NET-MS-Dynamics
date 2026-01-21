// See https://aka.ms/new-console-template for more information
using Demo_3_AbstractClassesInAction;

Console.WriteLine("Hello, World!");

ElectronicProduct newObj1 = new ElectronicProduct(); // creating object of child class
newObj1.ProductID = 101;
newObj1.ProductName = "Smart TV";
newObj1.DisplayProduct_Name_Details(); // calling the overridden method from abstract class
newObj1.ShowElectronicProductDetails(); // calling the method from child class

//Interface can be used for creating reference variable that can point to any class that implements the interface
IDiscountTable discountTable1 = new ElectronicProduct(); // creating interface reference variable
double discount1 = discountTable1.CalculateDiscount(50000); // calling the method from interface
Console.WriteLine("Discount on Electronic Product: " + discount1);

FurnitureProduct newObj2 = new FurnitureProduct(); // creating object of child class
newObj2.ProductID = 201;
newObj2.ProductName = "Sofa Set";
newObj2.DisplayProduct_Name_Details(); // calling the overridden method from abstract class
newObj2.ShowFurnitureProductDetails(); // calling the method from child class

Console.WriteLine("Abstract class in action ");

//Abstract class in C# has following properties :
//1. An abstract class is declared using the abstract keyword.
//2. It can have abstract methods (without implementation) as well as concrete methods (with implementation).
//3. An abstract class cannot be instantiated( process of creating object) directly.
//4. A class that inherits from an abstract class must implement all its abstract methods unless
//the derived class is also abstract.




//Ex Product class which is inherited by electronic product and furniture product


class ElectronicProduct : Product // inheriting the abstract class for using its properties and methods
{
    public override void DisplayProduct_Name_Details() //overriding the abstract method
    {
        Console.WriteLine("Electronic Product Name: " + ProductName);
        Console.WriteLine("Electronic Product ID" + ProductID);
    }

    public void ShowElectronicProductDetails()
    {
        Console.WriteLine("This is an electronic product from child class .");
    }

    //defing function from interface
    public double CalculateDiscount(double price)
    {
        // Example discount calculation logic
        double discountRate = 0.1; // 10% discount
        return price * discountRate;
    }

}

class FurnitureProduct : Product
{
    public override void DisplayProduct_Name_Details() //overriding the abstract method
    {
        Console.WriteLine("Furniture Product Name: " + ProductName);
        Console.WriteLine("Furniture Product ID" + ProductID);
    }
    public void ShowFurnitureProductDetails()
    {
        Console.WriteLine("This is a furniture product from child class .");
    }
    //defing function from interface
    public double CalculateDiscount(double price)
    {
        // Example discount calculation logic
        double discountRate = 0.15; // 15% discount
        return price * discountRate;
    }
}