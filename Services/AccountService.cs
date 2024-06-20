using BusinessObjects.Model;
using Repositories;

namespace Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository iAccountRepository;
        public AccountService()
        {
            iAccountRepository = new AccountRepository();
        }
        public AccountMember GetAccountByID(string accountID)
        {
            return iAccountRepository.GetAccountByID(accountID);
        }

    }
}
