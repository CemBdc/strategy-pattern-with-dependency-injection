using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternWithDI.Operations
{
    public class AmountCampaign: ICampaign
    {
        public CampaignTypes CampaignTypes => CampaignTypes.Amount;

        public double Discount(double totalAmount, double discountAmount)
        {
            if (totalAmount <= 0)
                return 0;

            return totalAmount - discountAmount;
        }

        public bool IsValidCampaign(int quantity, int minQuantity)
        {
            return quantity >= minQuantity;
        }
    }
}
