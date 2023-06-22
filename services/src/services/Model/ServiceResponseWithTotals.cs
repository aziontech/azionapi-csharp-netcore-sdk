/*
 * Services API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
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
using OpenAPIDateConverter = services.Client.OpenAPIDateConverter;

namespace services.Model
{
    /// <summary>
    /// ServiceResponseWithTotals
    /// </summary>
    [DataContract(Name = "ServiceResponseWithTotals")]
    public partial class ServiceResponseWithTotals : IEquatable<ServiceResponseWithTotals>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceResponseWithTotals" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServiceResponseWithTotals() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceResponseWithTotals" /> class.
        /// </summary>
        /// <param name="services">services (required).</param>
        /// <param name="total">total (required).</param>
        public ServiceResponseWithTotals(List<ServiceResponse> services = default(List<ServiceResponse>), long total = default(long))
        {
            // to ensure "services" is required (not null)
            if (services == null)
            {
                throw new ArgumentNullException("services is a required property for ServiceResponseWithTotals and cannot be null");
            }
            this.Services = services;
            this.Total = total;
        }

        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [DataMember(Name = "services", IsRequired = true, EmitDefaultValue = true)]
        public List<ServiceResponse> Services { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public long Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServiceResponseWithTotals {\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as ServiceResponseWithTotals);
        }

        /// <summary>
        /// Returns true if ServiceResponseWithTotals instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceResponseWithTotals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceResponseWithTotals input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Services == input.Services ||
                    this.Services != null &&
                    input.Services != null &&
                    this.Services.SequenceEqual(input.Services)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
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
                if (this.Services != null)
                {
                    hashCode = (hashCode * 59) + this.Services.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
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
