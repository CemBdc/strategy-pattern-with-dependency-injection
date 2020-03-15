using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StrategyPatternWithDI.Operations;

namespace StrategyPatternWithDI.Strategy
{
    public class CampaignStrategy: ICampaignStrategy
    {
        private readonly IEnumerable<ICampaign> _campaigns;

        public CampaignStrategy(IEnumerable<ICampaign> campaigns)
        {
            _campaigns = campaigns;
        }

        public ICampaign Resolve(CampaignTypes campaignType)
        {
            var campaign = _campaigns.FirstOrDefault(p => p.CampaignTypes == campaignType);

            if(campaign is null)
            {
                throw new ArgumentNullException(nameof(campaignType));
            }

            return campaign;
        }
    }
}
