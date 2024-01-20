using System;
using System.Collections.Generic;
using System.Text;

namespace TruckDriver.Domain.Entitys.PedidosState
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class EnumDisplayNameAttribute : Attribute
    {
        public string DisplayName { get; private set; }

        public EnumDisplayNameAttribute(string displayName)
        {
            DisplayName = displayName;
        }
    }
}
