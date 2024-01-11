using Portfolio.Models;

namespace Portfolio.Services.Interfaces
{
    public interface IProjectsRepository
    {
        List<Proyecto> GetProjects();
    }
}
