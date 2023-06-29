namespace DesignPatternsSamples.Design_Patterns.Creational_Patterns
{
    /*
        According To : https://www.dofactory.com/net/abstract-factory-design-pattern
        The Abstract Factory design pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.

        Frequency of use: high
        The classes and objects participating in this pattern include:

        AbstractFactory  (ContinentFactory)
            declares an interface for operations that create abstract products

        ConcreteFactory   (AfricaFactory, AmericaFactory)
            implements the operations to create concrete product objects

        AbstractProduct   (Herbivore, Carnivore)
            declares an interface for a type of product object

        Product  (Wildebeest, Lion, Bison, Wolf)
            defines a product object to be created by the corresponding concrete factory
            implements the AbstractProduct interface

        Client  (AnimalWorld)
            uses interfaces declared by AbstractFactory and AbstractProduct classes

         This structural code demonstrates the Abstract Factory pattern creating parallel hierarchies of objects. Object creation has been abstracted and there is no need for hard-coded class names in the client code.

    */
    #region https://www.dofactory.com/net/abstract-factory-design-pattern
    // Abstract Product A
    public interface IButton
    {
        void Render();
    }
    // Abstract Product B
    public interface ICheckbox
    {
        void Render();
    }
    // Abstract Factory
    public interface IUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }

    // Concrete Product A1
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Windows button.");
        }
    }
    // Concrete Product A2
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Mac button.");
        }
    }
    // Concrete Product B1
    public class WindowsCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Windows checkbox.");
        }
    }
    // Concrete Product B2
    public class MacCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Mac checkbox.");
        }
    }
    // Concrete Factory 1
    public class WindowsUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
    // Concrete Factory 2
    public class MacUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
    // Client
    public class Client
    {
        private readonly IButton button;
        private readonly ICheckbox checkbox;

        public Client(IUIFactory factory)
        {
            button = factory.CreateButton();
            checkbox = factory.CreateCheckbox();
        }

        public void RenderUI()
        {
            button.Render();
            checkbox.Render();
        }
    }
    #endregion
}
