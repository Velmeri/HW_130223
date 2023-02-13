using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_130223
{
    internal abstract class Worker
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }

        public Worker(string name, string position, int experience)
        {
            Name = name;
            Position = position;
            Experience = experience;
        }

        public abstract void Print();
    }

    internal class President : Worker
    {
        public string Company { get; set; }

        public President(string name, string position, int experience, string company) : base(name, position, experience)
        {
            Company = company;
        }

        public override void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Position: President");
            Console.WriteLine("Experience: " + Experience + " years");
            Console.WriteLine("Company: " + Company);
        }
    }

    internal class Security : Worker
    {
        public string Department { get; set; }

        public Security(string name, string position, int experience, string department) : base(name, position, experience)
        {
            Department = department;
        }

        public override void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Position: Security");
            Console.WriteLine("Experience: " + Experience + " years");
            Console.WriteLine("Department: " + Department);
        }
    }

    internal class Manager : Worker
    {
        public string Department { get; set; }

        public Manager(string name, string position, int experience, string department) : base(name, position, experience)
        {
            Department = department;
        }

        public override void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Position: Manager");
            Console.WriteLine("Experience: " + Experience + " years");
            Console.WriteLine("Department: " + Department);
        }
    }

    internal class Engineer : Worker
    {
        public string Specialization { get; set; }

        public Engineer(string name, string position, int experience, string specialization) : base(name, position, experience)
        {
            Specialization = specialization;
        }

        public override void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Position: Engineer");
            Console.WriteLine("Experience: " + Experience + " years");
            Console.WriteLine("Specialization: " + Specialization);
        }
    }
}
