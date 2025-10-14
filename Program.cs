using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Freezer freezer = new Freezer();
            freezer.TurnOn();
            freezer.SetTemp(-15);
            freezer.TurnOff();

            Lazer lazer = new Lazer();
            lazer.TurnOn();
            lazer.SetTemp(92);
            lazer.SetTarget(16, 98);
            lazer.TurnOff();

        }
    }
}