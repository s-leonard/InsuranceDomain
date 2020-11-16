using System;
using System.Collections.Generic;

namespace InsurancePolicyAPI.Model
{
    public class Policy
    {

        public string PolicyId { get; set; }
        public string PolicyNo { get; set; }
        public string Status { get; set; }


        public DateTime CoverStarts { get; set; }
        public DateTime PolicyEnd { get; set; }
        public DateTime? RenewalDate { get; set; }

        public decimal Amount { get; set; }

        public string ProductName { get; set; }
        public string ProductID { get; set; }
        public string ProductDesc { get; set; }


        public string PrimaryPolicyHolderId { get; set; }

        public string PolicyHolderName { get; set; }
        public string PolicyHolderLastName { get; set; }


        

        public static Policy PopulateDummyPolicy(string id = "987")
        {
            
         
            var sd = DateTime.Now.AddDays(5);
            var ed = DateTime.Now.AddYears(1).AddDays(5);

            var p = new Policy()
            {
                PolicyId = id,
                PolicyNo= $"POL-{sd.ToString("yyyyMMdd")}-{id}",
                ProductName = "Family Travel Pack (WW)",
                ProductDesc = "World wide annual family travel policy",
                CoverStarts = new DateTime(sd.Year, sd.Month, sd.Day),
                PolicyEnd = new DateTime(ed.Year, ed.Month, ed.Day),
                PrimaryPolicyHolderId = "KJKI8902",
                PolicyHolderName = "Jackie",
                PolicyHolderLastName = "Smith",
                Amount = 180,
                Status = "PendingPayment"
            };

            return p;
        }
    }
}
