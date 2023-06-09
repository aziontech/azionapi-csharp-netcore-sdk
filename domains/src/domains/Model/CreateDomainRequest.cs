/*
 * Domain API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = domains.Client.OpenAPIDateConverter;

namespace domains.Model
{
    /// <summary>
    /// CreateDomainRequest
    /// </summary>
    [DataContract(Name = "CreateDomainRequest")]
    public partial class CreateDomainRequest : IEquatable<CreateDomainRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDomainRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateDomainRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDomainRequest" /> class.
        /// </summary>
        /// <param name="cnames">cnames (required).</param>
        /// <param name="cnameAccessOnly">cnameAccessOnly (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="isActive">isActive (required).</param>
        /// <param name="edgeApplicationId">edgeApplicationId (required).</param>
        /// <param name="digitalCertificateId">digitalCertificateId (required).</param>
        public CreateDomainRequest(List<string> cnames = default(List<string>), bool cnameAccessOnly = default(bool), string name = default(string), bool isActive = default(bool), long edgeApplicationId = default(long), long? digitalCertificateId = default(long?))
        {
            // to ensure "cnames" is required (not null)
            if (cnames == null)
            {
                throw new ArgumentNullException("cnames is a required property for CreateDomainRequest and cannot be null");
            }
            this.Cnames = cnames;
            this.CnameAccessOnly = cnameAccessOnly;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateDomainRequest and cannot be null");
            }
            this.Name = name;
            this.IsActive = isActive;
            this.EdgeApplicationId = edgeApplicationId;
            // to ensure "digitalCertificateId" is required (not null)
            if (digitalCertificateId == null)
            {
                throw new ArgumentNullException("digitalCertificateId is a required property for CreateDomainRequest and cannot be null");
            }
            this.DigitalCertificateId = digitalCertificateId;
        }

        /// <summary>
        /// Gets or Sets Cnames
        /// </summary>
        [DataMember(Name = "cnames", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Cnames { get; set; }

        /// <summary>
        /// Gets or Sets CnameAccessOnly
        /// </summary>
        [DataMember(Name = "cname_access_only", IsRequired = true, EmitDefaultValue = true)]
        public bool CnameAccessOnly { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "is_active", IsRequired = true, EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets EdgeApplicationId
        /// </summary>
        [DataMember(Name = "edge_application_id", IsRequired = true, EmitDefaultValue = true)]
        public long EdgeApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets DigitalCertificateId
        /// </summary>
        [DataMember(Name = "digital_certificate_id", IsRequired = true, EmitDefaultValue = true)]
        public long? DigitalCertificateId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateDomainRequest {\n");
            sb.Append("  Cnames: ").Append(Cnames).Append("\n");
            sb.Append("  CnameAccessOnly: ").Append(CnameAccessOnly).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  EdgeApplicationId: ").Append(EdgeApplicationId).Append("\n");
            sb.Append("  DigitalCertificateId: ").Append(DigitalCertificateId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDomainRequest);
        }

        /// <summary>
        /// Returns true if CreateDomainRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDomainRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDomainRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cnames == input.Cnames ||
                    this.Cnames != null &&
                    input.Cnames != null &&
                    this.Cnames.SequenceEqual(input.Cnames)
                ) && 
                (
                    this.CnameAccessOnly == input.CnameAccessOnly ||
                    this.CnameAccessOnly.Equals(input.CnameAccessOnly)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.EdgeApplicationId == input.EdgeApplicationId ||
                    this.EdgeApplicationId.Equals(input.EdgeApplicationId)
                ) && 
                (
                    this.DigitalCertificateId == input.DigitalCertificateId ||
                    (this.DigitalCertificateId != null &&
                    this.DigitalCertificateId.Equals(input.DigitalCertificateId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Cnames != null)
                {
                    hashCode = (hashCode * 59) + this.Cnames.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CnameAccessOnly.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsActive.GetHashCode();
                hashCode = (hashCode * 59) + this.EdgeApplicationId.GetHashCode();
                if (this.DigitalCertificateId != null)
                {
                    hashCode = (hashCode * 59) + this.DigitalCertificateId.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
