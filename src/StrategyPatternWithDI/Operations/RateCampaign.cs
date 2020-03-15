using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternWithDI.Operations
{
    public class RateCampaign: ICampaign
    {
        public CampaignTypes CampaignTypes => CampaignTypes.Rate;

        public double Discount(double totalAmount, double discountAmount)
        {
            if (totalAmount <= 0)
                return 0;
            
            return totalAmount * (discountAmount * 0.01);
        }

        public bool IsValidCampaign(int quantity, int minQuantity)
        {
            return quantity >= minQuantity;
        }
    }
}
