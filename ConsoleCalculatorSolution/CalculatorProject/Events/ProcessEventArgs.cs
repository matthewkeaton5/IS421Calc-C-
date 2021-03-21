using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject.Events
{
    public class ProcessEventArgs : EventArgs
    {
        public string operation { get; set; }
        public bool IsSuccessful { get; set; }
        public DateTime CompletionTime { get; set; }
    }
}
