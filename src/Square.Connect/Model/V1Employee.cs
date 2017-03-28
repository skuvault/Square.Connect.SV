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
    /// Represents one of a business&#39;s employees.
    /// </summary>
    [DataContract]
    public partial class V1Employee :  IEquatable<V1Employee>, IValidatableObject
    {
        /// <summary>
        /// CWhether the employee is ACTIVE or INACTIVE. Inactive employees cannot sign in to Square Register.Merchants update this field from the Square Dashboard. 
        /// </summary>
        /// <value>CWhether the employee is ACTIVE or INACTIVE. Inactive employees cannot sign in to Square Register.Merchants update this field from the Square Dashboard. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum ACTIVE for "ACTIVE"
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE,
            
            /// <summary>
            /// Enum INACTIVE for "INACTIVE"
            /// </summary>
            [EnumMember(Value = "INACTIVE")]
            INACTIVE
        }

        /// <summary>
        /// CWhether the employee is ACTIVE or INACTIVE. Inactive employees cannot sign in to Square Register.Merchants update this field from the Square Dashboard. 
        /// </summary>
        /// <value>CWhether the employee is ACTIVE or INACTIVE. Inactive employees cannot sign in to Square Register.Merchants update this field from the Square Dashboard. </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1Employee" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1Employee() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1Employee" /> class.
        /// </summary>
        /// <param name="FirstName">The employee&#39;s first name. (required).</param>
        /// <param name="LastName">The employee&#39;s last name. (required).</param>
        /// <param name="RoleIds">The ids of the employee&#39;s associated roles. Currently, you can specify only one or zero roles per employee..</param>
        /// <param name="AuthorizedLocationIds">The IDs of the locations the employee is allowed to clock in at..</param>
        /// <param name="Email">The employee&#39;s email address..</param>
        public V1Employee(string FirstName = default(string), string LastName = default(string), List<string> RoleIds = default(List<string>), List<string> AuthorizedLocationIds = default(List<string>), string Email = default(string))
        {
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for V1Employee and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "LastName" is required (not null)
            if (LastName == null)
            {
                throw new InvalidDataException("LastName is a required property for V1Employee and cannot be null");
            }
            else
            {
                this.LastName = LastName;
            }
            this.RoleIds = RoleIds;
            this.AuthorizedLocationIds = AuthorizedLocationIds;
            this.Email = Email;
        }
        
        /// <summary>
        /// The employee&#39;s unique ID.
        /// </summary>
        /// <value>The employee&#39;s unique ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// The employee&#39;s first name.
        /// </summary>
        /// <value>The employee&#39;s first name.</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// The employee&#39;s last name.
        /// </summary>
        /// <value>The employee&#39;s last name.</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// The ids of the employee&#39;s associated roles. Currently, you can specify only one or zero roles per employee.
        /// </summary>
        /// <value>The ids of the employee&#39;s associated roles. Currently, you can specify only one or zero roles per employee.</value>
        [DataMember(Name="role_ids", EmitDefaultValue=false)]
        public List<string> RoleIds { get; set; }
        /// <summary>
        /// The IDs of the locations the employee is allowed to clock in at.
        /// </summary>
        /// <value>The IDs of the locations the employee is allowed to clock in at.</value>
        [DataMember(Name="authorized_location_ids", EmitDefaultValue=false)]
        public List<string> AuthorizedLocationIds { get; set; }
        /// <summary>
        /// The employee&#39;s email address.
        /// </summary>
        /// <value>The employee&#39;s email address.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// An ID the merchant can set to associate the employee with an entity in another system.
        /// </summary>
        /// <value>An ID the merchant can set to associate the employee with an entity in another system.</value>
        [DataMember(Name="external_id", EmitDefaultValue=false)]
        public string ExternalId { get; private set; }
        /// <summary>
        /// The time when the employee entity was created, in ISO 8601 format.
        /// </summary>
        /// <value>The time when the employee entity was created, in ISO 8601 format.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; private set; }
        /// <summary>
        /// The time when the employee entity was most recently updated, in ISO 8601 format.
        /// </summary>
        /// <value>The time when the employee entity was most recently updated, in ISO 8601 format.</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1Employee {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  RoleIds: ").Append(RoleIds).Append("\n");
            sb.Append("  AuthorizedLocationIds: ").Append(AuthorizedLocationIds).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(obj as V1Employee);
        }

        /// <summary>
        /// Returns true if V1Employee instances are equal
        /// </summary>
        /// <param name="other">Instance of V1Employee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1Employee other)
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
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.RoleIds == other.RoleIds ||
                    this.RoleIds != null &&
                    this.RoleIds.SequenceEqual(other.RoleIds)
                ) && 
                (
                    this.AuthorizedLocationIds == other.AuthorizedLocationIds ||
                    this.AuthorizedLocationIds != null &&
                    this.AuthorizedLocationIds.SequenceEqual(other.AuthorizedLocationIds)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
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
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.RoleIds != null)
                    hash = hash * 59 + this.RoleIds.GetHashCode();
                if (this.AuthorizedLocationIds != null)
                    hash = hash * 59 + this.AuthorizedLocationIds.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.ExternalId != null)
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}