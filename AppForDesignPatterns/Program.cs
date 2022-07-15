using AppForDesignPatterns.Patterns.CreationalPatterns.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Обзор пораждающих паттернов;
            // Фабричный метод;

            FactoryMethodExample factoryMethodExample = new FactoryMethodExample();
            factoryMethodExample.RunFactoryMethod();

            Console.ReadKey();
        }
    }
}
