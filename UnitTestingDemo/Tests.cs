using Bank;
using NUnit.Framework;
using System;

namespace UnitTestingDemo
{
    public class Tests
    {
        BankAccount newBankAccount = null;

        [SetUp]
        public void Setup()
        {
            newBankAccount = new BankAccount();
            Assert.Pass();
        }

        [Test]
        public void IsObjNull()
        {
            Assert.IsNull(newBankAccount);
        }

        [Test]
        public void AddBalance()
        {
            Random rnd = new Random();
            var amounthToAdd = rnd.Next(1, int.MaxValue);
            double oldBalance = newBankAccount.Balance;
            newBankAccount.AddBalance(amounthToAdd);
            Assert.AreEqual(amounthToAdd + oldBalance, newBankAccount.Balance);

        }

    }
}