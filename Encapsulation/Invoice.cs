using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Invoice
    {
        private int account;
        private string customer;
        private string provider;




        public Invoice(int account,string customer,string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;

        }

        public string Article { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }


        public double CostCaculation(bool needEdv)
        {
            if (needEdv==true)
            {
                return Price * (double)Quantity + Price * 0.18;

            }
            else
            {
                return Price * (double)Quantity;
            }
        }


    }
}
