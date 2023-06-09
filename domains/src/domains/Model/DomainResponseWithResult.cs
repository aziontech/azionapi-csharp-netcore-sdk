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
    /// DomainResponseWithResult
    /// </summary>
    [DataContract(Name = "DomainResponseWithResult")]
    public partial class DomainResponseWithResult : IEquatable<DomainResponseWithResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainResponseWithResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DomainResponseWithResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainResponseWithResult" /> class.
        /// </summary>
        /// <param name="schemaVersion">schemaVersion (required).</param>
        /// <param name="results">results (required).</param>
        public DomainResponseWithResult(long schemaVersion = default(long), DomainResults results = default(DomainResults))
        {
            this.SchemaVersion = schemaVersion;
            // to ensure "results" is required (not null)
            if (results == null)
            {
                throw new ArgumentNullException("results is a required property for DomainResponseWithResult and cannot be null");
            }
            this.Results = results;
        }

        /// <summary>
        /// Gets or Sets SchemaVersion
        /// </summary>
        [DataMember(Name = "schema_version", IsRequired = true, EmitDefaultValue = true)]
        public long SchemaVersion { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", IsRequired = true, EmitDefaultValue = true)]
        public DomainResults Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DomainResponseWithResult {\n");
            sb.Append("  SchemaVersion: ").Append(SchemaVersion).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(input as DomainResponseWithResult);
        }

        /// <summary>
        /// Returns true if DomainResponseWithResult instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainResponseWithResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainResponseWithResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SchemaVersion == input.SchemaVersion ||
                    this.SchemaVersion.Equals(input.SchemaVersion)
                ) && 
                (
                    this.Results == input.Results ||
                    (this.Results != null &&
                    this.Results.Equals(input.Results))
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
                hashCode = (hashCode * 59) + this.SchemaVersion.GetHashCode();
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
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
