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
    /// Defines the fields that are included in the response body of a request to the RetrieveEmployee endpoint.  One of &#x60;errors&#x60; or &#x60;employee&#x60; is present in a given response (never both).
    /// </summary>
    [DataContract]
    public partial class RetrieveEmployeeResponse :  IEquatable<RetrieveEmployeeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveEmployeeResponse" /> class.
        /// </summary>
        /// <param name="Employee">The response object..</param>
        /// <param name="Errors">Any errors that occurred during the request..</param>
        public RetrieveEmployeeResponse(Employee Employee = default(Employee), List<Error> Errors = default(List<Error>))
        {
            this.Employee = Employee;
            this.Errors = Errors;
        }
        
        /// <summary>
        /// The response object.
        /// </summary>
        /// <value>The response object.</value>
        [DataMember(Name="employee", EmitDefaultValue=false)]
        public Employee Employee { get; set; }
        /// <summary>
        /// Any errors that occurred during the request.
        /// </summary>
        /// <value>Any errors that occurred during the request.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<Error> Errors { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveEmployeeResponse {\n");
            sb.Append("  Employee: ").Append(Employee).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(obj as RetrieveEmployeeResponse);
        }

        /// <summary>
        /// Returns true if RetrieveEmployeeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RetrieveEmployeeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveEmployeeResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Employee == other.Employee ||
                    this.Employee != null &&
                    this.Employee.Equals(other.Employee)
                ) && 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
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
                if (this.Employee != null)
                    hash = hash * 59 + this.Employee.GetHashCode();
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
