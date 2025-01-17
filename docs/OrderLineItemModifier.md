# Square.Connect.Model.OrderLineItemModifier

### Description

A [CatalogModifier](#type-catalogmodifier).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uid** | **string** | Unique ID that identifies the modifier only within this order. | [optional] 
**CatalogObjectId** | **string** | The catalog object id referencing [CatalogModifier](#type-catalogmodifier). | [optional] 
**Name** | **string** | The name of the item modifier. | [optional] 
**BasePriceMoney** | [**Money**](Money.md) | The base price for the modifier.  &#x60;base_price_money&#x60; is required for ad hoc modifiers. If both &#x60;catalog_object_id&#x60; and &#x60;base_price_money&#x60; are set, &#x60;base_price_money&#x60; will override the predefined [CatalogModifier](#type-catalogmodifier) price. | [optional] 
**TotalPriceMoney** | [**Money**](Money.md) | The total price of the item modifier for its line item. This is the modifier&#39;s &#x60;base_price_money&#x60; multiplied by the line item&#39;s quantity. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

