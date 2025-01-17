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
    /// Represents a time period - either a single period or a repeating period.
    /// </summary>
    [DataContract]
    public partial class CatalogTimePeriod :  IEquatable<CatalogTimePeriod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogTimePeriod" /> class.
        /// </summary>
        /// <param name="_Event">An iCalendar (RFC5545) [event](https://tools.ietf.org/html/rfc5545#section-3.6.1), which specifies the name, timing, duration and recurrence of this time period.  Example:  &#x60;&#x60;&#x60; DTSTART:20190707T180000 DURATION:P2H RRULE:FREQ&#x3D;WEEKLY;BYDAY&#x3D;MO,WE,FR &#x60;&#x60;&#x60;  Only &#x60;SUMMARY&#x60;, &#x60;DTSTART&#x60;, &#x60;DURATION&#x60; and &#x60;RRULE&#x60; fields are supported. &#x60;DTSTART&#x60; must be in local (unzoned) time format. Note that while &#x60;BEGIN:VEVENT&#x60; and &#x60;END:VEVENT&#x60; is not required in the request. The response will always include them..</param>
        public CatalogTimePeriod(string _Event = default(string))
        {
            this._Event = _Event;
        }
        
        /// <summary>
        /// An iCalendar (RFC5545) [event](https://tools.ietf.org/html/rfc5545#section-3.6.1), which specifies the name, timing, duration and recurrence of this time period.  Example:  &#x60;&#x60;&#x60; DTSTART:20190707T180000 DURATION:P2H RRULE:FREQ&#x3D;WEEKLY;BYDAY&#x3D;MO,WE,FR &#x60;&#x60;&#x60;  Only &#x60;SUMMARY&#x60;, &#x60;DTSTART&#x60;, &#x60;DURATION&#x60; and &#x60;RRULE&#x60; fields are supported. &#x60;DTSTART&#x60; must be in local (unzoned) time format. Note that while &#x60;BEGIN:VEVENT&#x60; and &#x60;END:VEVENT&#x60; is not required in the request. The response will always include them.
        /// </summary>
        /// <value>An iCalendar (RFC5545) [event](https://tools.ietf.org/html/rfc5545#section-3.6.1), which specifies the name, timing, duration and recurrence of this time period.  Example:  &#x60;&#x60;&#x60; DTSTART:20190707T180000 DURATION:P2H RRULE:FREQ&#x3D;WEEKLY;BYDAY&#x3D;MO,WE,FR &#x60;&#x60;&#x60;  Only &#x60;SUMMARY&#x60;, &#x60;DTSTART&#x60;, &#x60;DURATION&#x60; and &#x60;RRULE&#x60; fields are supported. &#x60;DTSTART&#x60; must be in local (unzoned) time format. Note that while &#x60;BEGIN:VEVENT&#x60; and &#x60;END:VEVENT&#x60; is not required in the request. The response will always include them.</value>
        [DataMember(Name="event", EmitDefaultValue=false)]
        public string _Event { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogTimePeriod {\n");
            sb.Append("  _Event: ").Append(_Event).Append("\n");
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
            return this.Equals(obj as CatalogTimePeriod);
        }

        /// <summary>
        /// Returns true if CatalogTimePeriod instances are equal
        /// </summary>
        /// <param name="other">Instance of CatalogTimePeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogTimePeriod other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Event == other._Event ||
                    this._Event != null &&
                    this._Event.Equals(other._Event)
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
                if (this._Event != null)
                    hash = hash * 59 + this._Event.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
