using System;
using System.Collections.Generic;
using System.Linq;
using Challenge.Models;

namespace Challenge.Data
{
    public class SqlAccountRepo : IAccountRepo
    {
        private readonly AccountContext _context;

        public SqlAccountRepo(AccountContext context)
        {
            _context = context;
        }

        public void CreateAccount(Account cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Account.Add(cmd);
        }

        public void DeleteAccount(Account cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.Account.Remove(cmd);
        }

        public Account GetAccountByUser(string user)
        {
            return _context.Account.FirstOrDefault(p => p.User == user);
        }

        public IEnumerable<Account> GetAllAccount()
        {
            return _context.Account.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateAccount(Account cmd)
        {
            //throw new NotImplementedException();
        }
    }
}