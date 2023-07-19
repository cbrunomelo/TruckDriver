using System;
using TruckDriver.Domain.Commands.EnderecoCommands;
using TruckDriver.Domain.Commands.PedidosCommands;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Handlers;
using TruckDriver.Infra.ADO;
using TruckDriver.Services.CepService;

namespace TruckDriver.WindowsFormsApp.Formularios.ChildForms
{
    public partial class frm_Pedidos : ChildBase
    {

        private readonly PedidoHandler _pedidoHandler;
        public frm_Pedidos()
        {
            InitializeComponent();

            _pedidoHandler = new PedidoHandler(new PedidoRepository(new RepositoryBase<Pedido>()), new CepService(), new EnderecoHandler(new EnderecoRepository()));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreatePedidoCommand command = new CreatePedidoCommand()
            {
                Endereco_coleta = new CreateEnderecoCommand()
                {
                    Cep = "59628270",
                    logradouro = "Rua teste",
                    complemento = "teste",
                    bairro = "teste",
                    cidade = "teste",
                    estado = "teste"
                },
                Endereco_entrega = new CreateEnderecoCommand()
                {
                    Cep = "69006307",
                    logradouro = "Rua teste",
                    complemento = "teste",
                    bairro = "teste",
                    cidade = "teste",
                    estado = "teste"
                },
            };

            var result = _pedidoHandler.Handle(command);
        }
    }
}
