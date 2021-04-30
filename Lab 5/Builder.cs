using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    class Builder: people
    {
        private string CategoryS;
        public override void EnterCategory()
        {
            Console.WriteLine("Enter Category\n0: Junior\n1: Medium\n2: High\n3: Expert");
            int CategBuf = Convert.ToInt32(Console.ReadLine());
            CategoryS=($"{Enum.GetName(typeof(Category),CategBuf)}");
        }

        public override void StartWork()
        {
            base.StartWork();
        }

        public override void ShowCategory()
        {
            Console.WriteLine($"{CategoryS}");
        }

        public override void Profession()
        {
            Console.WriteLine("You are builder");
        }

    }
}
