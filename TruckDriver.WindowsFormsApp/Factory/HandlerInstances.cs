using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Handlers;
using TruckDriver.Domain.Repository;
using TruckDriver.Infra.ADO;
using TruckDriver.Infra.DAO;
using TruckDriver.Services.CepService;

namespace TruckDriver.WindowsFormsApp.Factory

{
    public static class HandlerInstances
    {

        public static UserHandler GetUserHandler()
        {
            IUserRepository userRepo = new UserRepository();

            return new UserHandler(userRepo);
        }

        public static PedidoHandler GetPedidoHandler()
        {

            EnderecoHandler enderecoHandler = GetEnderecoHandler();
            CepService cepService = new CepService();


            PedidoRepository pedidoRepo = new PedidoRepository();
            return new PedidoHandler(pedidoRepo, cepService, enderecoHandler);
        }

        public static EnderecoHandler GetEnderecoHandler() => new EnderecoHandler(new EnderecoRepository());


        public static MotoristaHandler GetMotoristaHandler()
        {
            EnderecoHandler enderecoHandler = GetEnderecoHandler();
            MotoristaRepository motoristaRepo = new MotoristaRepository();

            return new MotoristaHandler(motoristaRepo, enderecoHandler);
        }

    }

}
