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
    /// Filter based on [Order Fulfillment](#type-orderfulfillment) information.
    /// </summary>
    [DataContract]
    public partial class SearchOrdersFulfillmentFilter :  IEquatable<SearchOrdersFulfillmentFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchOrdersFulfillmentFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchOrdersFulfillmentFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchOrdersFulfillmentFilter" /> class.
        /// </summary>
        /// <param name="FulfillmentTypes">List of [fulfillment types](#type-orderfulfillmenttype) to filter for. Will return orders if any of its fulfillments match any of the fulfillment types listed in this field. See [OrderFulfillmentType](#type-orderfulfillmenttype) for possible values (required).</param>
        /// <param name="FulfillmentStates">List of [fulfillment states](#type-orderfulfillmentstate) to filter for. Will return orders if any of its fulfillments match any of the fulfillment states listed in this field. See [OrderFulfillmentState](#type-orderfulfillmentstate) for possible values.</param>
        public SearchOrdersFulfillmentFilter(List<string> FulfillmentTypes = default(List<string>), List<string> FulfillmentStates = default(List<string>))
        {
            // to ensure "FulfillmentTypes" is required (not null)
            if (FulfillmentTypes == null)
            {
                throw new InvalidDataException("FulfillmentTypes is a required property for SearchOrdersFulfillmentFilter and cannot be null");
            }
            else
            {
                this.FulfillmentTypes = FulfillmentTypes;
            }
            this.FulfillmentStates = FulfillmentStates;
        }
        
        /// <summary>
        /// List of [fulfillment types](#type-orderfulfillmenttype) to filter for. Will return orders if any of its fulfillments match any of the fulfillment types listed in this field. See [OrderFulfillmentType](#type-orderfulfillmenttype) for possible values
        /// </summary>
        /// <value>List of [fulfillment types](#type-orderfulfillmenttype) to filter for. Will return orders if any of its fulfillments match any of the fulfillment types listed in this field. See [OrderFulfillmentType](#type-orderfulfillmenttype) for possible values</value>
        [DataMember(Name="fulfillment_types", EmitDefaultValue=false)]
        public List<string> FulfillmentTypes { get; set; }
        /// <summary>
        /// List of [fulfillment states](#type-orderfulfillmentstate) to filter for. Will return orders if any of its fulfillments match any of the fulfillment states listed in this field. See [OrderFulfillmentState](#type-orderfulfillmentstate) for possible values
        /// </summary>
        /// <value>List of [fulfillment states](#type-orderfulfillmentstate) to filter for. Will return orders if any of its fulfillments match any of the fulfillment states listed in this field. See [OrderFulfillmentState](#type-orderfulfillmentstate) for possible values</value>
        [DataMember(Name="fulfillment_states", EmitDefaultValue=false)]
        public List<string> FulfillmentStates { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchOrdersFulfillmentFilter {\n");
            sb.Append("  FulfillmentTypes: ").Append(FulfillmentTypes).Append("\n");
            sb.Append("  FulfillmentStates: ").Append(FulfillmentStates).Append("\n");
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
            return this.Equals(obj as SearchOrdersFulfillmentFilter);
        }

        /// <summary>
        /// Returns true if SearchOrdersFulfillmentFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchOrdersFulfillmentFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchOrdersFulfillmentFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FulfillmentTypes == other.FulfillmentTypes ||
                    this.FulfillmentTypes != null &&
                    this.FulfillmentTypes.SequenceEqual(other.FulfillmentTypes)
                ) && 
                (
                    this.FulfillmentStates == other.FulfillmentStates ||
                    this.FulfillmentStates != null &&
                    this.FulfillmentStates.SequenceEqual(other.FulfillmentStates)
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
                if (this.FulfillmentTypes != null)
                    hash = hash * 59 + this.FulfillmentTypes.GetHashCode();
                if (this.FulfillmentStates != null)
                    hash = hash * 59 + this.FulfillmentStates.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
