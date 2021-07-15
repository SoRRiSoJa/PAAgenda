using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PAAgenda.Persistence.Repositories
{
    using PAAgenda.Config;
    using PAAgenda.Domain.Model;
    using PAAgenda.Domain.Repositories;
    using PAAgenda.Domain.Services;

    class AgendaRepository : IAgendaRepository
    {
        public async Task<IEnumerable<Agenda>> List()
        {
            try
            {
                string urlBase = VariableConfigurationExtensions.GetContatoAPI_URI();
                var agendaAPI = RestService.For<AgendaAPI>(urlBase);
                var novaAgenda = await agendaAPI.Listar();
                return novaAgenda;
            }
            catch 
            {
                throw new ApiException("Ocorreu um erro ao acesar a API, verifique se o serviço está disponível ou a variável de ambiente configurada.");
            }
        }
        public async Task<IEnumerable<Agenda>> ListByNumber(string number)
        {
            try
            {
                string urlBase = VariableConfigurationExtensions.GetContatoAPI_URI();
                var agendaAPI = RestService.For<AgendaAPI>(urlBase);
                var novaAgenda = await agendaAPI.ConsultarPorNumero(number);
                return novaAgenda;
            }
            catch 
            {
                throw new ApiException("Ocorreu um erro ao acesar a API, verifique se o serviço está disponível ou a variável de ambiente configurada.");
            }
        }
        public async Task<IEnumerable<Agenda>> ListByName(string name)
        {
            try
            {
                string urlBase = VariableConfigurationExtensions.GetContatoAPI_URI();
                var agendaAPI = RestService.For<AgendaAPI>(urlBase);
                var novaAgenda = await agendaAPI.ConsultarPorNome(name);
                return novaAgenda;
            }
            catch 
            {
                throw new ApiException("Ocorreu um erro ao acesar a API, verifique se o serviço está disponível ou a variável de ambiente configurada.");
            }
        }

        public async Task<Agenda> Save(Agenda agenda)
        {
            try
            {
                string urlBase = VariableConfigurationExtensions.GetContatoAPI_URI();
                var agendaAPI = RestService.For<AgendaAPI>(urlBase);
                var novaAgenda = await agendaAPI.Salvar(agenda);
                return novaAgenda;
            }
            catch 
            {
                throw new ApiException("Ocorreu um erro ao acesar a API, verifique se o serviço está disponível ou a variável de ambiente configurada.");
            }
        }
        public async Task<Agenda> Update(Agenda agenda)
        {
            try
            {
                string urlBase = VariableConfigurationExtensions.GetContatoAPI_URI();
                var agendaAPI = RestService.For<AgendaAPI>(urlBase);
                var novaAgenda = await agendaAPI.Editar(agenda);
                return novaAgenda;
            }
            catch 
            {
                throw new ApiException("Ocorreu um erro ao acesar a API, verifique se o serviço está disponível ou a variável de ambiente configurada.");
            }
        }
        public async Task<bool> Delete(int idAgenda)
        {
            try
            {
                string urlBase = VariableConfigurationExtensions.GetContatoAPI_URI();
                var agendaAPI = RestService.For<AgendaAPI>(urlBase);
                var novaAgenda = await agendaAPI.Excluir(idAgenda);
                return novaAgenda;
            }
            catch
            {
                throw new ApiException("Ocorreu um erro ao acesar a API, verifique se o serviço está disponível ou a variável de ambiente configurada.");
            }
        }
    }
}
