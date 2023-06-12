/*
 * Intelligent DNS
 *
 * Azion Intelligent DNS API
 *
 * The version of the OpenAPI document: 3.0.0
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
using OpenAPIDateConverter = idns.Client.OpenAPIDateConverter;

namespace idns.Model
{
    /// <summary>
    /// DnsSec
    /// </summary>
    [DataContract(Name = "DnsSec")]
    public partial class DnsSec : IEquatable<DnsSec>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Unconfigured for value: unconfigured
            /// </summary>
            [EnumMember(Value = "unconfigured")]
            Unconfigured = 1,

            /// <summary>
            /// Enum Waiting for value: waiting
            /// </summary>
            [EnumMember(Value = "waiting")]
            Waiting = 2,

            /// <summary>
            /// Enum Ready for value: ready
            /// </summary>
            [EnumMember(Value = "ready")]
            Ready = 3

        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DnsSec" /> class.
        /// </summary>
        /// <param name="isEnabled">isEnabled.</param>
        /// <param name="status">status.</param>
        /// <param name="delegationSigner">delegationSigner.</param>
        public DnsSec(bool isEnabled = default(bool), StatusEnum? status = default(StatusEnum?), DnsSecDelegationSigner delegationSigner = default(DnsSecDelegationSigner))
        {
            this.IsEnabled = isEnabled;
            this.Status = status;
            this.DelegationSigner = delegationSigner;
        }

        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name = "is_enabled", EmitDefaultValue = true)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets DelegationSigner
        /// </summary>
        [DataMember(Name = "delegation_signer", EmitDefaultValue = false)]
        public DnsSecDelegationSigner DelegationSigner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DnsSec {\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DelegationSigner: ").Append(DelegationSigner).Append("\n");
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
            return this.Equals(input as DnsSec);
        }

        /// <summary>
        /// Returns true if DnsSec instances are equal
        /// </summary>
        /// <param name="input">Instance of DnsSec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DnsSec input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.DelegationSigner == input.DelegationSigner ||
                    (this.DelegationSigner != null &&
                    this.DelegationSigner.Equals(input.DelegationSigner))
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
                hashCode = (hashCode * 59) + this.IsEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.DelegationSigner != null)
                {
                    hashCode = (hashCode * 59) + this.DelegationSigner.GetHashCode();
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