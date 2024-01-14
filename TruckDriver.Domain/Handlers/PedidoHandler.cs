using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Commands;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Commands.PedidosCommands;
using TruckDriver.Domain.Commands.PedidosCommands.Validations;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain;
using TruckDriver.Domain.Extensions;
using TruckDriver.Domain.MessageConstants;
using TruckDriver.Domain.Repository;
using TruckDriver.Domain.Services;
using TruckDriver.Domain.Entitys.Validation;
using TruckDriver.Domain.Handlers.Contracts;
using System.Threading.Tasks;
using TruckDriver.Domain.Queries;

namespace TruckDriver.Domain.Handlers
{
    public class PedidoHandler : IPedidoHandle
    {
        private IPedidoRepository _repository;
        private ICepService _cepDistanceCalculator;
        private IEnderecoHandle _enderecoHandler;
        private IMotoristaQuery _motoristaQuery;
        private IEnderecoQuery _enderecoQuery;

        public PedidoHandler(IPedidoRepository reposotory, ICepService cepDistanceCalculator,
            IEnderecoHandle enderecoHandler, IMotoristaQuery motoristaQuery, IEnderecoQuery enderecoQuery)
        {
            _enderecoQuery = enderecoQuery;
            _motoristaQuery = motoristaQuery;
            _repository = reposotory;
            _cepDistanceCalculator = cepDistanceCalculator;
            _enderecoHandler = enderecoHandler;

        }


        public async Task<ICommandResult> Handle(CreatePedidoCommand command)
        {
            CreatePedidoCommandValidation validator = new CreatePedidoCommandValidation();
            ValidationResult result = validator.Validate(command);

            if (!result.IsValid)
                return new GenericCommandResult(false, MessageConstant.UNABLE_TO_CREATE, result.ToList());

            var resultEnderecoColetaTask = _enderecoHandler.Handle(command.Endereco_coleta);
            var resultEnderecoEntregaTask = _enderecoHandler.Handle(command.Endereco_entrega);


            var resultEnderecoColeta = await resultEnderecoColetaTask;
            if (!resultEnderecoColeta.Success)
                return new GenericCommandResult(false, MessageConstant.UNABLE_TO_CREATE, resultEnderecoColeta.Erros);

            var resultEnderecoEntrega = await resultEnderecoEntregaTask;
            if (!resultEnderecoEntrega.Success)
                return new GenericCommandResult(false, MessageConstant.UNABLE_TO_CREATE, resultEnderecoEntrega.Erros);


            Pedido pedido = new Pedido((Endereco)resultEnderecoColeta.Data, (Endereco)resultEnderecoEntrega.Data, 
                _cepDistanceCalculator, _motoristaQuery, _enderecoQuery);

            PedidoValidation pedidoValidation = new PedidoValidation();
            ValidationResult resultPedido = pedidoValidation.Validate(pedido);

            if (!resultPedido.IsValid)
                return new GenericCommandResult(false, MessageConstant.UNABLE_TO_CREATE, resultPedido.ToList());
            

            pedido.Id = _repository.Creat(pedido);

            return new GenericCommandResult(true, MessageConstant.CREATED_SUCCESSFULLY, pedido);

        }

        public async Task<ICommandResult> Handle(UpdatePedidoCommand command)
        {
            throw new NotImplementedException();
        }

        public async Task<ICommandResult> Handle(DeletePedidoCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
