using Data.Context;
using Data.Entities;
using Data.Repositories.Base;

namespace Data.Repositories.StatusType;

public class StatusTypeRepository(DataContext ctx)
    : BaseRepository<StatusTypeEntity>(ctx), IStatusTypeRepository
{ }
