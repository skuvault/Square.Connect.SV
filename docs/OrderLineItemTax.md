# Square.Connect.Model.OrderLineItemTax

### Description

Represents a tax that applies to one or more line item in the order.  Fixed-amount, order-scoped taxes are distributed across all non-zero line item totals. The amount distributed to each line item is relative to the amount the item contributes to the order subtotal.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uid** | **string** | Unique ID that identifies the tax only within this order. | [optional] 
**CatalogObjectId** | **string** | The catalog object id referencing [CatalogTax](#type-catalogtax). | [optional] 
**Name** | **string** | The tax&#39;s name. | [optional] 
**Type** | **string** | Indicates the calculation method used to apply the tax. See [OrderLineItemTaxType](#type-orderlineitemtaxtype) for possible values | [optional] 
**Percentage** | **string** | The percentage of the tax, as a string representation of a decimal number. For example, a value of &#x60;\&quot;7.25\&quot;&#x60; corresponds to a percentage of 7.25%. | [optional] 
**AppliedMoney** | [**Money**](Money.md) | The amount of the money applied by the tax in the order. | [optional] 
**Scope** | **string** | Indicates the level at which the tax applies. For &#x60;ORDER&#x60; scoped taxes, Square generates references in &#x60;applied_taxes&#x60; on all order line items that do not have them. For &#x60;LINE_ITEM&#x60; scoped taxes, the tax will only apply to line items with references in their &#x60;applied_taxes&#x60; field.  This field is immutable. To change the scope, you must delete the tax and re-add it as a new tax. See [OrderLineItemTaxScope](#type-orderlineitemtaxscope) for possible values | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

