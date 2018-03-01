namespace Flexi.Model.Enum.CampaignManager
{
    public enum CampaignSearchCriteria
    {
        startIndex,
        count,
        campaignType,
        stateFilter,
        name,
        campaignIdFilter
    }

    public enum AdGroupSearchCriteria
    {
        startIndex,
        count,
        stateFilter,
        campaignIdFilter,
        adGroupIdFilter,
        name
    }

    public enum BiddableKeywordSearchCriteria
    {
        startIndex,
        count,
        campaignType,
        matchTypeFilter,
        keywordText,
        stateFilter,
        campaignIdFilter,
        adGroupIdFilter,
        keywordIdFilter
    }

    public enum NegativeKeywordSearchCriteria
    {
        startIndex,
        count,
        campaignType,
        matchTypeFilter,
        keywordText,
        stateFilter,
        campaignIdFilter,
        adGroupIdFilter
    }

    public enum CampaignNegativeKeywordSearchCriteria
    {
        startIndex,
        count,
        campaignType,
        matchTypeFilter,
        keywordText,
        campaignIdFilter
    }

    public enum ProductAdSearchCriteria
    {
        startIndex,
        count,
        campaignType,
        sku,
        asin,
        adGroupId,
        stateFilter,
        campaignIdFilter,
        adGroupIdFilter,
        adIdFilter
    }
}
