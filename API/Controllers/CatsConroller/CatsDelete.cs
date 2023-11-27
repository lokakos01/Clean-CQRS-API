using MediatR;

namespace API.Controllers.CatsController
{
    public class CatsDelete : IRequest<bool>
    {
        public Guid CatId { get; }

        public CatsDelete(Guid catId)
        {
            CatId = catId;
        }
    }
}
