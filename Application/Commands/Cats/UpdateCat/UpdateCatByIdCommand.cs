using Application.Dtos;
using Domain.Models;
using Domain.Models.Animal;
using MediatR;

namespace Application.Commands.Dogs.UpdateDog
{
    public class UpdateCatByIdCommand : IRequest<Cat>
    {
        public UpdateCatByIdCommand(CatDto updatedCat, Guid id)
        {
            UpdatedCat = updatedCat;
            Id = id;
        }

        public CatDto UpdatedCat { get; }
        public Guid Id { get; }
    }
}
