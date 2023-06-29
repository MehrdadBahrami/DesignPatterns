namespace SerializeMethodes
{
    internal class Program
    {
        static void Main()
        {
            #region Singleton
            var SingletonInstance = Worker.GetInstance;
            #endregion
            #region Abstract Factory
            AbstractFactoryRun();
            #endregion
            #region Builder
            BuilderRun();
            #endregion
            PrototypeRun();
            AdapterRun();
            Console.ReadLine();
        }
        public static void AbstractFactoryRun()
        {
            Console.WriteLine("----------------------------------------AbstractFactoryRun------------------------------------------");
            IUIFactory wuI = new WindowsUIFactory();
            IUIFactory muI = new MacUIFactory();
            new Client(wuI).RenderUI();
            new Client(muI).RenderUI();
            CreateSpace();


        }
        public static void BuilderRun()
        {
            Console.WriteLine("----------------------------------------BuilderRun--------------------------------------------------");
            // Create director and builders
            Director director = new();
            VehicleBuilder b1 = new ConcreteBuilder1();
            VehicleBuilder b2 = new ConcreteBuilder2();
            // Construct two products
            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();
            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();
            CreateSpace();
        }
        public static void PrototypeRun()
        {
            Console.WriteLine("----------------------------------------PrototypeRun------------------------------------------------");
            var p1 = new ConcretePrototype1("Mehrdad Clone1");
            var c1 = (ConcretePrototype1?)p1.Clone();

            Console.WriteLine(c1?.Member);

            var p2 = new ConcretePrototype1("Mehrdad Clone2");
            var c2 = (ConcretePrototype1?)p2.Clone();

            Console.WriteLine(c2?.Member);
            CreateSpace();
        }
        public static void AdapterRun()
        {
            Console.WriteLine("----------------------------------------Adapter-----------------------------------------------------");
            // Non-adapted chemical compound

            Compound unknown = new();
            unknown.Display();

            // Adapted chemical compounds

            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
            CreateSpace();
        }
        public static void Bridge()
        {
            Abstraction ab = new RefinedAbstraction();

            // Set implementation and call

            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            // Change implemention and call

            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();

            // Wait for user

            Console.ReadKey();
        }
        public static void CreateSpace()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}
