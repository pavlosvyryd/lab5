using lab4.DataModel;
using System.Collections.Generic;
using System.Linq;


namespace lab4
{
    public class BankData : DataSupertype
    {
        public List<Bank> GetAll()
        {
            return this.Context.Banks.ToList();
        }

        public List<Bank> FindByBankId(int bankId)
        {
            return this.Context.Banks.Where(p => p.bank_id == bankId).ToList();
        }

        public List<Bank> FindByBankName(string bankName)
        {
            return this.Context.Banks.Where(p => p.bank_name == bankName).ToList();
        }

        public List<Bank> FindByBankAmountOfClients(int bankAmountOfClients)
        {
            return this.Context.Banks.Where(p => p.bank_amount_of_clients == bankAmountOfClients).ToList();
        }

        public void AddBank(Bank bankToAdd)
        {
            this.Context.Banks.Add(bankToAdd);
            this.SaveChanges();
        }

        public void RemoveBank(Bank bankToRemove)
        {
            this.Context.Banks.Remove(bankToRemove);
            this.SaveChanges();
        }
    }
}
