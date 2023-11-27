using Application.Commands.Cats.UpdateCat;
using Application.Commands.Dogs.UpdateDog;
using Domain.Models;
using Domain.Models.Animal;
using Infrastructure.Database;
using MediatR;

namespace Application.Commands.Cats.UpdateCat
{
    internal class UpdateCatByIdCommandHandler : IRequestHandler<UpdateCatByIdCommand, Cat>
    {
        private readonly MockDatabase _mockDatabase;

        public UpdateCatByIdCommandHandler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }
        public Task<Cat> Handle(UpdateCatByIdCommand request, CancellationToken cancellationToken)
        {
            Cat catToUpdate = _mockDatabase.Cats.FirstOrDefault(cat => cat.Id == request.Id)!;

            catToUpdate.Name = request.UpdatedCat.Name;

            return Task.FromResult(catToUpdate);
        }
    }
}
