using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Entitys;

namespace TruckDriver.Domain.Queries
{
    public interface IUserQuery
    {

        User GetByName(string name);

    }

}
