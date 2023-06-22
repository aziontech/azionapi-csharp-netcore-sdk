/*
 * Edge Node API
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
using OpenAPIDateConverter = edgenode.Client.OpenAPIDateConverter;

namespace edgenode.Model
{
    /// <summary>
    /// UpdateServiceBindRequest
    /// </summary>
    [DataContract(Name = "UpdateServiceBindRequest")]
    public partial class UpdateServiceBindRequest : IEquatable<UpdateServiceBindRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateServiceBindRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateServiceBindRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateServiceBindRequest" /> class.
        /// </summary>
        /// <param name="variables">variables (required).</param>
        public UpdateServiceBindRequest(List<Variable> variables = default(List<Variable>))
        {
            // to ensure "variables" is required (not null)
            if (variables == null)
            {
                throw new ArgumentNullException("variables is a required property for UpdateServiceBindRequest and cannot be null");
            }
            this.Variables = variables;
        }

        /// <summary>
        /// Gets or Sets Variables
        /// </summary>
        [DataMember(Name = "variables", IsRequired = true, EmitDefaultValue = true)]
        public List<Variable> Variables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateServiceBindRequest {\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
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
            return this.Equals(input as UpdateServiceBindRequest);
        }

        /// <summary>
        /// Returns true if UpdateServiceBindRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateServiceBindRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateServiceBindRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    input.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
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
                if (this.Variables != null)
                {
                    hashCode = (hashCode * 59) + this.Variables.GetHashCode();
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
