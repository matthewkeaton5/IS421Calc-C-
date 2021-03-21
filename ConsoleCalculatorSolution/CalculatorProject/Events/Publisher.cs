using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject.Events
{
    public class Publisher
    {
        public Action OnChange { get; set; }

        public void Raise()
        {
            if (OnChange != null)
            {
                OnChange();
            }
        }
    }
}
