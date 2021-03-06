
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class Adwords
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("The name of your AdWords ad group.")]
            public static DataItem adGroup = new DataItem("adGroup");
                                      
            [DescriptionAttribute("The location of the advertisement on the hosting page (Top, RHS, or not set).")]
            public static DataItem adSlot = new DataItem("adSlot");
                                      
            [DescriptionAttribute("The ad slot positions in which your AdWords ads appeared (1-8).")]
            public static DataItem adSlotPosition = new DataItem("adSlotPosition");
                                      
            [DescriptionAttribute("The networks used to deliver your ads (Content, Search, Search partners, etc.).")]
            public static DataItem adDistributionNetwork = new DataItem("adDistributionNetwork");
                                      
            [DescriptionAttribute("The match types applied for the search term the user had input(Phrase, Exact, Broad, etc.). Ads on the content network are identified as Content network. Details: https://support.google.com/adwords/answer/2472708?hl=en")]
            public static DataItem adMatchType = new DataItem("adMatchType");
                                      
            [DescriptionAttribute("The match types applied to your keywords (Phrase, Exact, Broad). Details: https://support.google.com/adwords/answer/2472708?hl=en")]
            public static DataItem adKeywordMatchType = new DataItem("adKeywordMatchType");
                                      
            [DescriptionAttribute("The search queries that triggered impressions of your AdWords ads.")]
            public static DataItem adMatchedQuery = new DataItem("adMatchedQuery");
                                      
            [DescriptionAttribute("The domains where your ads on the content network were placed.")]
            public static DataItem adPlacementDomain = new DataItem("adPlacementDomain");
                                      
            [DescriptionAttribute("The URLs where your ads on the content network were placed.")]
            public static DataItem adPlacementUrl = new DataItem("adPlacementUrl");
                                      
            [DescriptionAttribute("Your AdWords ad formats (Text, Image, Flash, Video, etc.).")]
            public static DataItem adFormat = new DataItem("adFormat");
                                      
            [DescriptionAttribute("How your AdWords ads were targeted (keyword, placement, and vertical targeting, etc.).")]
            public static DataItem adTargetingType = new DataItem("adTargetingType");
                                      
            [DescriptionAttribute("How you manage your ads on the content network. Values are Automatic placements or Managed placements.")]
            public static DataItem adTargetingOption = new DataItem("adTargetingOption");
                                      
            [DescriptionAttribute("The URLs your AdWords ads displayed.")]
            public static DataItem adDisplayUrl = new DataItem("adDisplayUrl");
                                      
            [DescriptionAttribute("The URLs to which your AdWords ads referred traffic.")]
            public static DataItem adDestinationUrl = new DataItem("adDestinationUrl");
                                      
            [DescriptionAttribute("A string. Corresponds to AdWords API AccountInfo.customerId.")]
            public static DataItem adwordsCustomerID = new DataItem("adwordsCustomerID");
                                      
            [DescriptionAttribute("A string. Corresponds to AdWords API Campaign.id.")]
            public static DataItem adwordsCampaignID = new DataItem("adwordsCampaignID");
                                      
            [DescriptionAttribute("A string. Corresponds to AdWords API AdGroup.id.")]
            public static DataItem adwordsAdGroupID = new DataItem("adwordsAdGroupID");
                                      
            [DescriptionAttribute("A string. Corresponds to AdWords API Ad.id.")]
            public static DataItem adwordsCreativeID = new DataItem("adwordsCreativeID");
                                      
            [DescriptionAttribute("A string. Corresponds to AdWords API Criterion.id.")]
            public static DataItem adwordsCriteriaID = new DataItem("adwordsCriteriaID");
                                      
        }

        public sealed class Metrics
        {
            
            [DescriptionAttribute("Total number of campaign impressions.")]
            public static DataItem impressions = new DataItem("impressions");
                                      
            [DescriptionAttribute("The total number of times users have clicked on an ad to reach your property.")]
            public static DataItem adClicks = new DataItem("adClicks");
                                      
            [DescriptionAttribute("Derived cost for the advertising campaign. The currency for this filter is based on the currency that you set in your AdWords account.")]
            public static DataItem adCost = new DataItem("adCost");
                                      

            public sealed class Calculated
            {
                
            [DescriptionAttribute("Cost per thousand impressions. (ga:adCost / (ga:impressions / 1000) ) ")]
            public static DataItem CPM = new DataItem("CPM");
                                      
            [DescriptionAttribute("Cost to advertiser per click. (ga:adCost / ga:adClicks ) ")]
            public static DataItem CPC = new DataItem("CPC");
                                      
            [DescriptionAttribute("Click-through-rate for your ad. This is equal to the number of clicks divided by the number of impressions for your ad (e.g. how many times users clicked on one of your ads where that ad appeared). (ga:adClicks / ga:impressions ) ")]
            public static DataItem CTR = new DataItem("CTR");
                                      
            [DescriptionAttribute("The cost per transaction for your property. ((ga:adCost) / (ga:transactions) ) ")]
            public static DataItem costPerTransaction = new DataItem("costPerTransaction");
                                      
            [DescriptionAttribute("The cost per goal conversion for your property. ((ga:adCost) / (ga:goalCompletionsAll) ) ")]
            public static DataItem costPerGoalConversion = new DataItem("costPerGoalConversion");
                                      
            [DescriptionAttribute("The cost per conversion (including ecommerce and goal conversions) for your property. ((ga:adCost) / (ga:transactions  +  ga:goalCompletionsAll) ) ")]
            public static DataItem costPerConversion = new DataItem("costPerConversion");
                                      
            [DescriptionAttribute("RPC or revenue-per-click is the average revenue (from ecommerce sales and/or goal filter) you received for each click on one of your search ads. ((ga:transactionRevenue + ga:goalValueAll) / ga:adClicks ) ")]
            public static DataItem RPC = new DataItem("RPC");
                                      
            [DescriptionAttribute("Returns on Investment is overall transaction profit divided by derived advertising cost. ((ga:transactionRevenue + ga:goalValueAll - ga:adCost) / ga:adCost ) ")]
            public static DataItem ROI = new DataItem("ROI");
                                      
            [DescriptionAttribute("The overall transaction profit margin. ((ga:transactionRevenue + ga:goalValueAll - ga:adCost) / (ga:transactionRevenue + ga:goalValueAll) ) ")]
            public static DataItem margin = new DataItem("margin");
                                      
            }
        }
    }
}
