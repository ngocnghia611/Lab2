using BusinessObjects.Model;
using DataAccessLayer;
namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public AccountMember GetAccountByID(string accountID) => AccountDAO.GetAccountByID(accountID);
    }
}
