/*
 * Intelligent DNS API
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
using OpenAPIDateConverter = idns.Client.OpenAPIDateConverter;

namespace idns.Model
{
    /// <summary>
    /// GetRecordsResponseResults
    /// </summary>
    [DataContract(Name = "GetRecordsResponse_results")]
    public partial class GetRecordsResponseResults : IEquatable<GetRecordsResponseResults>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetRecordsResponseResults" /> class.
        /// </summary>
        /// <param name="zoneId">zoneId.</param>
        /// <param name="zoneDomain">zoneDomain.</param>
        /// <param name="records">Zone records collection.</param>
        public GetRecordsResponseResults(int zoneId = default(int), string zoneDomain = default(string), List<RecordGet> records = default(List<RecordGet>))
        {
            this.ZoneId = zoneId;
            this.ZoneDomain = zoneDomain;
            this.Records = records;
        }

        /// <summary>
        /// Gets or Sets ZoneId
        /// </summary>
        [DataMember(Name = "zone_id", EmitDefaultValue = false)]
        public int ZoneId { get; set; }

        /// <summary>
        /// Gets or Sets ZoneDomain
        /// </summary>
        [DataMember(Name = "zone_domain", EmitDefaultValue = false)]
        public string ZoneDomain { get; set; }

        /// <summary>
        /// Zone records collection
        /// </summary>
        /// <value>Zone records collection</value>
        [DataMember(Name = "records", EmitDefaultValue = false)]
        public List<RecordGet> Records { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetRecordsResponseResults {\n");
            sb.Append("  ZoneId: ").Append(ZoneId).Append("\n");
            sb.Append("  ZoneDomain: ").Append(ZoneDomain).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
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
            return this.Equals(input as GetRecordsResponseResults);
        }

        /// <summary>
        /// Returns true if GetRecordsResponseResults instances are equal
        /// </summary>
        /// <param name="input">Instance of GetRecordsResponseResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetRecordsResponseResults input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ZoneId == input.ZoneId ||
                    this.ZoneId.Equals(input.ZoneId)
                ) && 
                (
                    this.ZoneDomain == input.ZoneDomain ||
                    (this.ZoneDomain != null &&
                    this.ZoneDomain.Equals(input.ZoneDomain))
                ) && 
                (
                    this.Records == input.Records ||
                    this.Records != null &&
                    input.Records != null &&
                    this.Records.SequenceEqual(input.Records)
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
                hashCode = (hashCode * 59) + this.ZoneId.GetHashCode();
                if (this.ZoneDomain != null)
                {
                    hashCode = (hashCode * 59) + this.ZoneDomain.GetHashCode();
                }
                if (this.Records != null)
                {
                    hashCode = (hashCode * 59) + this.Records.GetHashCode();
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
