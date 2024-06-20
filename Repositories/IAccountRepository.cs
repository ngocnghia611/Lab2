using BusinessObjects.Model;

namespace Repositories
{
    public interface IAccountRepository
    {
        AccountMember GetAccountByID(string accountID);
    }
}
