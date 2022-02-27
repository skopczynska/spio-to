using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account[] myAccounts = new Account[10];
            Account a = new Account();
            a.principal = 1.0;
            a.rate = 0.5;
            myAccounts[0] = a;
            a = new Account() { principal = 1.5, rate = 0.75 };
            
            double fee = calculateFee(myAccounts);
            Console.WriteLine(fee);
         
        }

        public static double calculateFee(Account[] accounts)
        {
            double totalFee = 0.0;
            Account account;
            for (int i = 0; i < accounts.Length; i++)
            {
                account = accounts[i];
                if (account.accountType == Account.PREMIUM || account.accountType == Account.PREMIUM_PLUS) totalFee += .0125 * ( // 1.25% broker's fee
              account.principal * Math.pow(account.rate, (account.daysActive / 365.25)) - account.principal); // interest-principal
            }
            return totalFee;
        }

    }
}
