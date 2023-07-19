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

namespace TruckDriver.Domain.Handlers
{
    public class PedidoHandler
    {
        private IPedidoRepository _repository;
        private ICepService _cepDistanceCalculator;
        private EnderecoHandler _enderecoHandler;        

        public PedidoHandler(IPedidoRepository reposotory, ICepService cepDistanceCalculator, EnderecoHandler enderecoHandler)
        {
            _repository = reposotory;
            _cepDistanceCalculator = cepDistanceCalculator;
            _enderecoHandler = enderecoHandler;

        }


        public ICommandResult Handle(CreatePedidoCommand command)
        {
            CreatePedidoCommandValidation validator = new CreatePedidoCommandValidation();
            ValidationResult result = validator.Validate(command);

            if (!result.IsValid)
                return new GenericCommandResult(false, MessageConstant.UNABLE_TO_CREATE, result.ToList());

            
            var resultEnderecoColeta = (GenericCommandResult)_enderecoHandler.Handle(command.Endereco_coleta);
            if (!resultEnderecoColeta.Success)
                return new GenericCommandResult(false, MessageConstant.UNABLE_TO_CREATE, resultEnderecoColeta.Erros);

            var resultEnderecoEntrega = (GenericCommandResult)_enderecoHandler.Handle(command.Endereco_entrega);
            if (!resultEnderecoEntrega.Success)
                return new GenericCommandResult(false, MessageConstant.UNABLE_TO_CREATE, resultEnderecoEntrega.Erros);


            Pedido pedido = new Pedido((Endereco)resultEnderecoColeta.Data, (Endereco)resultEnderecoEntrega.Data, _cepDistanceCalculator);

            PedidoValidation pedidoValidation = new PedidoValidation();
            ValidationResult resultPedido = pedidoValidation.Validate(pedido);

            if (!resultPedido.IsValid)
                return new GenericCommandResult(false, MessageConstant.UNABLE_TO_CREATE, resultPedido.ToList());
            

            pedido.Id = _repository.Creat(pedido);

            return new GenericCommandResult(true, MessageConstant.CREATED_SUCCESSFULLY, pedido);

        }

    }
}
