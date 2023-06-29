namespace DesignPatternsSamples.Design_Patterns.Creational_Patterns
{
    /*
    According To : https://www.dofactory.com/net/abstract-factory-design-pattern
    The Builder design pattern separates the construction of a complex object from its representation so that the same construction process can create different representations.

    Frequency of use: medium-low

    Participants 
    The classes and objects participating in this pattern include:

    Builder  (VehicleBuilder)
        specifies an abstract interface for creating parts of a Product object
    ConcreteBuilder  (MotorCycleBuilder, CarBuilder, ScooterBuilder)
        constructs and assembles parts of the product by implementing the Builder interface
        defines and keeps track of the representation it creates
        provides an interface for retrieving the product
    Director  (Shop)
        constructs an object using the Builder interface
    Product  (Vehicle)
        represents the complex object under construction. ConcreteBuilder builds the product's internal representation and defines the process by which it's assembled
        includes classes that define the constituent parts, including interfaces for assembling the parts into the final result
    Structural code in C#

    This structural code demonstrates demonstrates the Builder pattern in which complex objects are created in a step-by-step fashion. The construction process can create different object representations and provides a high level of control over the assembly of the objects.
    */

    /// <summary>
    /// The 'Product' class
    /// </summary>
    public class Product
    {
        private readonly List<string> _parts = new();
        public void Add(string part)
        {
            _parts.Add(part);
        }
        public void Show()
        {
            foreach (string part in _parts)
                Console.WriteLine(part);
        }
    }
    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// </summary>
    class ConcreteBuilder1 : VehicleBuilder
    {
        private readonly Product _product = new();
        public override void BuildPartA()
        {
            _product.Add("PartA");
        }
        public override void BuildPartB()
        {
            _product.Add("PartB");
        }
        public override Product GetResult()
        {
            return _product;
        }
    }
    /// <summary>
    /// The 'ConcreteBuilder2' class
    /// </summary>
    class ConcreteBuilder2 : VehicleBuilder
    {
        private readonly Product _product = new();
        public override void BuildPartA()
        {
            _product.Add("PartX");
        }
        public override void BuildPartB()
        {
            _product.Add("PartY");
        }
        public override Product GetResult()
        {
            return _product;
        }
    }
    /// <summary>
    /// The 'Director' class
    /// </summary>
    public class Director
    {
        // Builder uses a complex series of steps
        public void Construct(VehicleBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>

    public abstract class VehicleBuilder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }


}
