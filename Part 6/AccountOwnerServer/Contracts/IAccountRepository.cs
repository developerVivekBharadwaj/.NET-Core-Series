using Entities.Models;

namespace Contracts
{
    public interface IAccountRepository
    {
        IEnumerable<Account> AccountsByOwner(Guid ownerId);

        Account GetAccountById(Guid id);

        void CreateAccount(Account account);

        void DeleteAccount(Account account);
    }
}
