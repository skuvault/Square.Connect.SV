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
    /// Represents Square processing fee.
    /// </summary>
    [DataContract]
    public partial class ProcessingFee :  IEquatable<ProcessingFee>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingFee" /> class.
        /// </summary>
        /// <param name="EffectiveAt">Timestamp of when the fee takes effect, in RFC 3339 format..</param>
        /// <param name="Type">The type of fee assessed or adjusted. Can be one of: &#x60;INITIAL&#x60;, &#x60;ADJUSTMENT&#x60;..</param>
        /// <param name="AmountMoney">The fee amount assessed or adjusted by Square. May be negative.  Positive values represent funds being assessed, while negative values represent funds being returned..</param>
        public ProcessingFee(string EffectiveAt = default(string), string Type = default(string), Money AmountMoney = default(Money))
        {
            this.EffectiveAt = EffectiveAt;
            this.Type = Type;
            this.AmountMoney = AmountMoney;
        }
        
        /// <summary>
        /// Timestamp of when the fee takes effect, in RFC 3339 format.
        /// </summary>
        /// <value>Timestamp of when the fee takes effect, in RFC 3339 format.</value>
        [DataMember(Name="effective_at", EmitDefaultValue=false)]
        public string EffectiveAt { get; set; }
        /// <summary>
        /// The type of fee assessed or adjusted. Can be one of: &#x60;INITIAL&#x60;, &#x60;ADJUSTMENT&#x60;.
        /// </summary>
        /// <value>The type of fee assessed or adjusted. Can be one of: &#x60;INITIAL&#x60;, &#x60;ADJUSTMENT&#x60;.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// The fee amount assessed or adjusted by Square. May be negative.  Positive values represent funds being assessed, while negative values represent funds being returned.
        /// </summary>
        /// <value>The fee amount assessed or adjusted by Square. May be negative.  Positive values represent funds being assessed, while negative values represent funds being returned.</value>
        [DataMember(Name="amount_money", EmitDefaultValue=false)]
        public Money AmountMoney { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessingFee {\n");
            sb.Append("  EffectiveAt: ").Append(EffectiveAt).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AmountMoney: ").Append(AmountMoney).Append("\n");
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
            return this.Equals(obj as ProcessingFee);
        }

        /// <summary>
        /// Returns true if ProcessingFee instances are equal
        /// </summary>
        /// <param name="other">Instance of ProcessingFee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessingFee other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EffectiveAt == other.EffectiveAt ||
                    this.EffectiveAt != null &&
                    this.EffectiveAt.Equals(other.EffectiveAt)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.AmountMoney == other.AmountMoney ||
                    this.AmountMoney != null &&
                    this.AmountMoney.Equals(other.AmountMoney)
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
                if (this.EffectiveAt != null)
                    hash = hash * 59 + this.EffectiveAt.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.AmountMoney != null)
                    hash = hash * 59 + this.AmountMoney.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
