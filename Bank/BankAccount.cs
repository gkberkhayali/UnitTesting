namespace Bank
{
    public class BankAccount
    {
        public double Balance { get; set; }

        public bool AddBalance (double amount)
        {
            bool result = false;

            try
            {
                Balance = Balance + amount;
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public double GetBalance()
        {
            return Balance;
        }


    }
}