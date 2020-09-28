using MicroRabbit.Banking.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAccounts();

    }
}
