using MediatR;

namespace API.Controllers.DogsController
{
    public class DogsDelete: IRequest<bool>
    {
        public Guid DogId { get; }

        public DogsDelete(Guid dogId)
        {
            DogId = dogId;
        }
    }
}

