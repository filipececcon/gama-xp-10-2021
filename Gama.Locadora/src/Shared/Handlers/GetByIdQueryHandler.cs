using System;
using Gama.Locadora.Shared.Entities;
using Gama.Locadora.Shared.Interfaces;
using Gama.Locadora.Shared.Requests;

namespace Gama.Locadora.Shared.Handlers
{
    public class GetByIdQueryHandler<TEntity> : QueryHandler<TEntity, GetByIdRequest, TEntity> where TEntity : Entity
    {
        public GetByIdQueryHandler(IQueryRepository<TEntity> repository) : base(repository)
        {
        }

        public override TEntity Handle(GetByIdRequest request)
        {
            return _repository.GetById(request.Id);
        }
    }
}
