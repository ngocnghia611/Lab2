using BusinessObjects.Model;

namespace Services
{
    public interface IAccountService
    {
        AccountMember GetAccountByID(string accountID);
    }
}
