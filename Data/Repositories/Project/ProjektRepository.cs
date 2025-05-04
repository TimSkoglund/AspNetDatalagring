using Data.Context;
using Data.Entities;
using Data.Repositories.Base;

namespace Data.Repositories.Project;

public class ProjektRepository(DataContext ctx)
    : BaseRepository<ProjectEntity>(ctx), IProjektRepository
{ }
