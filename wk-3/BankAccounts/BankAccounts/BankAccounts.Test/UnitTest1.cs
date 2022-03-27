using Xunit;
using System;
using BankAccounts.App;

namespace Test.BankAccounts
{

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //ARRANGE - Any set up that is required to perform the test  
            //ACT - Where we invoke the behavior to test    
            //ASSERT - Compare the result of the ACT to an expected value

            Assert.Equal( true,true );
            //Assert.Equal(what we expect to get back, out control), (what we actually got back))
        }

        //Typical naming convention
        //UnitOfTest_TestCondition_CorrectBehavior
        [Fact]
        public void SavingAccount_CreatesavingAccount_ValidsavingsAccount()        
        {
            //ARRANGE
            string expected  = "testAccount";
            double savingAccountBalance = 1248.36;
            //ACT
            var account = new SavingAccount("testAccount", 1248.36);
            double actualAccountBalance = account.GetAccountBalance();

            //ASSERT
            Assert.Equal(account.accountName, expected);
            Assert.Equal(savingAccountBalance, actualAccountBalance);
        }

        [Fact]
        public void Transaction_CreateTransaction_ValidTransaction()
        {
            //ARRANGE
            DateTime time = DateTime.Now;

            //ACT
            Transaction tran = new Transaction(1500.00, time, "TestDeposit");

            //ASEERT
            Assert.Equal(tran.Date, time);

        }
        
        [Fact]
        public void Account_GetInterestRate_ReturnInterestRate()
        {
            //ARRANGE
            SavingAccount saving = new SavingAccount("Test", 10000);
            double expectInterestRate = 0.003;

            //ACT
            double actual = saving.GetInterestRate();

            //ASERT
            Assert.Equal( expectedInterestRate, actual);
        }

        [Fact]        
        public void Account_InvalidWithdrawl_allTransactionsLengthUnchanged()
        {
            //ARRANGE
             SavingAccount savings = new SavingsAccount("testAccount", 2000);
             int expectedAllTransactionLength = 1;

             //ACT
             savings.Withdrawl(3000);
             int actualAllTransactionCount = savings.GetTransactionsCount();

             //ASSERT
             Assert.Equal(expectedAllTransactionCount,actualAllTransactionCount);
        }   

        [Fact]        
        public void Account_ValidWithdrawl_allTransactionsLengthIncreased()
        {
            //ARRANGE
             SavingAccount savings = new SavingsAccount("testAccount", 2000);
             int expectedAllTransactionLength = 2;

             //ACT
             savings.Withdrawl(3000);
             int actualAllTransactionCount = savings.GetTransactionsCount();

             //ASSERT
             Assert.Equal(expectedAllTransactionCount,actualAllTransactionCount);
        }   

        [Fact]
        public void DummyTest_CharNotInString()
        {
            //This test is to expected experimentwith the Assert.DoesNotContain() method.
            //ARRANGE
            var expected = "&";
            string actual = "this string does not contain an ampersand.";

            //ACT

            //ASSERT
            Assert.DoesNotContain(expected, actal);
        }              
    }
}