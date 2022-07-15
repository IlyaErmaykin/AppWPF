using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForDesignPatterns.Patterns.CreationalPatterns.FactoryMethod
{
    public class FactoryMethodExample
    {
        public void RunFactoryMethod()
        {
            Developer dev;

            dev = new PanelDeveloper("ООО КирпичСтрой");
            var house2 = dev.Create();

            dev = new WoodDeveloper("Частный застрощик");
            var house = dev.Create();
        }
    }

    // Абстрактный класс строительной компании
    abstract class Developer
    {
        public string Name { get; set; }
        public Developer(string name)
        {
            Name = name;
        }
        //Фабричный метод
        abstract public House Create();
    }

    // Строит панельные дома
    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string name) : base(name) { }

        public override House Create()
        {
            return new PanelHouse();
        }
    }

    // Строит деревянные дома
    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string name) : base(name) { }

        public override House Create()
        {
            return new WoodHouse();
        }
    }

    abstract class House
    { }

    class PanelHouse : House 
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельный дом построен");
        }
    }

    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревянный дом построен");
        }
    }
}
