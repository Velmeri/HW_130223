using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_130223
{
    internal abstract class MusicalInstrument
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public MusicalInstrument(string name, string description)
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

        public abstract void History();
    }

    internal class Violin : MusicalInstrument
    {
        public Violin(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("The violin produces a rich and warm sound.");
        }

        public override void History()
        {
            Console.WriteLine("The violin is believed to have originated in Italy in the 16th century.");
        }
    }

    internal class Trombone : MusicalInstrument
    {
        public Trombone(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("The trombone produces a deep and powerful sound.");
        }

        public override void History()
        {
            Console.WriteLine("The trombone is believed to have originated in the Renaissance period in Europe.");
        }
    }

    internal class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("The ukulele produces a bright and cheerful sound.");
        }

        public override void History()
        {
            Console.WriteLine("The ukulele is believed to have originated in Portugal and was introduced to Hawaii in the 19th century.");
        }
    }

    internal class Cello : MusicalInstrument
    {
        public Cello(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("The cello produces a rich and warm sound.");
        }

        public override void History()
        {
            Console.WriteLine("The cello is believed to have originated in the Renaissance period in Europe.");
        }
    }
}
