using StrategyPatternWithDI.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternWithDI
{
    public class App
    {
        private readonly ICampaignStrategy _campaignStrategy;

        public App(ICampaignStrategy campaignStrategy)
        {
            _campaignStrategy = campaignStrategy;
        }

        public void Run()
        {
            var campaign = _campaignStrategy.Resolve(CampaignTypes.Amount);
            var isValidCampaign = campaign.IsValidCampaign(10, 8);
            var discount = campaign.Discount(1500, 300);

            Console.WriteLine($"CampaignType: {campaign.CampaignTypes}");
            Console.WriteLine($"Total Amount: {1500}, Discount Amount: {300}");
            Console.WriteLine($"Is Valid Campaign: {isValidCampaign}");
            Console.WriteLine($"Discount: {discount}");

            Console.WriteLine("-------------");

            campaign = _campaignStrategy.Resolve(CampaignTypes.Rate);
            isValidCampaign = campaign.IsValidCampaign(28, 12);
            discount = campaign.Discount(1500, 50);

            Console.WriteLine($"CampaignType: {campaign.CampaignTypes}");
            Console.WriteLine($"Total Amount: {1500}, Discount Amount: {50}");
            Console.WriteLine($"Is Valid Campaign: {isValidCampaign}");
            Console.WriteLine($"Discount: {discount}");

            Console.ReadLine();
        }
    }
}
