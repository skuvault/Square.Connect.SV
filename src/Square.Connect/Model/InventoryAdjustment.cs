/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Square.Connect.Model
{
    /// <summary>
    /// Represents a change in state or quantity of product inventory at a particular time and location.
    /// </summary>
    [DataContract]
    public partial class InventoryAdjustment :  IEquatable<InventoryAdjustment>, IValidatableObject
    {
        /// <summary>
        /// The [InventoryState](#type-inventorystate) of the related quantity of items before the adjustment. See [InventoryState](#type-inventorystate) for possible values
        /// </summary>
        /// <value>The [InventoryState](#type-inventorystate) of the related quantity of items before the adjustment. See [InventoryState](#type-inventorystate) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FromStateEnum
        {
            
            /// <summary>
            /// Enum CUSTOM for "CUSTOM"
            /// </summary>
            [EnumMember(Value = "CUSTOM")]
            CUSTOM,
            
            /// <summary>
            /// Enum INSTOCK for "IN_STOCK"
            /// </summary>
            [EnumMember(Value = "IN_STOCK")]
            INSTOCK,
            
            /// <summary>
            /// Enum SOLD for "SOLD"
            /// </summary>
            [EnumMember(Value = "SOLD")]
            SOLD,
            
            /// <summary>
            /// Enum RETURNEDBYCUSTOMER for "RETURNED_BY_CUSTOMER"
            /// </summary>
            [EnumMember(Value = "RETURNED_BY_CUSTOMER")]
            RETURNEDBYCUSTOMER,
            
            /// <summary>
            /// Enum RESERVEDFORSALE for "RESERVED_FOR_SALE"
            /// </summary>
            [EnumMember(Value = "RESERVED_FOR_SALE")]
            RESERVEDFORSALE,
            
            /// <summary>
            /// Enum SOLDONLINE for "SOLD_ONLINE"
            /// </summary>
            [EnumMember(Value = "SOLD_ONLINE")]
            SOLDONLINE,
            
            /// <summary>
            /// Enum ORDEREDFROMVENDOR for "ORDERED_FROM_VENDOR"
            /// </summary>
            [EnumMember(Value = "ORDERED_FROM_VENDOR")]
            ORDEREDFROMVENDOR,
            
            /// <summary>
            /// Enum RECEIVEDFROMVENDOR for "RECEIVED_FROM_VENDOR"
            /// </summary>
            [EnumMember(Value = "RECEIVED_FROM_VENDOR")]
            RECEIVEDFROMVENDOR,
            
            /// <summary>
            /// Enum INTRANSITTO for "IN_TRANSIT_TO"
            /// </summary>
            [EnumMember(Value = "IN_TRANSIT_TO")]
            INTRANSITTO,
            
            /// <summary>
            /// Enum NONE for "NONE"
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE,
            
            /// <summary>
            /// Enum WASTE for "WASTE"
            /// </summary>
            [EnumMember(Value = "WASTE")]
            WASTE,
            
            /// <summary>
            /// Enum UNLINKEDRETURN for "UNLINKED_RETURN"
            /// </summary>
            [EnumMember(Value = "UNLINKED_RETURN")]
            UNLINKEDRETURN
        }

        /// <summary>
        /// The [InventoryState](#type-inventorystate) of the related quantity of items after the adjustment. See [InventoryState](#type-inventorystate) for possible values
        /// </summary>
        /// <value>The [InventoryState](#type-inventorystate) of the related quantity of items after the adjustment. See [InventoryState](#type-inventorystate) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ToStateEnum
        {
            
            /// <summary>
            /// Enum CUSTOM for "CUSTOM"
            /// </summary>
            [EnumMember(Value = "CUSTOM")]
            CUSTOM,
            
            /// <summary>
            /// Enum INSTOCK for "IN_STOCK"
            /// </summary>
            [EnumMember(Value = "IN_STOCK")]
            INSTOCK,
            
            /// <summary>
            /// Enum SOLD for "SOLD"
            /// </summary>
            [EnumMember(Value = "SOLD")]
            SOLD,
            
            /// <summary>
            /// Enum RETURNEDBYCUSTOMER for "RETURNED_BY_CUSTOMER"
            /// </summary>
            [EnumMember(Value = "RETURNED_BY_CUSTOMER")]
            RETURNEDBYCUSTOMER,
            
            /// <summary>
            /// Enum RESERVEDFORSALE for "RESERVED_FOR_SALE"
            /// </summary>
            [EnumMember(Value = "RESERVED_FOR_SALE")]
            RESERVEDFORSALE,
            
            /// <summary>
            /// Enum SOLDONLINE for "SOLD_ONLINE"
            /// </summary>
            [EnumMember(Value = "SOLD_ONLINE")]
            SOLDONLINE,
            
            /// <summary>
            /// Enum ORDEREDFROMVENDOR for "ORDERED_FROM_VENDOR"
            /// </summary>
            [EnumMember(Value = "ORDERED_FROM_VENDOR")]
            ORDEREDFROMVENDOR,
            
            /// <summary>
            /// Enum RECEIVEDFROMVENDOR for "RECEIVED_FROM_VENDOR"
            /// </summary>
            [EnumMember(Value = "RECEIVED_FROM_VENDOR")]
            RECEIVEDFROMVENDOR,
            
            /// <summary>
            /// Enum INTRANSITTO for "IN_TRANSIT_TO"
            /// </summary>
            [EnumMember(Value = "IN_TRANSIT_TO")]
            INTRANSITTO,
            
            /// <summary>
            /// Enum NONE for "NONE"
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE,
            
            /// <summary>
            /// Enum WASTE for "WASTE"
            /// </summary>
            [EnumMember(Value = "WASTE")]
            WASTE,
            
            /// <summary>
            /// Enum UNLINKEDRETURN for "UNLINKED_RETURN"
            /// </summary>
            [EnumMember(Value = "UNLINKED_RETURN")]
            UNLINKEDRETURN
        }

        /// <summary>
        /// The [InventoryState](#type-inventorystate) of the related quantity of items before the adjustment. See [InventoryState](#type-inventorystate) for possible values
        /// </summary>
        /// <value>The [InventoryState](#type-inventorystate) of the related quantity of items before the adjustment. See [InventoryState](#type-inventorystate) for possible values</value>
        [DataMember(Name="from_state", EmitDefaultValue=false)]
        public FromStateEnum? FromState { get; set; }
        /// <summary>
        /// The [InventoryState](#type-inventorystate) of the related quantity of items after the adjustment. See [InventoryState](#type-inventorystate) for possible values
        /// </summary>
        /// <value>The [InventoryState](#type-inventorystate) of the related quantity of items after the adjustment. See [InventoryState](#type-inventorystate) for possible values</value>
        [DataMember(Name="to_state", EmitDefaultValue=false)]
        public ToStateEnum? ToState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryAdjustment" /> class.
        /// </summary>
        /// <param name="Id">A unique ID generated by Square for the [InventoryAdjustment](#type-inventoryadjustment)..</param>
        /// <param name="ReferenceId">An optional ID provided by the application to tie the [InventoryAdjustment](#type-inventoryadjustment) to an external system..</param>
        /// <param name="FromState">The [InventoryState](#type-inventorystate) of the related quantity of items before the adjustment. See [InventoryState](#type-inventorystate) for possible values.</param>
        /// <param name="ToState">The [InventoryState](#type-inventorystate) of the related quantity of items after the adjustment. See [InventoryState](#type-inventorystate) for possible values.</param>
        /// <param name="LocationId">The Square ID of the [Location](#type-location) where the related quantity of items are being tracked..</param>
        /// <param name="CatalogObjectId">The Square generated ID of the [CatalogObject](#type-catalogobject) being tracked..</param>
        /// <param name="CatalogObjectType">The [CatalogObjectType](#type-catalogobjecttype) of the [CatalogObject](#type-catalogobject) being tracked. Tracking is only supported for the &#x60;ITEM_VARIATION&#x60; type..</param>
        /// <param name="Quantity">The number of items affected by the adjustment as a decimal string. Can support up to 5 digits after the decimal point.  _Important_: The Point of Sale app and Dashboard do not currently support decimal quantities. If a Point of Sale app or Dashboard attempts to read a decimal quantity on inventory counts or adjustments, the quantity will be rounded down to the nearest integer. For example, &#x60;2.5&#x60; will become &#x60;2&#x60;, and &#x60;-2.5&#x60; will become &#x60;-3&#x60;. Read [Decimal Quantities (BETA)](/more-apis/inventory/overview#decimal-quantities-beta) for more information..</param>
        /// <param name="TotalPriceMoney">The read-only total price paid for goods associated with the adjustment. Present if and only if &#x60;to_state&#x60; is &#x60;SOLD&#x60;. Always non-negative..</param>
        /// <param name="OccurredAt">A client-generated timestamp in RFC 3339 format that indicates when the adjustment took place. For write actions, the &#x60;occurred_at&#x60; timestamp cannot be older than 24 hours or in the future relative to the time of the request..</param>
        /// <param name="CreatedAt">A read-only timestamp in RFC 3339 format that indicates when Square received the adjustment..</param>
        /// <param name="Source">Read-only information about the application that caused the inventory adjustment..</param>
        /// <param name="EmployeeId">The Square ID of the [Employee](#type-employee) responsible for the inventory adjustment..</param>
        /// <param name="TransactionId">The read-only Square ID of the [Transaction][#type-transaction] that caused the adjustment. Only relevant for payment-related state transitions..</param>
        /// <param name="RefundId">The read-only Square ID of the [Refund][#type-refund] that caused the adjustment. Only relevant for refund-related state transitions..</param>
        /// <param name="PurchaseOrderId">The read-only Square ID of the purchase order that caused the adjustment. Only relevant for state transitions from the Square for Retail app..</param>
        /// <param name="GoodsReceiptId">The read-only Square ID of the Square goods receipt that caused the adjustment. Only relevant for state transitions from the Square for Retail app..</param>
        public InventoryAdjustment(string Id = default(string), string ReferenceId = default(string), FromStateEnum? FromState = default(FromStateEnum?), ToStateEnum? ToState = default(ToStateEnum?), string LocationId = default(string), string CatalogObjectId = default(string), string CatalogObjectType = default(string), string Quantity = default(string), Money TotalPriceMoney = default(Money), string OccurredAt = default(string), string CreatedAt = default(string), SourceApplication Source = default(SourceApplication), string EmployeeId = default(string), string TransactionId = default(string), string RefundId = default(string), string PurchaseOrderId = default(string), string GoodsReceiptId = default(string))
        {
            this.Id = Id;
            this.ReferenceId = ReferenceId;
            this.FromState = FromState;
            this.ToState = ToState;
            this.LocationId = LocationId;
            this.CatalogObjectId = CatalogObjectId;
            this.CatalogObjectType = CatalogObjectType;
            this.Quantity = Quantity;
            this.TotalPriceMoney = TotalPriceMoney;
            this.OccurredAt = OccurredAt;
            this.CreatedAt = CreatedAt;
            this.Source = Source;
            this.EmployeeId = EmployeeId;
            this.TransactionId = TransactionId;
            this.RefundId = RefundId;
            this.PurchaseOrderId = PurchaseOrderId;
            this.GoodsReceiptId = GoodsReceiptId;
        }
        
        /// <summary>
        /// A unique ID generated by Square for the [InventoryAdjustment](#type-inventoryadjustment).
        /// </summary>
        /// <value>A unique ID generated by Square for the [InventoryAdjustment](#type-inventoryadjustment).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// An optional ID provided by the application to tie the [InventoryAdjustment](#type-inventoryadjustment) to an external system.
        /// </summary>
        /// <value>An optional ID provided by the application to tie the [InventoryAdjustment](#type-inventoryadjustment) to an external system.</value>
        [DataMember(Name="reference_id", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }
        /// <summary>
        /// The Square ID of the [Location](#type-location) where the related quantity of items are being tracked.
        /// </summary>
        /// <value>The Square ID of the [Location](#type-location) where the related quantity of items are being tracked.</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public string LocationId { get; set; }
        /// <summary>
        /// The Square generated ID of the [CatalogObject](#type-catalogobject) being tracked.
        /// </summary>
        /// <value>The Square generated ID of the [CatalogObject](#type-catalogobject) being tracked.</value>
        [DataMember(Name="catalog_object_id", EmitDefaultValue=false)]
        public string CatalogObjectId { get; set; }
        /// <summary>
        /// The [CatalogObjectType](#type-catalogobjecttype) of the [CatalogObject](#type-catalogobject) being tracked. Tracking is only supported for the &#x60;ITEM_VARIATION&#x60; type.
        /// </summary>
        /// <value>The [CatalogObjectType](#type-catalogobjecttype) of the [CatalogObject](#type-catalogobject) being tracked. Tracking is only supported for the &#x60;ITEM_VARIATION&#x60; type.</value>
        [DataMember(Name="catalog_object_type", EmitDefaultValue=false)]
        public string CatalogObjectType { get; set; }
        /// <summary>
        /// The number of items affected by the adjustment as a decimal string. Can support up to 5 digits after the decimal point.  _Important_: The Point of Sale app and Dashboard do not currently support decimal quantities. If a Point of Sale app or Dashboard attempts to read a decimal quantity on inventory counts or adjustments, the quantity will be rounded down to the nearest integer. For example, &#x60;2.5&#x60; will become &#x60;2&#x60;, and &#x60;-2.5&#x60; will become &#x60;-3&#x60;. Read [Decimal Quantities (BETA)](/more-apis/inventory/overview#decimal-quantities-beta) for more information.
        /// </summary>
        /// <value>The number of items affected by the adjustment as a decimal string. Can support up to 5 digits after the decimal point.  _Important_: The Point of Sale app and Dashboard do not currently support decimal quantities. If a Point of Sale app or Dashboard attempts to read a decimal quantity on inventory counts or adjustments, the quantity will be rounded down to the nearest integer. For example, &#x60;2.5&#x60; will become &#x60;2&#x60;, and &#x60;-2.5&#x60; will become &#x60;-3&#x60;. Read [Decimal Quantities (BETA)](/more-apis/inventory/overview#decimal-quantities-beta) for more information.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public string Quantity { get; set; }
        /// <summary>
        /// The read-only total price paid for goods associated with the adjustment. Present if and only if &#x60;to_state&#x60; is &#x60;SOLD&#x60;. Always non-negative.
        /// </summary>
        /// <value>The read-only total price paid for goods associated with the adjustment. Present if and only if &#x60;to_state&#x60; is &#x60;SOLD&#x60;. Always non-negative.</value>
        [DataMember(Name="total_price_money", EmitDefaultValue=false)]
        public Money TotalPriceMoney { get; set; }
        /// <summary>
        /// A client-generated timestamp in RFC 3339 format that indicates when the adjustment took place. For write actions, the &#x60;occurred_at&#x60; timestamp cannot be older than 24 hours or in the future relative to the time of the request.
        /// </summary>
        /// <value>A client-generated timestamp in RFC 3339 format that indicates when the adjustment took place. For write actions, the &#x60;occurred_at&#x60; timestamp cannot be older than 24 hours or in the future relative to the time of the request.</value>
        [DataMember(Name="occurred_at", EmitDefaultValue=false)]
        public string OccurredAt { get; set; }
        /// <summary>
        /// A read-only timestamp in RFC 3339 format that indicates when Square received the adjustment.
        /// </summary>
        /// <value>A read-only timestamp in RFC 3339 format that indicates when Square received the adjustment.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
        /// <summary>
        /// Read-only information about the application that caused the inventory adjustment.
        /// </summary>
        /// <value>Read-only information about the application that caused the inventory adjustment.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public SourceApplication Source { get; set; }
        /// <summary>
        /// The Square ID of the [Employee](#type-employee) responsible for the inventory adjustment.
        /// </summary>
        /// <value>The Square ID of the [Employee](#type-employee) responsible for the inventory adjustment.</value>
        [DataMember(Name="employee_id", EmitDefaultValue=false)]
        public string EmployeeId { get; set; }
        /// <summary>
        /// The read-only Square ID of the [Transaction][#type-transaction] that caused the adjustment. Only relevant for payment-related state transitions.
        /// </summary>
        /// <value>The read-only Square ID of the [Transaction][#type-transaction] that caused the adjustment. Only relevant for payment-related state transitions.</value>
        [DataMember(Name="transaction_id", EmitDefaultValue=false)]
        public string TransactionId { get; set; }
        /// <summary>
        /// The read-only Square ID of the [Refund][#type-refund] that caused the adjustment. Only relevant for refund-related state transitions.
        /// </summary>
        /// <value>The read-only Square ID of the [Refund][#type-refund] that caused the adjustment. Only relevant for refund-related state transitions.</value>
        [DataMember(Name="refund_id", EmitDefaultValue=false)]
        public string RefundId { get; set; }
        /// <summary>
        /// The read-only Square ID of the purchase order that caused the adjustment. Only relevant for state transitions from the Square for Retail app.
        /// </summary>
        /// <value>The read-only Square ID of the purchase order that caused the adjustment. Only relevant for state transitions from the Square for Retail app.</value>
        [DataMember(Name="purchase_order_id", EmitDefaultValue=false)]
        public string PurchaseOrderId { get; set; }
        /// <summary>
        /// The read-only Square ID of the Square goods receipt that caused the adjustment. Only relevant for state transitions from the Square for Retail app.
        /// </summary>
        /// <value>The read-only Square ID of the Square goods receipt that caused the adjustment. Only relevant for state transitions from the Square for Retail app.</value>
        [DataMember(Name="goods_receipt_id", EmitDefaultValue=false)]
        public string GoodsReceiptId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryAdjustment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  FromState: ").Append(FromState).Append("\n");
            sb.Append("  ToState: ").Append(ToState).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  CatalogObjectId: ").Append(CatalogObjectId).Append("\n");
            sb.Append("  CatalogObjectType: ").Append(CatalogObjectType).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  TotalPriceMoney: ").Append(TotalPriceMoney).Append("\n");
            sb.Append("  OccurredAt: ").Append(OccurredAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  RefundId: ").Append(RefundId).Append("\n");
            sb.Append("  PurchaseOrderId: ").Append(PurchaseOrderId).Append("\n");
            sb.Append("  GoodsReceiptId: ").Append(GoodsReceiptId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InventoryAdjustment);
        }

        /// <summary>
        /// Returns true if InventoryAdjustment instances are equal
        /// </summary>
        /// <param name="other">Instance of InventoryAdjustment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryAdjustment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ReferenceId == other.ReferenceId ||
                    this.ReferenceId != null &&
                    this.ReferenceId.Equals(other.ReferenceId)
                ) && 
                (
                    this.FromState == other.FromState ||
                    this.FromState != null &&
                    this.FromState.Equals(other.FromState)
                ) && 
                (
                    this.ToState == other.ToState ||
                    this.ToState != null &&
                    this.ToState.Equals(other.ToState)
                ) && 
                (
                    this.LocationId == other.LocationId ||
                    this.LocationId != null &&
                    this.LocationId.Equals(other.LocationId)
                ) && 
                (
                    this.CatalogObjectId == other.CatalogObjectId ||
                    this.CatalogObjectId != null &&
                    this.CatalogObjectId.Equals(other.CatalogObjectId)
                ) && 
                (
                    this.CatalogObjectType == other.CatalogObjectType ||
                    this.CatalogObjectType != null &&
                    this.CatalogObjectType.Equals(other.CatalogObjectType)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.TotalPriceMoney == other.TotalPriceMoney ||
                    this.TotalPriceMoney != null &&
                    this.TotalPriceMoney.Equals(other.TotalPriceMoney)
                ) && 
                (
                    this.OccurredAt == other.OccurredAt ||
                    this.OccurredAt != null &&
                    this.OccurredAt.Equals(other.OccurredAt)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) && 
                (
                    this.EmployeeId == other.EmployeeId ||
                    this.EmployeeId != null &&
                    this.EmployeeId.Equals(other.EmployeeId)
                ) && 
                (
                    this.TransactionId == other.TransactionId ||
                    this.TransactionId != null &&
                    this.TransactionId.Equals(other.TransactionId)
                ) && 
                (
                    this.RefundId == other.RefundId ||
                    this.RefundId != null &&
                    this.RefundId.Equals(other.RefundId)
                ) && 
                (
                    this.PurchaseOrderId == other.PurchaseOrderId ||
                    this.PurchaseOrderId != null &&
                    this.PurchaseOrderId.Equals(other.PurchaseOrderId)
                ) && 
                (
                    this.GoodsReceiptId == other.GoodsReceiptId ||
                    this.GoodsReceiptId != null &&
                    this.GoodsReceiptId.Equals(other.GoodsReceiptId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ReferenceId != null)
                    hash = hash * 59 + this.ReferenceId.GetHashCode();
                if (this.FromState != null)
                    hash = hash * 59 + this.FromState.GetHashCode();
                if (this.ToState != null)
                    hash = hash * 59 + this.ToState.GetHashCode();
                if (this.LocationId != null)
                    hash = hash * 59 + this.LocationId.GetHashCode();
                if (this.CatalogObjectId != null)
                    hash = hash * 59 + this.CatalogObjectId.GetHashCode();
                if (this.CatalogObjectType != null)
                    hash = hash * 59 + this.CatalogObjectType.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.TotalPriceMoney != null)
                    hash = hash * 59 + this.TotalPriceMoney.GetHashCode();
                if (this.OccurredAt != null)
                    hash = hash * 59 + this.OccurredAt.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                if (this.EmployeeId != null)
                    hash = hash * 59 + this.EmployeeId.GetHashCode();
                if (this.TransactionId != null)
                    hash = hash * 59 + this.TransactionId.GetHashCode();
                if (this.RefundId != null)
                    hash = hash * 59 + this.RefundId.GetHashCode();
                if (this.PurchaseOrderId != null)
                    hash = hash * 59 + this.PurchaseOrderId.GetHashCode();
                if (this.GoodsReceiptId != null)
                    hash = hash * 59 + this.GoodsReceiptId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
