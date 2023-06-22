/*
 * Edge Application API
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
using OpenAPIDateConverter = edgeapplications.Client.OpenAPIDateConverter;

namespace edgeapplications.Model
{
    /// <summary>
    /// UpdateOriginsRequest
    /// </summary>
    [DataContract(Name = "UpdateOriginsRequest")]
    public partial class UpdateOriginsRequest : IEquatable<UpdateOriginsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOriginsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateOriginsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOriginsRequest" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="originType">originType.</param>
        /// <param name="addresses">addresses (required).</param>
        /// <param name="originProtocolPolicy">originProtocolPolicy.</param>
        /// <param name="hostHeader">hostHeader (required).</param>
        /// <param name="originPath">originPath.</param>
        /// <param name="hmacAuthentication">hmacAuthentication.</param>
        /// <param name="hmacRegionName">hmacRegionName.</param>
        /// <param name="hmacAccessKey">hmacAccessKey.</param>
        /// <param name="hmacSecretKey">hmacSecretKey.</param>
        public UpdateOriginsRequest(string name = default(string), string originType = default(string), List<CreateOriginsRequestAddresses> addresses = default(List<CreateOriginsRequestAddresses>), string originProtocolPolicy = default(string), string hostHeader = default(string), string originPath = default(string), bool hmacAuthentication = default(bool), string hmacRegionName = default(string), string hmacAccessKey = default(string), string hmacSecretKey = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for UpdateOriginsRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "addresses" is required (not null)
            if (addresses == null)
            {
                throw new ArgumentNullException("addresses is a required property for UpdateOriginsRequest and cannot be null");
            }
            this.Addresses = addresses;
            // to ensure "hostHeader" is required (not null)
            if (hostHeader == null)
            {
                throw new ArgumentNullException("hostHeader is a required property for UpdateOriginsRequest and cannot be null");
            }
            this.HostHeader = hostHeader;
            this.OriginType = originType;
            this.OriginProtocolPolicy = originProtocolPolicy;
            this.OriginPath = originPath;
            this.HmacAuthentication = hmacAuthentication;
            this.HmacRegionName = hmacRegionName;
            this.HmacAccessKey = hmacAccessKey;
            this.HmacSecretKey = hmacSecretKey;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OriginType
        /// </summary>
        [DataMember(Name = "origin_type", EmitDefaultValue = false)]
        public string OriginType { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name = "addresses", IsRequired = true, EmitDefaultValue = true)]
        public List<CreateOriginsRequestAddresses> Addresses { get; set; }

        /// <summary>
        /// Gets or Sets OriginProtocolPolicy
        /// </summary>
        [DataMember(Name = "origin_protocol_policy", EmitDefaultValue = false)]
        public string OriginProtocolPolicy { get; set; }

        /// <summary>
        /// Gets or Sets HostHeader
        /// </summary>
        [DataMember(Name = "host_header", IsRequired = true, EmitDefaultValue = true)]
        public string HostHeader { get; set; }

        /// <summary>
        /// Gets or Sets OriginPath
        /// </summary>
        [DataMember(Name = "origin_path", EmitDefaultValue = false)]
        public string OriginPath { get; set; }

        /// <summary>
        /// Gets or Sets HmacAuthentication
        /// </summary>
        [DataMember(Name = "hmac_authentication", EmitDefaultValue = true)]
        public bool HmacAuthentication { get; set; }

        /// <summary>
        /// Gets or Sets HmacRegionName
        /// </summary>
        [DataMember(Name = "hmac_region_name", EmitDefaultValue = false)]
        public string HmacRegionName { get; set; }

        /// <summary>
        /// Gets or Sets HmacAccessKey
        /// </summary>
        [DataMember(Name = "hmac_access_key", EmitDefaultValue = false)]
        public string HmacAccessKey { get; set; }

        /// <summary>
        /// Gets or Sets HmacSecretKey
        /// </summary>
        [DataMember(Name = "hmac_secret_key", EmitDefaultValue = false)]
        public string HmacSecretKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateOriginsRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OriginType: ").Append(OriginType).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  OriginProtocolPolicy: ").Append(OriginProtocolPolicy).Append("\n");
            sb.Append("  HostHeader: ").Append(HostHeader).Append("\n");
            sb.Append("  OriginPath: ").Append(OriginPath).Append("\n");
            sb.Append("  HmacAuthentication: ").Append(HmacAuthentication).Append("\n");
            sb.Append("  HmacRegionName: ").Append(HmacRegionName).Append("\n");
            sb.Append("  HmacAccessKey: ").Append(HmacAccessKey).Append("\n");
            sb.Append("  HmacSecretKey: ").Append(HmacSecretKey).Append("\n");
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
            return this.Equals(input as UpdateOriginsRequest);
        }

        /// <summary>
        /// Returns true if UpdateOriginsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateOriginsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateOriginsRequest input)
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
                    this.OriginType == input.OriginType ||
                    (this.OriginType != null &&
                    this.OriginType.Equals(input.OriginType))
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.OriginProtocolPolicy == input.OriginProtocolPolicy ||
                    (this.OriginProtocolPolicy != null &&
                    this.OriginProtocolPolicy.Equals(input.OriginProtocolPolicy))
                ) && 
                (
                    this.HostHeader == input.HostHeader ||
                    (this.HostHeader != null &&
                    this.HostHeader.Equals(input.HostHeader))
                ) && 
                (
                    this.OriginPath == input.OriginPath ||
                    (this.OriginPath != null &&
                    this.OriginPath.Equals(input.OriginPath))
                ) && 
                (
                    this.HmacAuthentication == input.HmacAuthentication ||
                    this.HmacAuthentication.Equals(input.HmacAuthentication)
                ) && 
                (
                    this.HmacRegionName == input.HmacRegionName ||
                    (this.HmacRegionName != null &&
                    this.HmacRegionName.Equals(input.HmacRegionName))
                ) && 
                (
                    this.HmacAccessKey == input.HmacAccessKey ||
                    (this.HmacAccessKey != null &&
                    this.HmacAccessKey.Equals(input.HmacAccessKey))
                ) && 
                (
                    this.HmacSecretKey == input.HmacSecretKey ||
                    (this.HmacSecretKey != null &&
                    this.HmacSecretKey.Equals(input.HmacSecretKey))
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
                if (this.OriginType != null)
                {
                    hashCode = (hashCode * 59) + this.OriginType.GetHashCode();
                }
                if (this.Addresses != null)
                {
                    hashCode = (hashCode * 59) + this.Addresses.GetHashCode();
                }
                if (this.OriginProtocolPolicy != null)
                {
                    hashCode = (hashCode * 59) + this.OriginProtocolPolicy.GetHashCode();
                }
                if (this.HostHeader != null)
                {
                    hashCode = (hashCode * 59) + this.HostHeader.GetHashCode();
                }
                if (this.OriginPath != null)
                {
                    hashCode = (hashCode * 59) + this.OriginPath.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HmacAuthentication.GetHashCode();
                if (this.HmacRegionName != null)
                {
                    hashCode = (hashCode * 59) + this.HmacRegionName.GetHashCode();
                }
                if (this.HmacAccessKey != null)
                {
                    hashCode = (hashCode * 59) + this.HmacAccessKey.GetHashCode();
                }
                if (this.HmacSecretKey != null)
                {
                    hashCode = (hashCode * 59) + this.HmacSecretKey.GetHashCode();
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
