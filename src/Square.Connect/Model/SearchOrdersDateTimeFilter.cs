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
    /// Filter for &#x60;Order&#x60; objects based on whether their &#x60;CREATED_AT&#x60;, &#x60;CLOSED_AT&#x60; or &#x60;UPDATED_AT&#x60; timestamps fall within a specified time range. You can specify the time range and which timestamp to filter for. You can filter for only one time range at a time.  For each time range, the start time and end time are inclusive. If the end time is absent, it defaults to the time of the first request for the cursor.  __Important:__ If you use the DateTimeFilter to filter for &#x60;CLOSED_AT&#x60; or &#x60;UPDATED_AT&#x60;, you must also set the [OrdersSort](#type-searchorderordersort). The TimeRange used in DateTimeFilter must correspond to the &#x60;sort_field&#x60; in the [OrdersSort](#type-searchorderordersort) object.
    /// </summary>
    [DataContract]
    public partial class SearchOrdersDateTimeFilter :  IEquatable<SearchOrdersDateTimeFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchOrdersDateTimeFilter" /> class.
        /// </summary>
        /// <param name="CreatedAt">Time range for filtering on the &#x60;created_at&#x60; timestamp..</param>
        /// <param name="UpdatedAt">Time range for filtering on the &#x60;updated_at&#x60; timestamp..</param>
        /// <param name="ClosedAt">Time range for filtering on the &#x60;closed_at&#x60; timestamp..</param>
        public SearchOrdersDateTimeFilter(TimeRange CreatedAt = default(TimeRange), TimeRange UpdatedAt = default(TimeRange), TimeRange ClosedAt = default(TimeRange))
        {
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            this.ClosedAt = ClosedAt;
        }
        
        /// <summary>
        /// Time range for filtering on the &#x60;created_at&#x60; timestamp.
        /// </summary>
        /// <value>Time range for filtering on the &#x60;created_at&#x60; timestamp.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public TimeRange CreatedAt { get; set; }
        /// <summary>
        /// Time range for filtering on the &#x60;updated_at&#x60; timestamp.
        /// </summary>
        /// <value>Time range for filtering on the &#x60;updated_at&#x60; timestamp.</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public TimeRange UpdatedAt { get; set; }
        /// <summary>
        /// Time range for filtering on the &#x60;closed_at&#x60; timestamp.
        /// </summary>
        /// <value>Time range for filtering on the &#x60;closed_at&#x60; timestamp.</value>
        [DataMember(Name="closed_at", EmitDefaultValue=false)]
        public TimeRange ClosedAt { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchOrdersDateTimeFilter {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ClosedAt: ").Append(ClosedAt).Append("\n");
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
            return this.Equals(obj as SearchOrdersDateTimeFilter);
        }

        /// <summary>
        /// Returns true if SearchOrdersDateTimeFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchOrdersDateTimeFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchOrdersDateTimeFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.ClosedAt == other.ClosedAt ||
                    this.ClosedAt != null &&
                    this.ClosedAt.Equals(other.ClosedAt)
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
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                if (this.ClosedAt != null)
                    hash = hash * 59 + this.ClosedAt.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
