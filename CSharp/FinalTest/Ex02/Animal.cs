using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.FinalTest.Ex02
{
    internal class Animal
    {
        protected int weight;
        protected string name;

        public Animal(int weight, string name)
        {
            SetMe(weight, name);
        }

        public void SetMe(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Animal Name: {name}, Weight: {weight} kg");
        }
    }
}
