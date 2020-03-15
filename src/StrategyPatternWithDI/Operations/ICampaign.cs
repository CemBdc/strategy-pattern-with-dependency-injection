using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternWithDI.Operations
{
    public interface ICampaign
    {
        CampaignTypes CampaignTypes { get; }
        bool IsValidCampaign(int quantity, int minQuantity);
        double Discount(double totalAmount, double discountAmount);
    }
}
