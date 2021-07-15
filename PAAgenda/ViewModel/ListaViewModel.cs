using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAAgenda.ViewModel
{
    using PAAgenda.Domain.Model;
    using PAAgenda.Domain.Repositories;


    public class ListaViewModel
    {
        
        private readonly IAgendaRepository _agendaRepository;
        
        public Agenda Agenda { get; set; }
        public IList<Agenda> Lista { get; set; }

        public ListaViewModel()
        {
            _agendaRepository = (IAgendaRepository)Program.ServiceProvider.GetService(typeof(IAgendaRepository));
            Agenda = new Agenda() { Id=0};
        }
        public ListaViewModel(Agenda agenda)
        {
            _agendaRepository = (IAgendaRepository)Program.ServiceProvider.GetService(typeof(IAgendaRepository));
            Agenda = agenda;
        }

        public async Task Salvar() 
        {
            if (Agenda.Id==0) 
            {
                Agenda =await _agendaRepository.Save(Agenda);
            }
            else 
            {
                Agenda = await _agendaRepository.Update(Agenda);
            }
            
        }
        public async Task Delete()
        {
             await _agendaRepository.Delete(Agenda.Id);
        }
        public async Task UpdateList() 
        {
            var list = await _agendaRepository.List();
            Lista = list.Select((x) => x).OrderBy((x) => x.Nome).ToList();
        }
        public async Task UpdateListByNumber(string number)
        {
            var list = await _agendaRepository.ListByNumber(number);
            Lista = list.Select((x) => x).OrderBy((x)=>x.Nome).ToList();
        }
        public async Task UpdateListByName(string name)
        {
            var list = await _agendaRepository.ListByName(name);
            Lista = list.Select((x) => x).OrderBy((x) => x.Nome).ToList();
        }

    }
}
