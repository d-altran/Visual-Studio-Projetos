using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {

            //PayPal payment = new PayPal();
            //Payonner payment = new Payonner();

            //payment.SendPayment();
            //payment.ReceivePayment();

            IPayPalPayment payment = new PayonnerAdapter(new Payonner());

            payment.PayPalPayment();
            payment.PayPalReceive();

            Console.ReadLine();
        }
    }
}
