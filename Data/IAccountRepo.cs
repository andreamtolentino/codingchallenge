using System.Collections.Generic;
using Challenge.Models;

namespace Challenge.Data
{
    public interface IAccountRepo
    {
        bool SaveChanges();

        IEnumerable<Account> GetAllAccount();
        Account GetAccountByUser(string user);
        void CreateAccount(Account cmd);
        void UpdateAccount(Account cmd);
        void DeleteAccount(Account cmd);
    }
}