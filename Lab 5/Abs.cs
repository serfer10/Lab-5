using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    abstract class Abs
    {
        public enum Category
        {
            Junior, Medium, High, Expert
        }
        public abstract void EnterCategory();

        public abstract void StartWork();
    }
}
