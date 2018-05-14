using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes) {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
