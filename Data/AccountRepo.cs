using System.Collections.Generic;
using Challenge.Models;

namespace Challenge.Data
{
    public class AccountRepo : IAccountRepo
    {
        public void CreateAccount(Account cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAccount(Account cmd)
        {
            throw new System.NotImplementedException();
        }

        public Account GetAccountByUser(string user)
        {
            return new Account { User = "A", AccountBalance = 14000, DateOfPayment = "September 3, 2021", AmountOfPayment = 2000, Status = "Pending" };
        }

        public IEnumerable<Account> GetAllAccount()
        {
            var accounts = new List<Account>
            {
                new Account{User="A", AccountBalance=14000, DateOfPayment="September 3, 2021", AmountOfPayment=2000, Status="Pending"},
                new Account{User="A", AccountBalance=22000, DateOfPayment="September 2, 2021", AmountOfPayment=8000, Status="Success"},
                new Account{User="A", AccountBalance=24000, DateOfPayment="September 1, 2021", AmountOfPayment=2000, Status="Complete"},
                new Account{User="A", AccountBalance=26000, DateOfPayment="August 3, 2021", AmountOfPayment=2000, Status="Complete"},
                new Account{User="A", AccountBalance=34000, DateOfPayment="August 2, 2021", AmountOfPayment=8000, Status="Complete"},
                new Account{User="A", AccountBalance=36000, DateOfPayment="August 1, 2021", AmountOfPayment=2000, Status="Complete"},
                new Account{User="A", AccountBalance=38000, DateOfPayment="July 3, 2021", AmountOfPayment=2000, Status="Complete"},
                new Account{User="A", AccountBalance=38000, DateOfPayment="July 2, 2021", AmountOfPayment=8000, Status="Cancelled"},
                new Account{User="A", AccountBalance=40000, DateOfPayment="July 1, 2021", AmountOfPayment=2000, Status="Complete"},
            };

            return accounts;
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateAccount(Account cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}
