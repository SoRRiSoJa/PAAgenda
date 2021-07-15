using System.Collections.Generic;
using System.Threading.Tasks;

namespace PAAgenda.Domain.Repositories
{
    using PAAgenda.Domain.Model;
    public interface IAgendaRepository
    {
        Task<Agenda> Save(Agenda agenda);
        Task<Agenda> Update(Agenda agenda);
        Task<bool> Delete(int idAgenda);
        Task<IEnumerable<Agenda>> List();
        Task<IEnumerable<Agenda>> ListByNumber(string number);
        Task<IEnumerable<Agenda>> ListByName(string name);
    }
}
