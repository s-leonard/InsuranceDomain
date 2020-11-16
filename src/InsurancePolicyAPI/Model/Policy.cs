using System;
using System.Collections.Generic;

namespace InsurancePolicyAPI.Model
{
    public class Policy
    {

        public string PolicyId { get; set; }
        public string PolicyNumber { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }


        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveTo { get; set; }
        public DateTime? RenewalDate { get; set; }

        public decimal Premium { get; set; }

        public Product Product { get; set; }
        public string PrimaryPolicyHolderId { get; set; }

        public IEnumerable<PolicyHolder> PolicyHolders { get; set; }

        

        public static Policy PopulateDummyPolicy(string id = "123")
        {
            
            Product prod = new Product()
            {
                ProductType = "Motor",
                Description = "Young drivers motor scheme",
                Name = "Motor Scheme ZGT",
                TermLengthMonths = 12
            };

            var ph = new PolicyHolder()
            {
                FirstName = "James",
                Surname = "Price",
                Id = "987"
            };

            var sd = DateTime.Now.AddDays(-15);
            var ed = DateTime.Now.AddYears(1).AddDays(-15);

            var p = new Policy()
            {
                PolicyId = id,
                PolicyNumber = $"AADM-{id}-GKSH",
                Status = "Live",
                Product = prod,
                Description = $"Policy - {prod.Description}",
                EffectiveFrom = new DateTime(sd.Year, sd.Month, sd.Day),
                EffectiveTo = new DateTime(ed.Year, ed.Month, ed.Day),
                PolicyHolders = new List<PolicyHolder> { ph },
                PrimaryPolicyHolderId = ph.Id,
                Premium = 560
            };

            return p;
        }
    }
}
