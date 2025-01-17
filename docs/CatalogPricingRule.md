# Square.Connect.Model.CatalogPricingRule

### Description

Defines how prices are modified or set for items that match the pricing rule during the active time period.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | User-defined name for the pricing rule. For example, \&quot;Buy one get one free\&quot; or \&quot;10% off\&quot;. | [optional] 
**TimePeriodIds** | **List<string>** | Unique ID for the [CatalogTimePeriod](#type-catalogtimeperiod)s when this pricing rule is in effect. If left unset, the pricing rule is always in effect. | [optional] 
**DiscountId** | **string** | Unique ID for the [CatalogDiscount](#type-catalogdiscount) to take off the price of all matched items.  Only one of &#x60;total_price_money&#x60;, &#x60;item_price&#x60;, or &#x60;discount&#x60; can be supplied. | [optional] 
**MatchProductsId** | **string** | Unique ID for the [CatalogProductSet](#type-catalogproductset) that will be matched by this rule. A match rule matches within the entire cart. | [optional] 
**ApplyProductsId** | **string** | The [CatalogProductSet](#type-catalogproductset) to apply the pricing rule to within the set of matched products specified by &#x60;match_products_id&#x60;. An apply rule can only match once within the set of matched products. If left unset, the pricing rule will be applied to all products within the set of matched products. | [optional] 
**ExcludeProductsId** | **string** | Identifies the [CatalogProductSet](#type-catalogproductset) to exclude from this pricing rule. An exclude rule matches within the subset of the cart that fits the match rules (the match set). An exclude rule can only match once in the match set. If not supplied, the pricing will be applied to all products in the match set. Other products retain their base price, or a price generated by other rules. | [optional] 
**ValidFromDate** | **string** | Represents the date the Pricing Rule is valid from. Represented in RFC3339 full-date format (YYYY-MM-DD). | [optional] 
**ValidFromLocalTime** | **string** | Represents the local time the pricing rule should be valid from. Time zone is determined by the device running the Point of Sale app.  Represented in RFC3339 partial-time format (HH:MM:SS). Partial seconds will be truncated. | [optional] 
**ValidUntilDate** | **string** | Represents the date the pricing rule will become inactive.  Represented in RFC3339 full-date format (YYYY-MM-DD). | [optional] 
**ValidUntilLocalTime** | **string** | Represents the local time at which the pricing rule will become inactive. Time zone is determined by the device running the Point of Sale app.  Represented in RFC3339 partial-time format (HH:MM:SS). Partial seconds will be truncated. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

