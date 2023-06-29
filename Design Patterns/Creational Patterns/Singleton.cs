namespace DesignPatternsSamples.Design_Patterns.Creational_Patterns
{
    /*
     * According To : https://www.dofactory.com/net/singleton-design-pattern
        The Singleton design pattern ensures a class has only one instance and provide a global point of access to it.
        Frequency of use: medium-high
        The classes and objects participating in this pattern include:

            Singleton   (LoadBalancer)
            defines an Instance operation that lets clients access its unique instance. Instance is a class operation.
            responsible for creating and maintaining its own unique instance.

        This structural code demonstrates the Singleton pattern which assures only a single instance (the singleton) of the class can be created.
     
     */
    public sealed class Worker
    {

        private static volatile Worker? _Instance = null;
        private static readonly object _lock = new();
        private volatile bool _shouldStop;
        public volatile int Mehrdad = 0;
        public void RequestStop() => _shouldStop = true;
        private Worker() { }
        public static Worker GetInstance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (_lock)
                    {

                        _Instance ??= new Worker();
                    }
                }
                return _Instance;
            }
        }
        public async Task DoWorkAsync()
        {
            await Task.Run(() =>
            {

                while (!_shouldStop)
                {
                    // Do Something
                }
            });
        }
    }

}
