using GiveChange.Domain.Entities;
using GiveChange.Domain.Interfaces.Repositories;
using GiveChange.Infra.Data.Context;

namespace GiveChange.Infra.Data.Repositories
{
    public class TrocoRepository : BaseRepository<Troco>, ITrocoRepository
    {
        public TrocoRepository(GiveChangeContext giveChangeContext) : base(giveChangeContext)
        {
        }        
       

    }
}
