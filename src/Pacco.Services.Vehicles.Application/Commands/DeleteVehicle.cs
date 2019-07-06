using System;
using Convey.CQRS.Commands;

namespace Pacco.Services.Vehicles.Application.Commands
{
    [Contract]
    public class DeleteVehicle : ICommand
    {
        public Guid Id { get; }
        
        public DeleteVehicle(Guid id)
            => Id = id;
    }
}