using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForDesignPatterns.Patterns.Singleton
{
    /// <summary>
    /// Singleton class
    /// </summary>
    class Singleton
    {
        /// <summary>
        /// Cсылка на конкретный экземпляр данного объекта
        /// </summary>
        private static Singleton instance;

        /// <summary>
        /// Приватный конструктор, этот конструктор вызывается для создания объекта
        /// </summary>
        private Singleton()
        { }

        /// <summary>
        /// Создание объекта, если объкт отсутствуют
        /// </summary>
        /// <returns></returns>
        public static Singleton getInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }
}
