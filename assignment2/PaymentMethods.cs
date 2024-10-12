using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class PaymentMethods
    {
        public IProcessable choose(int num)
        {
            switch (num)
            {
                case 1:
                    CreditCardPayment c=new CreditCardPayment();
                    return c;
                    
                case 2:
                    BankTransfer p = new BankTransfer();
                    return p;
                    
                case 3:
                    PayPal pa = new PayPal();
                    return pa;
                default:
                    return null;
                   

            }
        }
        public void pay(IProcessable p)
        {

        }
    }
    public interface IProcessable
    {
        public void Process();
    }
    public class CreditCardPayment:IProcessable
    {
        public void Process() { }
    }
    public class BankTransfer:IProcessable
    {
        public void Process() { }
    }
    public class PayPal:IProcessable
    {
        public void Process() { }
    }
}
