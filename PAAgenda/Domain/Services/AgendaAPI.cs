using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PAAgenda.Domain.Services
{
    using PAAgenda.Domain.Model;
    public interface AgendaAPI
    {
        [Post("/agenda")]
        Task<Agenda> Salvar([Body] Agenda agenda);

        [Put("/agenda")]
        Task<Agenda> Editar([Body] Agenda agenda);

        [Delete("/agenda/{idAgenda}")]
        Task<Agenda> Excluir(int idAgenda);

        [Get("/agenda")]
        Task<IEnumerable<Agenda>> Listar();

        [Get("/agenda/numero/{numeroTelefone}")]
        Task<IEnumerable<Agenda>> ConsultarPorNumero(string numeroTelefone);

        [Get("/agenda/nome/{nome}")]
        Task<IEnumerable<Agenda>> ConsultarPorNome(string nome);
    }
}
