namespace DesignPatternsSamples.Design_Patterns.Creational_Patterns
{
    public interface IPrototype
    {
        IPrototype? Clone();
    }

    public class ConcretePrototype1 : IPrototype
    {
        public ConcretePrototype1(string? member)
        {
            this.Member = member;
        }

        public string? Member { get; }

        public IPrototype? Clone() => (IPrototype)this.MemberwiseClone();

    }

    public class ConcretePrototype2 : IPrototype
    {
        public ConcretePrototype2(string? member)
        {
            this.Member = member;
        }

        public string? Member { get; }
        public IPrototype? Clone() => (IPrototype)this.MemberwiseClone();
    }
}
