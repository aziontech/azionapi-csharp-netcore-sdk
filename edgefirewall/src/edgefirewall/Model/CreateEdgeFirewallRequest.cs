/*
 * Edge Firewall API
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
using OpenAPIDateConverter = edgefirewall.Client.OpenAPIDateConverter;

namespace edgefirewall.Model
{
    /// <summary>
    /// CreateEdgeFirewallRequest
    /// </summary>
    [DataContract(Name = "CreateEdgeFirewallRequest")]
    public partial class CreateEdgeFirewallRequest : IEquatable<CreateEdgeFirewallRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEdgeFirewallRequest" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="domains">domains.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="edgeFunctionsEnabled">edgeFunctionsEnabled.</param>
        /// <param name="networkProtectionEnabled">networkProtectionEnabled.</param>
        /// <param name="wafEnabled">wafEnabled.</param>
        public CreateEdgeFirewallRequest(string name = default(string), List<int> domains = default(List<int>), bool isActive = default(bool), bool edgeFunctionsEnabled = default(bool), bool networkProtectionEnabled = default(bool), bool wafEnabled = default(bool))
        {
            this.Name = name;
            this.Domains = domains;
            this.IsActive = isActive;
            this.EdgeFunctionsEnabled = edgeFunctionsEnabled;
            this.NetworkProtectionEnabled = networkProtectionEnabled;
            this.WafEnabled = wafEnabled;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Domains
        /// </summary>
        [DataMember(Name = "domains", EmitDefaultValue = false)]
        public List<int> Domains { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "is_active", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets EdgeFunctionsEnabled
        /// </summary>
        [DataMember(Name = "edge_functions_enabled", EmitDefaultValue = true)]
        public bool EdgeFunctionsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets NetworkProtectionEnabled
        /// </summary>
        [DataMember(Name = "network_protection_enabled", EmitDefaultValue = true)]
        public bool NetworkProtectionEnabled { get; set; }

        /// <summary>
        /// Gets or Sets WafEnabled
        /// </summary>
        [DataMember(Name = "waf_enabled", EmitDefaultValue = true)]
        public bool WafEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateEdgeFirewallRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Domains: ").Append(Domains).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  EdgeFunctionsEnabled: ").Append(EdgeFunctionsEnabled).Append("\n");
            sb.Append("  NetworkProtectionEnabled: ").Append(NetworkProtectionEnabled).Append("\n");
            sb.Append("  WafEnabled: ").Append(WafEnabled).Append("\n");
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
            return this.Equals(input as CreateEdgeFirewallRequest);
        }

        /// <summary>
        /// Returns true if CreateEdgeFirewallRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateEdgeFirewallRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateEdgeFirewallRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Domains == input.Domains ||
                    this.Domains != null &&
                    input.Domains != null &&
                    this.Domains.SequenceEqual(input.Domains)
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.EdgeFunctionsEnabled == input.EdgeFunctionsEnabled ||
                    this.EdgeFunctionsEnabled.Equals(input.EdgeFunctionsEnabled)
                ) && 
                (
                    this.NetworkProtectionEnabled == input.NetworkProtectionEnabled ||
                    this.NetworkProtectionEnabled.Equals(input.NetworkProtectionEnabled)
                ) && 
                (
                    this.WafEnabled == input.WafEnabled ||
                    this.WafEnabled.Equals(input.WafEnabled)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Domains != null)
                {
                    hashCode = (hashCode * 59) + this.Domains.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsActive.GetHashCode();
                hashCode = (hashCode * 59) + this.EdgeFunctionsEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.NetworkProtectionEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.WafEnabled.GetHashCode();
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
