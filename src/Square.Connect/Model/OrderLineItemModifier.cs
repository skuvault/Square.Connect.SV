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
    /// A [CatalogModifier](#type-catalogmodifier).
    /// </summary>
    [DataContract]
    public partial class OrderLineItemModifier :  IEquatable<OrderLineItemModifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLineItemModifier" /> class.
        /// </summary>
        /// <param name="Uid">Unique ID that identifies the modifier only within this order..</param>
        /// <param name="CatalogObjectId">The catalog object id referencing [CatalogModifier](#type-catalogmodifier)..</param>
        /// <param name="Name">The name of the item modifier..</param>
        /// <param name="BasePriceMoney">The base price for the modifier.  &#x60;base_price_money&#x60; is required for ad hoc modifiers. If both &#x60;catalog_object_id&#x60; and &#x60;base_price_money&#x60; are set, &#x60;base_price_money&#x60; will override the predefined [CatalogModifier](#type-catalogmodifier) price..</param>
        /// <param name="TotalPriceMoney">The total price of the item modifier for its line item. This is the modifier&#39;s &#x60;base_price_money&#x60; multiplied by the line item&#39;s quantity..</param>
        public OrderLineItemModifier(string Uid = default(string), string CatalogObjectId = default(string), string Name = default(string), Money BasePriceMoney = default(Money), Money TotalPriceMoney = default(Money))
        {
            this.Uid = Uid;
            this.CatalogObjectId = CatalogObjectId;
            this.Name = Name;
            this.BasePriceMoney = BasePriceMoney;
            this.TotalPriceMoney = TotalPriceMoney;
        }
        
        /// <summary>
        /// Unique ID that identifies the modifier only within this order.
        /// </summary>
        /// <value>Unique ID that identifies the modifier only within this order.</value>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }
        /// <summary>
        /// The catalog object id referencing [CatalogModifier](#type-catalogmodifier).
        /// </summary>
        /// <value>The catalog object id referencing [CatalogModifier](#type-catalogmodifier).</value>
        [DataMember(Name="catalog_object_id", EmitDefaultValue=false)]
        public string CatalogObjectId { get; set; }
        /// <summary>
        /// The name of the item modifier.
        /// </summary>
        /// <value>The name of the item modifier.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The base price for the modifier.  &#x60;base_price_money&#x60; is required for ad hoc modifiers. If both &#x60;catalog_object_id&#x60; and &#x60;base_price_money&#x60; are set, &#x60;base_price_money&#x60; will override the predefined [CatalogModifier](#type-catalogmodifier) price.
        /// </summary>
        /// <value>The base price for the modifier.  &#x60;base_price_money&#x60; is required for ad hoc modifiers. If both &#x60;catalog_object_id&#x60; and &#x60;base_price_money&#x60; are set, &#x60;base_price_money&#x60; will override the predefined [CatalogModifier](#type-catalogmodifier) price.</value>
        [DataMember(Name="base_price_money", EmitDefaultValue=false)]
        public Money BasePriceMoney { get; set; }
        /// <summary>
        /// The total price of the item modifier for its line item. This is the modifier&#39;s &#x60;base_price_money&#x60; multiplied by the line item&#39;s quantity.
        /// </summary>
        /// <value>The total price of the item modifier for its line item. This is the modifier&#39;s &#x60;base_price_money&#x60; multiplied by the line item&#39;s quantity.</value>
        [DataMember(Name="total_price_money", EmitDefaultValue=false)]
        public Money TotalPriceMoney { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderLineItemModifier {\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  CatalogObjectId: ").Append(CatalogObjectId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BasePriceMoney: ").Append(BasePriceMoney).Append("\n");
            sb.Append("  TotalPriceMoney: ").Append(TotalPriceMoney).Append("\n");
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
            return this.Equals(obj as OrderLineItemModifier);
        }

        /// <summary>
        /// Returns true if OrderLineItemModifier instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderLineItemModifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderLineItemModifier other)
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
                    this.CatalogObjectId == other.CatalogObjectId ||
                    this.CatalogObjectId != null &&
                    this.CatalogObjectId.Equals(other.CatalogObjectId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.BasePriceMoney == other.BasePriceMoney ||
                    this.BasePriceMoney != null &&
                    this.BasePriceMoney.Equals(other.BasePriceMoney)
                ) && 
                (
                    this.TotalPriceMoney == other.TotalPriceMoney ||
                    this.TotalPriceMoney != null &&
                    this.TotalPriceMoney.Equals(other.TotalPriceMoney)
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
                if (this.CatalogObjectId != null)
                    hash = hash * 59 + this.CatalogObjectId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.BasePriceMoney != null)
                    hash = hash * 59 + this.BasePriceMoney.GetHashCode();
                if (this.TotalPriceMoney != null)
                    hash = hash * 59 + this.TotalPriceMoney.GetHashCode();
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

            // CatalogObjectId (string) maxLength
            if(this.CatalogObjectId != null && this.CatalogObjectId.Length > 192)
            {
                yield return new ValidationResult("Invalid value for CatalogObjectId, length must be less than 192.", new [] { "CatalogObjectId" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            yield break;
        }
    }

}
