using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerRewards.Model.CustomModels
{
   public class CustomerTransactions
    {
        public int CustId { get; set; }
        public string FullName { get; set; }
        public int NumberOfTransactions { get; set; }
        public string Month { get; set; }
        public double TotalAmount { get; set; }
        public double RewardPoints { get; set; }
    }
}
