using BusinessObjects.Model;

namespace DataAccessLayer
{
    public class AccountDAO
    {
        public static AccountMember GetAccountByID(string accountID)
        {
            using var db = new MyStoreContext();
            return db.AccountMembers.FirstOrDefault(c => c.MemberId.Equals(accountID));
        }
    }
}
