using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForDesignPatterns.Patterns.Singleton
{
    /// <summary>
    /// SingletoneExample
    /// </summary>
    class SingletoneExample
    {
        /// <summary>
        /// Start singletone example
        /// </summary>
        public void Singletone()
        {
            Computer comp = new Computer();
            comp.Launch("Windows 8.1");
            Console.WriteLine(comp.OS.Name);

            //У нас не плолучилось изменить ОС, так как объект уже создан
            comp.OS = OS.getInstance("Windows 10");
            Console.WriteLine(comp.OS.Name);

            Console.ReadLine();
        }
    }

    /// <summary>
    /// Computer class
    /// </summary>
    class Computer
    {
        /// <summary>
        /// OS property
        /// </summary>
        public OS OS { get; set; }

        /// <summary>
        /// Launch function
        /// </summary>
        /// <param name="osName"></param>
        public void Launch(string osName)
        {
            OS = OS.getInstance(osName);
        }
    }

    /// <summary>
    /// OS class
    /// </summary>
    class OS
    {
        /// <summary>
        /// Instance field
        /// </summary>
        private static OS instance;

        /// <summary>
        /// Name property
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="name"></param>
        protected OS(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Get instance function
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Fiewld winth new instance value</returns>
        public static OS getInstance(string name)
        {
            if (instance == null)
                instance = new OS(name);
            return instance;
        }

    }
}