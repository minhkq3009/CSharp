using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.FinalTest.Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion(200, "Simba");
            Tiger tiger = new Tiger(180, "Sherkhan");

            lion.Show();
            tiger.Show();
        }
    }
}
