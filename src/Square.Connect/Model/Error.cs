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
    /// Represents an error encountered during a request to the Connect API.
    /// </summary>
    [DataContract]
    public partial class Error :  IEquatable<Error>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Error() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="Category">The high-level category for the error. See [ErrorCategory](#type-errorcategory) See [ErrorCategory](#type-errorcategory) for possible values (required).</param>
        /// <param name="Code">The specific code of the error. See [ErrorCode](#type-errorcode) for possible See [ErrorCode](#type-errorcode) for possible values (required).</param>
        /// <param name="Detail">A human-readable description of the error for debugging purposes..</param>
        /// <param name="Field">The name of the field provided in the original request (if any) that the error pertains to..</param>
        public Error(string Category = default(string), string Code = default(string), string Detail = default(string), string Field = default(string))
        {
            // to ensure "Category" is required (not null)
            if (Category == null)
            {
                throw new InvalidDataException("Category is a required property for Error and cannot be null");
            }
            else
            {
                this.Category = Category;
            }
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for Error and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            this.Detail = Detail;
            this.Field = Field;
        }
        
        /// <summary>
        /// The high-level category for the error. See [ErrorCategory](#type-errorcategory) See [ErrorCategory](#type-errorcategory) for possible values
        /// </summary>
        /// <value>The high-level category for the error. See [ErrorCategory](#type-errorcategory) See [ErrorCategory](#type-errorcategory) for possible values</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }
        /// <summary>
        /// The specific code of the error. See [ErrorCode](#type-errorcode) for possible See [ErrorCode](#type-errorcode) for possible values
        /// </summary>
        /// <value>The specific code of the error. See [ErrorCode](#type-errorcode) for possible See [ErrorCode](#type-errorcode) for possible values</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }
        /// <summary>
        /// A human-readable description of the error for debugging purposes.
        /// </summary>
        /// <value>A human-readable description of the error for debugging purposes.</value>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        public string Detail { get; set; }
        /// <summary>
        /// The name of the field provided in the original request (if any) that the error pertains to.
        /// </summary>
        /// <value>The name of the field provided in the original request (if any) that the error pertains to.</value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
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
            return this.Equals(obj as Error);
        }

        /// <summary>
        /// Returns true if Error instances are equal
        /// </summary>
        /// <param name="other">Instance of Error to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Error other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Detail == other.Detail ||
                    this.Detail != null &&
                    this.Detail.Equals(other.Detail)
                ) && 
                (
                    this.Field == other.Field ||
                    this.Field != null &&
                    this.Field.Equals(other.Field)
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
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.Detail != null)
                    hash = hash * 59 + this.Detail.GetHashCode();
                if (this.Field != null)
                    hash = hash * 59 + this.Field.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
