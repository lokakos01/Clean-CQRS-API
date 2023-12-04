using Application.Queries.Cats.GetAll;
using Domain.Models;
using Domain.Models.Animal;
using Infrastructure.Database;
using MediatR;

namespace Application.Queries.Cats
{
    internal sealed class GetAllCatsQueryHandler : IRequestHandler<GetAllCatsQuery, List<Cat>>
    {
        private readonly MockDatabase _mockDatabase;

        public GetAllCatsQueryHandler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }
        public Task<List<Cat>> Handle(GetAllCatsQuery request, CancellationToken cancellationToken)
        {
            List<Cat> allCatsFromMockDatabase = (List<Cat>)_mockDatabase.Cats;
            return Task.FromResult(allCatsFromMockDatabase);
        }
    }
}
