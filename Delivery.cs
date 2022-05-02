using System;

namespace ConsoleApp5
{
    abstract class Delivery
    {
        protected string Adress { get; set; }
        public abstract string IndicateAddress();
        public virtual void SelectionCourierCompany() { }
    }
}
