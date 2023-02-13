using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_130223
{
    internal abstract class Device
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Device(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public abstract void Sound();

        public void Show()
        {
            Console.WriteLine("Name: " + Name);
        }

        public void Desc()
        {
            Console.WriteLine("Description: " + Description);
        }
    }

    internal class Teapot : Device
    {
        public Teapot(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("The teapot makes a whistling sound when boiling.");
        }
    }

    class Microwave : Device
    {
        public Microwave(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("The microwave makes a beeping sound when finished cooking.");
        }
    }

    internal class Car : Device
    {
        public Car(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("The car makes a honking sound when honking the horn.");
        }
    }

    internal class Steamboat : Device
    {
        public Steamboat(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("The steamboat makes a whistling sound when blowing its whistle.");
        }
    }
}
