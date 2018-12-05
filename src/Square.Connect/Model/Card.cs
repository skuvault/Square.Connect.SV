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
    /// Represents the payment details of a card to be used for payments. These details are determined by the &#x60;card_nonce&#x60; generated by &#x60;SqPaymentForm&#x60;.
    /// </summary>
    [DataContract]
    public partial class Card :  IEquatable<Card>, IValidatableObject
    {
        /// <summary>
        /// The card's brand (such as `VISA`). See [CardBrand](#type-cardbrand) for all possible values.
        /// </summary>
        /// <value>The card's brand (such as `VISA`). See [CardBrand](#type-cardbrand) for all possible values.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CardBrandEnum
        {
            
            /// <summary>
            /// Enum OTHERBRAND for "OTHER_BRAND"
            /// </summary>
            [EnumMember(Value = "OTHER_BRAND")]
            OTHERBRAND,
            
            /// <summary>
            /// Enum VISA for "VISA"
            /// </summary>
            [EnumMember(Value = "VISA")]
            VISA,
            
            /// <summary>
            /// Enum MASTERCARD for "MASTERCARD"
            /// </summary>
            [EnumMember(Value = "MASTERCARD")]
            MASTERCARD,
            
            /// <summary>
            /// Enum AMERICANEXPRESS for "AMERICAN_EXPRESS"
            /// </summary>
            [EnumMember(Value = "AMERICAN_EXPRESS")]
            AMERICANEXPRESS,
            
            /// <summary>
            /// Enum DISCOVER for "DISCOVER"
            /// </summary>
            [EnumMember(Value = "DISCOVER")]
            DISCOVER,
            
            /// <summary>
            /// Enum DISCOVERDINERS for "DISCOVER_DINERS"
            /// </summary>
            [EnumMember(Value = "DISCOVER_DINERS")]
            DISCOVERDINERS,
            
            /// <summary>
            /// Enum JCB for "JCB"
            /// </summary>
            [EnumMember(Value = "JCB")]
            JCB,
            
            /// <summary>
            /// Enum CHINAUNIONPAY for "CHINA_UNIONPAY"
            /// </summary>
            [EnumMember(Value = "CHINA_UNIONPAY")]
            CHINAUNIONPAY,
            
            /// <summary>
            /// Enum SQUAREGIFTCARD for "SQUARE_GIFT_CARD"
            /// </summary>
            [EnumMember(Value = "SQUARE_GIFT_CARD")]
            SQUAREGIFTCARD
        }

        /// <summary>
        /// The card's brand (such as `VISA`). See [CardBrand](#type-cardbrand) for all possible values.
        /// </summary>
        /// <value>The card's brand (such as `VISA`). See [CardBrand](#type-cardbrand) for all possible values.</value>
        [DataMember(Name="card_brand", EmitDefaultValue=false)]
        public CardBrandEnum? CardBrand { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Card" /> class.
        /// </summary>
        /// <param name="Id">Unique ID for this card. Generated by Square..</param>
        /// <param name="CardBrand">The card&#39;s brand (such as &#x60;VISA&#x60;). See [CardBrand](#type-cardbrand) for all possible values..</param>
        /// <param name="Last4">The last 4 digits of the card number..</param>
        /// <param name="ExpMonth">The expiration month of the associated card as an integer between 1 and 12..</param>
        /// <param name="ExpYear">The four-digit year of the card&#39;s expiration date..</param>
        /// <param name="CardholderName">The name of the cardholder..</param>
        /// <param name="BillingAddress">The billing address for this card..</param>
        /// <param name="Fingerprint">__Not currently set.__ Intended as a Square-assigned identifier, based  on the card number, to identify the card across multiple locations within a single application..</param>
        public Card(string Id = default(string), CardBrandEnum? CardBrand = default(CardBrandEnum?), string Last4 = default(string), long? ExpMonth = default(long?), long? ExpYear = default(long?), string CardholderName = default(string), Address BillingAddress = default(Address), string Fingerprint = default(string))
        {
            this.Id = Id;
            this.CardBrand = CardBrand;
            this.Last4 = Last4;
            this.ExpMonth = ExpMonth;
            this.ExpYear = ExpYear;
            this.CardholderName = CardholderName;
            this.BillingAddress = BillingAddress;
            this.Fingerprint = Fingerprint;
        }
        
        /// <summary>
        /// Unique ID for this card. Generated by Square.
        /// </summary>
        /// <value>Unique ID for this card. Generated by Square.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The last 4 digits of the card number.
        /// </summary>
        /// <value>The last 4 digits of the card number.</value>
        [DataMember(Name="last_4", EmitDefaultValue=false)]
        public string Last4 { get; set; }
        /// <summary>
        /// The expiration month of the associated card as an integer between 1 and 12.
        /// </summary>
        /// <value>The expiration month of the associated card as an integer between 1 and 12.</value>
        [DataMember(Name="exp_month", EmitDefaultValue=false)]
        public long? ExpMonth { get; set; }
        /// <summary>
        /// The four-digit year of the card&#39;s expiration date.
        /// </summary>
        /// <value>The four-digit year of the card&#39;s expiration date.</value>
        [DataMember(Name="exp_year", EmitDefaultValue=false)]
        public long? ExpYear { get; set; }
        /// <summary>
        /// The name of the cardholder.
        /// </summary>
        /// <value>The name of the cardholder.</value>
        [DataMember(Name="cardholder_name", EmitDefaultValue=false)]
        public string CardholderName { get; set; }
        /// <summary>
        /// The billing address for this card.
        /// </summary>
        /// <value>The billing address for this card.</value>
        [DataMember(Name="billing_address", EmitDefaultValue=false)]
        public Address BillingAddress { get; set; }
        /// <summary>
        /// __Not currently set.__ Intended as a Square-assigned identifier, based  on the card number, to identify the card across multiple locations within a single application.
        /// </summary>
        /// <value>__Not currently set.__ Intended as a Square-assigned identifier, based  on the card number, to identify the card across multiple locations within a single application.</value>
        [DataMember(Name="fingerprint", EmitDefaultValue=false)]
        public string Fingerprint { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Card {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CardBrand: ").Append(CardBrand).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("  ExpMonth: ").Append(ExpMonth).Append("\n");
            sb.Append("  ExpYear: ").Append(ExpYear).Append("\n");
            sb.Append("  CardholderName: ").Append(CardholderName).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
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
            return this.Equals(obj as Card);
        }

        /// <summary>
        /// Returns true if Card instances are equal
        /// </summary>
        /// <param name="other">Instance of Card to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Card other)
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
                    this.CardBrand == other.CardBrand ||
                    this.CardBrand != null &&
                    this.CardBrand.Equals(other.CardBrand)
                ) && 
                (
                    this.Last4 == other.Last4 ||
                    this.Last4 != null &&
                    this.Last4.Equals(other.Last4)
                ) && 
                (
                    this.ExpMonth == other.ExpMonth ||
                    this.ExpMonth != null &&
                    this.ExpMonth.Equals(other.ExpMonth)
                ) && 
                (
                    this.ExpYear == other.ExpYear ||
                    this.ExpYear != null &&
                    this.ExpYear.Equals(other.ExpYear)
                ) && 
                (
                    this.CardholderName == other.CardholderName ||
                    this.CardholderName != null &&
                    this.CardholderName.Equals(other.CardholderName)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    this.Fingerprint == other.Fingerprint ||
                    this.Fingerprint != null &&
                    this.Fingerprint.Equals(other.Fingerprint)
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
                if (this.CardBrand != null)
                    hash = hash * 59 + this.CardBrand.GetHashCode();
                if (this.Last4 != null)
                    hash = hash * 59 + this.Last4.GetHashCode();
                if (this.ExpMonth != null)
                    hash = hash * 59 + this.ExpMonth.GetHashCode();
                if (this.ExpYear != null)
                    hash = hash * 59 + this.ExpYear.GetHashCode();
                if (this.CardholderName != null)
                    hash = hash * 59 + this.CardholderName.GetHashCode();
                if (this.BillingAddress != null)
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                if (this.Fingerprint != null)
                    hash = hash * 59 + this.Fingerprint.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
