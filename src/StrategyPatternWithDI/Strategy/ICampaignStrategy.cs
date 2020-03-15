using StrategyPatternWithDI.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternWithDI.Strategy
{
    public interface ICampaignStrategy
    {
        ICampaign Resolve(CampaignTypes campaignTypes);
    }
}
