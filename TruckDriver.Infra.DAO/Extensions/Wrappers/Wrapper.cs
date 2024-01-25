using System;
using System.Collections.Generic;
using System.Text;

namespace TruckDriver.Infra.ADO.Extensions.Wrappers
{
    internal abstract class Wrapper
    {
        protected string TABLE { get; set; } = "TABLE";
        public abstract IDictionary<string, string> Insert();
        public abstract IDictionary<string, string> Update();
        public abstract IDictionary<string, string> Delete();
        public abstract IDictionary<string, string> Select();

    }
}
