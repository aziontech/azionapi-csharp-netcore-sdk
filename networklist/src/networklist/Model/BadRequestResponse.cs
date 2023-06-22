/*
 * Network Lists API
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
using OpenAPIDateConverter = networklist.Client.OpenAPIDateConverter;

namespace networklist.Model
{
    /// <summary>
    /// BadRequestResponse
    /// </summary>
    [DataContract(Name = "BadRequestResponse")]
    public partial class BadRequestResponse : IEquatable<BadRequestResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestResponse" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="itemsValues">itemsValues.</param>
        /// <param name="listType">listType.</param>
        public BadRequestResponse(List<string> name = default(List<string>), List<string> itemsValues = default(List<string>), List<string> listType = default(List<string>))
        {
            this.Name = name;
            this.ItemsValues = itemsValues;
            this.ListType = listType;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public List<string> Name { get; set; }

        /// <summary>
        /// Gets or Sets ItemsValues
        /// </summary>
        [DataMember(Name = "items_values", EmitDefaultValue = false)]
        public List<string> ItemsValues { get; set; }

        /// <summary>
        /// Gets or Sets ListType
        /// </summary>
        [DataMember(Name = "list_type", EmitDefaultValue = false)]
        public List<string> ListType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BadRequestResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ItemsValues: ").Append(ItemsValues).Append("\n");
            sb.Append("  ListType: ").Append(ListType).Append("\n");
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
            return this.Equals(input as BadRequestResponse);
        }

        /// <summary>
        /// Returns true if BadRequestResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BadRequestResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BadRequestResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    input.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.ItemsValues == input.ItemsValues ||
                    this.ItemsValues != null &&
                    input.ItemsValues != null &&
                    this.ItemsValues.SequenceEqual(input.ItemsValues)
                ) && 
                (
                    this.ListType == input.ListType ||
                    this.ListType != null &&
                    input.ListType != null &&
                    this.ListType.SequenceEqual(input.ListType)
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
                if (this.ItemsValues != null)
                {
                    hashCode = (hashCode * 59) + this.ItemsValues.GetHashCode();
                }
                if (this.ListType != null)
                {
                    hashCode = (hashCode * 59) + this.ListType.GetHashCode();
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
