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
    /// Filter based on order &#x60;source&#x60; information.
    /// </summary>
    [DataContract]
    public partial class SearchOrdersSourceFilter :  IEquatable<SearchOrdersSourceFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchOrdersSourceFilter" /> class.
        /// </summary>
        /// <param name="SourceNames">Filters by [Source](#type-ordersource) &#x60;name&#x60;. Will return any orders with with a &#x60;source.name&#x60; that matches any of the listed source names.  Max: 10 source names..</param>
        public SearchOrdersSourceFilter(List<string> SourceNames = default(List<string>))
        {
            this.SourceNames = SourceNames;
        }
        
        /// <summary>
        /// Filters by [Source](#type-ordersource) &#x60;name&#x60;. Will return any orders with with a &#x60;source.name&#x60; that matches any of the listed source names.  Max: 10 source names.
        /// </summary>
        /// <value>Filters by [Source](#type-ordersource) &#x60;name&#x60;. Will return any orders with with a &#x60;source.name&#x60; that matches any of the listed source names.  Max: 10 source names.</value>
        [DataMember(Name="source_names", EmitDefaultValue=false)]
        public List<string> SourceNames { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchOrdersSourceFilter {\n");
            sb.Append("  SourceNames: ").Append(SourceNames).Append("\n");
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
            return this.Equals(obj as SearchOrdersSourceFilter);
        }

        /// <summary>
        /// Returns true if SearchOrdersSourceFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchOrdersSourceFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchOrdersSourceFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SourceNames == other.SourceNames ||
                    this.SourceNames != null &&
                    this.SourceNames.SequenceEqual(other.SourceNames)
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
                if (this.SourceNames != null)
                    hash = hash * 59 + this.SourceNames.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
