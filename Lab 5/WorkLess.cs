using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    class WotkLess:people
    {
        public override void StartWork()
        {
            Console.WriteLine("You cant start working without job");
        }
    }
}
