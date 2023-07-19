using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Handlers;
using TruckDriver.Domain.Queries;
using TruckDriver.Domain.Repository;
using TruckDriver.Infra.ADO;
using TruckDriver.Infra.DAO;

namespace TruckDriver.WindowsFormsApp.Repository
{
    public static class HandlerInstances
    {
        public static IUserRepository GetUserRepo() => new UserRepository(new RepositoryBase<User>());
        
        public static UserHandler GetUserHandler() => new UserHandler(GetUserRepo());

    }

}
