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
    /// RecordPostOrPut
    /// </summary>
    [DataContract(Name = "RecordPostOrPut")]
    public partial class RecordPostOrPut : IEquatable<RecordPostOrPut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordPostOrPut" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="entry">entry.</param>
        /// <param name="description">description.</param>
        /// <param name="answersList">answersList.</param>
        /// <param name="policy">policy.</param>
        /// <param name="weight">weight.</param>
        /// <param name="recordType">recordType.</param>
        /// <param name="ttl">ttl.</param>
        public RecordPostOrPut(int id = default(int), string entry = default(string), string description = default(string), List<string> answersList = default(List<string>), string policy = default(string), int weight = default(int), string recordType = default(string), int ttl = default(int))
        {
            this.Id = id;
            this.Entry = entry;
            this.Description = description;
            this.AnswersList = answersList;
            this.Policy = policy;
            this.Weight = weight;
            this.RecordType = recordType;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Entry
        /// </summary>
        [DataMember(Name = "entry", EmitDefaultValue = false)]
        public string Entry { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets AnswersList
        /// </summary>
        [DataMember(Name = "answers_list", EmitDefaultValue = false)]
        public List<string> AnswersList { get; set; }

        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name = "policy", EmitDefaultValue = false)]
        public string Policy { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public int Weight { get; set; }

        /// <summary>
        /// Gets or Sets RecordType
        /// </summary>
        [DataMember(Name = "record_type", EmitDefaultValue = false)]
        public string RecordType { get; set; }

        /// <summary>
        /// Gets or Sets Ttl
        /// </summary>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]
        public int Ttl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecordPostOrPut {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Entry: ").Append(Entry).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AnswersList: ").Append(AnswersList).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  RecordType: ").Append(RecordType).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
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
            return this.Equals(input as RecordPostOrPut);
        }

        /// <summary>
        /// Returns true if RecordPostOrPut instances are equal
        /// </summary>
        /// <param name="input">Instance of RecordPostOrPut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordPostOrPut input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Entry == input.Entry ||
                    (this.Entry != null &&
                    this.Entry.Equals(input.Entry))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.AnswersList == input.AnswersList ||
                    this.AnswersList != null &&
                    input.AnswersList != null &&
                    this.AnswersList.SequenceEqual(input.AnswersList)
                ) && 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) && 
                (
                    this.Weight == input.Weight ||
                    this.Weight.Equals(input.Weight)
                ) && 
                (
                    this.RecordType == input.RecordType ||
                    (this.RecordType != null &&
                    this.RecordType.Equals(input.RecordType))
                ) && 
                (
                    this.Ttl == input.Ttl ||
                    this.Ttl.Equals(input.Ttl)
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Entry != null)
                {
                    hashCode = (hashCode * 59) + this.Entry.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.AnswersList != null)
                {
                    hashCode = (hashCode * 59) + this.AnswersList.GetHashCode();
                }
                if (this.Policy != null)
                {
                    hashCode = (hashCode * 59) + this.Policy.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Weight.GetHashCode();
                if (this.RecordType != null)
                {
                    hashCode = (hashCode * 59) + this.RecordType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
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
