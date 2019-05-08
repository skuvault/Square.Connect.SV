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
    /// The line item being returned in an Order.
    /// </summary>
    [DataContract]
    public partial class OrderReturnLineItem :  IEquatable<OrderReturnLineItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderReturnLineItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderReturnLineItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderReturnLineItem" /> class.
        /// </summary>
        /// <param name="Uid">Unique identifier for this return line item entry. This is a read-only field..</param>
        /// <param name="SourceLineItemUid">&#x60;uid&#x60; of the LineItem in the original sale Order..</param>
        /// <param name="Name">The name of the line item..</param>
        /// <param name="Quantity">The quantity returned, formatted as a decimal number. For example: &#x60;\&quot;3\&quot;&#x60;.  Line items with a &#x60;quantity_unit&#x60; can have non-integer quantities. For example: &#x60;\&quot;1.70000\&quot;&#x60;. (required).</param>
        /// <param name="QuantityUnit">The unit and precision that this return line item&#39;s quantity is measured in..</param>
        /// <param name="Note">The note of the returned line item..</param>
        /// <param name="CatalogObjectId">The [CatalogItemVariation](#type-catalogitemvariation) id applied to this returned line item..</param>
        /// <param name="VariationName">The name of the variation applied to this returned line item..</param>
        /// <param name="ReturnModifiers">The [CatalogModifier](#type-catalogmodifier)s applied to this line item..</param>
        /// <param name="ReturnTaxes">A list of taxes applied to this line item. On read or retrieve, this list includes both item-level taxes and any return-level taxes apportioned to this item..</param>
        /// <param name="ReturnDiscounts">A list of discounts applied to this line item. On read or retrieve, this list includes both item-level discounts and any return-level discounts apportioned to this item..</param>
        /// <param name="BasePriceMoney">The base price for a single unit of the line item..</param>
        /// <param name="VariationTotalPriceMoney">The total price of all item variations returned in this line item. Calculated as &#x60;base_price_money&#x60; multiplied by &#x60;quantity&#x60;. Does not include modifiers..</param>
        /// <param name="GrossReturnMoney">The gross return amount of money calculated as (item base price + modifiers price) * quantity..</param>
        /// <param name="TotalTaxMoney">The total tax amount of money to return for the line item..</param>
        /// <param name="TotalDiscountMoney">The total discount amount of money to return for the line item..</param>
        /// <param name="TotalMoney">The total amount of money to return for this line item..</param>
        public OrderReturnLineItem(string Uid = default(string), string SourceLineItemUid = default(string), string Name = default(string), string Quantity = default(string), OrderQuantityUnit QuantityUnit = default(OrderQuantityUnit), string Note = default(string), string CatalogObjectId = default(string), string VariationName = default(string), List<OrderReturnLineItemModifier> ReturnModifiers = default(List<OrderReturnLineItemModifier>), List<OrderReturnTax> ReturnTaxes = default(List<OrderReturnTax>), List<OrderReturnDiscount> ReturnDiscounts = default(List<OrderReturnDiscount>), Money BasePriceMoney = default(Money), Money VariationTotalPriceMoney = default(Money), Money GrossReturnMoney = default(Money), Money TotalTaxMoney = default(Money), Money TotalDiscountMoney = default(Money), Money TotalMoney = default(Money))
        {
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for OrderReturnLineItem and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            this.Uid = Uid;
            this.SourceLineItemUid = SourceLineItemUid;
            this.Name = Name;
            this.QuantityUnit = QuantityUnit;
            this.Note = Note;
            this.CatalogObjectId = CatalogObjectId;
            this.VariationName = VariationName;
            this.ReturnModifiers = ReturnModifiers;
            this.ReturnTaxes = ReturnTaxes;
            this.ReturnDiscounts = ReturnDiscounts;
            this.BasePriceMoney = BasePriceMoney;
            this.VariationTotalPriceMoney = VariationTotalPriceMoney;
            this.GrossReturnMoney = GrossReturnMoney;
            this.TotalTaxMoney = TotalTaxMoney;
            this.TotalDiscountMoney = TotalDiscountMoney;
            this.TotalMoney = TotalMoney;
        }
        
        /// <summary>
        /// Unique identifier for this return line item entry. This is a read-only field.
        /// </summary>
        /// <value>Unique identifier for this return line item entry. This is a read-only field.</value>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }
        /// <summary>
        /// &#x60;uid&#x60; of the LineItem in the original sale Order.
        /// </summary>
        /// <value>&#x60;uid&#x60; of the LineItem in the original sale Order.</value>
        [DataMember(Name="source_line_item_uid", EmitDefaultValue=false)]
        public string SourceLineItemUid { get; set; }
        /// <summary>
        /// The name of the line item.
        /// </summary>
        /// <value>The name of the line item.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The quantity returned, formatted as a decimal number. For example: &#x60;\&quot;3\&quot;&#x60;.  Line items with a &#x60;quantity_unit&#x60; can have non-integer quantities. For example: &#x60;\&quot;1.70000\&quot;&#x60;.
        /// </summary>
        /// <value>The quantity returned, formatted as a decimal number. For example: &#x60;\&quot;3\&quot;&#x60;.  Line items with a &#x60;quantity_unit&#x60; can have non-integer quantities. For example: &#x60;\&quot;1.70000\&quot;&#x60;.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public string Quantity { get; set; }
        /// <summary>
        /// The unit and precision that this return line item&#39;s quantity is measured in.
        /// </summary>
        /// <value>The unit and precision that this return line item&#39;s quantity is measured in.</value>
        [DataMember(Name="quantity_unit", EmitDefaultValue=false)]
        public OrderQuantityUnit QuantityUnit { get; set; }
        /// <summary>
        /// The note of the returned line item.
        /// </summary>
        /// <value>The note of the returned line item.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
        /// <summary>
        /// The [CatalogItemVariation](#type-catalogitemvariation) id applied to this returned line item.
        /// </summary>
        /// <value>The [CatalogItemVariation](#type-catalogitemvariation) id applied to this returned line item.</value>
        [DataMember(Name="catalog_object_id", EmitDefaultValue=false)]
        public string CatalogObjectId { get; set; }
        /// <summary>
        /// The name of the variation applied to this returned line item.
        /// </summary>
        /// <value>The name of the variation applied to this returned line item.</value>
        [DataMember(Name="variation_name", EmitDefaultValue=false)]
        public string VariationName { get; set; }
        /// <summary>
        /// The [CatalogModifier](#type-catalogmodifier)s applied to this line item.
        /// </summary>
        /// <value>The [CatalogModifier](#type-catalogmodifier)s applied to this line item.</value>
        [DataMember(Name="return_modifiers", EmitDefaultValue=false)]
        public List<OrderReturnLineItemModifier> ReturnModifiers { get; set; }
        /// <summary>
        /// A list of taxes applied to this line item. On read or retrieve, this list includes both item-level taxes and any return-level taxes apportioned to this item.
        /// </summary>
        /// <value>A list of taxes applied to this line item. On read or retrieve, this list includes both item-level taxes and any return-level taxes apportioned to this item.</value>
        [DataMember(Name="return_taxes", EmitDefaultValue=false)]
        public List<OrderReturnTax> ReturnTaxes { get; set; }
        /// <summary>
        /// A list of discounts applied to this line item. On read or retrieve, this list includes both item-level discounts and any return-level discounts apportioned to this item.
        /// </summary>
        /// <value>A list of discounts applied to this line item. On read or retrieve, this list includes both item-level discounts and any return-level discounts apportioned to this item.</value>
        [DataMember(Name="return_discounts", EmitDefaultValue=false)]
        public List<OrderReturnDiscount> ReturnDiscounts { get; set; }
        /// <summary>
        /// The base price for a single unit of the line item.
        /// </summary>
        /// <value>The base price for a single unit of the line item.</value>
        [DataMember(Name="base_price_money", EmitDefaultValue=false)]
        public Money BasePriceMoney { get; set; }
        /// <summary>
        /// The total price of all item variations returned in this line item. Calculated as &#x60;base_price_money&#x60; multiplied by &#x60;quantity&#x60;. Does not include modifiers.
        /// </summary>
        /// <value>The total price of all item variations returned in this line item. Calculated as &#x60;base_price_money&#x60; multiplied by &#x60;quantity&#x60;. Does not include modifiers.</value>
        [DataMember(Name="variation_total_price_money", EmitDefaultValue=false)]
        public Money VariationTotalPriceMoney { get; set; }
        /// <summary>
        /// The gross return amount of money calculated as (item base price + modifiers price) * quantity.
        /// </summary>
        /// <value>The gross return amount of money calculated as (item base price + modifiers price) * quantity.</value>
        [DataMember(Name="gross_return_money", EmitDefaultValue=false)]
        public Money GrossReturnMoney { get; set; }
        /// <summary>
        /// The total tax amount of money to return for the line item.
        /// </summary>
        /// <value>The total tax amount of money to return for the line item.</value>
        [DataMember(Name="total_tax_money", EmitDefaultValue=false)]
        public Money TotalTaxMoney { get; set; }
        /// <summary>
        /// The total discount amount of money to return for the line item.
        /// </summary>
        /// <value>The total discount amount of money to return for the line item.</value>
        [DataMember(Name="total_discount_money", EmitDefaultValue=false)]
        public Money TotalDiscountMoney { get; set; }
        /// <summary>
        /// The total amount of money to return for this line item.
        /// </summary>
        /// <value>The total amount of money to return for this line item.</value>
        [DataMember(Name="total_money", EmitDefaultValue=false)]
        public Money TotalMoney { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderReturnLineItem {\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  SourceLineItemUid: ").Append(SourceLineItemUid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  QuantityUnit: ").Append(QuantityUnit).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  CatalogObjectId: ").Append(CatalogObjectId).Append("\n");
            sb.Append("  VariationName: ").Append(VariationName).Append("\n");
            sb.Append("  ReturnModifiers: ").Append(ReturnModifiers).Append("\n");
            sb.Append("  ReturnTaxes: ").Append(ReturnTaxes).Append("\n");
            sb.Append("  ReturnDiscounts: ").Append(ReturnDiscounts).Append("\n");
            sb.Append("  BasePriceMoney: ").Append(BasePriceMoney).Append("\n");
            sb.Append("  VariationTotalPriceMoney: ").Append(VariationTotalPriceMoney).Append("\n");
            sb.Append("  GrossReturnMoney: ").Append(GrossReturnMoney).Append("\n");
            sb.Append("  TotalTaxMoney: ").Append(TotalTaxMoney).Append("\n");
            sb.Append("  TotalDiscountMoney: ").Append(TotalDiscountMoney).Append("\n");
            sb.Append("  TotalMoney: ").Append(TotalMoney).Append("\n");
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
            return this.Equals(obj as OrderReturnLineItem);
        }

        /// <summary>
        /// Returns true if OrderReturnLineItem instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderReturnLineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderReturnLineItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Uid == other.Uid ||
                    this.Uid != null &&
                    this.Uid.Equals(other.Uid)
                ) && 
                (
                    this.SourceLineItemUid == other.SourceLineItemUid ||
                    this.SourceLineItemUid != null &&
                    this.SourceLineItemUid.Equals(other.SourceLineItemUid)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.QuantityUnit == other.QuantityUnit ||
                    this.QuantityUnit != null &&
                    this.QuantityUnit.Equals(other.QuantityUnit)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.CatalogObjectId == other.CatalogObjectId ||
                    this.CatalogObjectId != null &&
                    this.CatalogObjectId.Equals(other.CatalogObjectId)
                ) && 
                (
                    this.VariationName == other.VariationName ||
                    this.VariationName != null &&
                    this.VariationName.Equals(other.VariationName)
                ) && 
                (
                    this.ReturnModifiers == other.ReturnModifiers ||
                    this.ReturnModifiers != null &&
                    this.ReturnModifiers.SequenceEqual(other.ReturnModifiers)
                ) && 
                (
                    this.ReturnTaxes == other.ReturnTaxes ||
                    this.ReturnTaxes != null &&
                    this.ReturnTaxes.SequenceEqual(other.ReturnTaxes)
                ) && 
                (
                    this.ReturnDiscounts == other.ReturnDiscounts ||
                    this.ReturnDiscounts != null &&
                    this.ReturnDiscounts.SequenceEqual(other.ReturnDiscounts)
                ) && 
                (
                    this.BasePriceMoney == other.BasePriceMoney ||
                    this.BasePriceMoney != null &&
                    this.BasePriceMoney.Equals(other.BasePriceMoney)
                ) && 
                (
                    this.VariationTotalPriceMoney == other.VariationTotalPriceMoney ||
                    this.VariationTotalPriceMoney != null &&
                    this.VariationTotalPriceMoney.Equals(other.VariationTotalPriceMoney)
                ) && 
                (
                    this.GrossReturnMoney == other.GrossReturnMoney ||
                    this.GrossReturnMoney != null &&
                    this.GrossReturnMoney.Equals(other.GrossReturnMoney)
                ) && 
                (
                    this.TotalTaxMoney == other.TotalTaxMoney ||
                    this.TotalTaxMoney != null &&
                    this.TotalTaxMoney.Equals(other.TotalTaxMoney)
                ) && 
                (
                    this.TotalDiscountMoney == other.TotalDiscountMoney ||
                    this.TotalDiscountMoney != null &&
                    this.TotalDiscountMoney.Equals(other.TotalDiscountMoney)
                ) && 
                (
                    this.TotalMoney == other.TotalMoney ||
                    this.TotalMoney != null &&
                    this.TotalMoney.Equals(other.TotalMoney)
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
                if (this.Uid != null)
                    hash = hash * 59 + this.Uid.GetHashCode();
                if (this.SourceLineItemUid != null)
                    hash = hash * 59 + this.SourceLineItemUid.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.QuantityUnit != null)
                    hash = hash * 59 + this.QuantityUnit.GetHashCode();
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.CatalogObjectId != null)
                    hash = hash * 59 + this.CatalogObjectId.GetHashCode();
                if (this.VariationName != null)
                    hash = hash * 59 + this.VariationName.GetHashCode();
                if (this.ReturnModifiers != null)
                    hash = hash * 59 + this.ReturnModifiers.GetHashCode();
                if (this.ReturnTaxes != null)
                    hash = hash * 59 + this.ReturnTaxes.GetHashCode();
                if (this.ReturnDiscounts != null)
                    hash = hash * 59 + this.ReturnDiscounts.GetHashCode();
                if (this.BasePriceMoney != null)
                    hash = hash * 59 + this.BasePriceMoney.GetHashCode();
                if (this.VariationTotalPriceMoney != null)
                    hash = hash * 59 + this.VariationTotalPriceMoney.GetHashCode();
                if (this.GrossReturnMoney != null)
                    hash = hash * 59 + this.GrossReturnMoney.GetHashCode();
                if (this.TotalTaxMoney != null)
                    hash = hash * 59 + this.TotalTaxMoney.GetHashCode();
                if (this.TotalDiscountMoney != null)
                    hash = hash * 59 + this.TotalDiscountMoney.GetHashCode();
                if (this.TotalMoney != null)
                    hash = hash * 59 + this.TotalMoney.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Uid (string) maxLength
            if(this.Uid != null && this.Uid.Length > 60)
            {
                yield return new ValidationResult("Invalid value for Uid, length must be less than 60.", new [] { "Uid" });
            }

            // SourceLineItemUid (string) maxLength
            if(this.SourceLineItemUid != null && this.SourceLineItemUid.Length > 60)
            {
                yield return new ValidationResult("Invalid value for SourceLineItemUid, length must be less than 60.", new [] { "SourceLineItemUid" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 500)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 500.", new [] { "Name" });
            }

            // Quantity (string) maxLength
            if(this.Quantity != null && this.Quantity.Length > 12)
            {
                yield return new ValidationResult("Invalid value for Quantity, length must be less than 12.", new [] { "Quantity" });
            }

            // Quantity (string) minLength
            if(this.Quantity != null && this.Quantity.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Quantity, length must be greater than 1.", new [] { "Quantity" });
            }

            // Note (string) maxLength
            if(this.Note != null && this.Note.Length > 500)
            {
                yield return new ValidationResult("Invalid value for Note, length must be less than 500.", new [] { "Note" });
            }

            // CatalogObjectId (string) maxLength
            if(this.CatalogObjectId != null && this.CatalogObjectId.Length > 192)
            {
                yield return new ValidationResult("Invalid value for CatalogObjectId, length must be less than 192.", new [] { "CatalogObjectId" });
            }

            // VariationName (string) maxLength
            if(this.VariationName != null && this.VariationName.Length > 255)
            {
                yield return new ValidationResult("Invalid value for VariationName, length must be less than 255.", new [] { "VariationName" });
            }

            yield break;
        }
    }

}
