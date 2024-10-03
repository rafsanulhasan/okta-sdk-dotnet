/*
 * Okta Admin Management
 *
 * Allows customers to easily access the Okta Management APIs
 *
 * The version of the OpenAPI document: 2024.07.0
 * Contact: devex-public@okta.com
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
using OpenAPIDateConverter = Okta.Sdk.Client.OpenAPIDateConverter;

namespace Okta.Sdk.Model
{
    /// <summary>
    /// Template: ModelGeneric
    /// LifecycleExpirationPolicyRuleCondition
    /// </summary>
    [DataContract(Name = "LifecycleExpirationPolicyRuleCondition")]
    
    public partial class LifecycleExpirationPolicyRuleCondition : IEquatable<LifecycleExpirationPolicyRuleCondition>
    {
        
        /// <summary>
        /// Gets or Sets LifecycleStatus
        /// </summary>
        [DataMember(Name = "lifecycleStatus", EmitDefaultValue = true)]
        public string LifecycleStatus { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", EmitDefaultValue = true)]
        public int Number { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name = "unit", EmitDefaultValue = true)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LifecycleExpirationPolicyRuleCondition {\n");
            sb.Append("  LifecycleStatus: ").Append(LifecycleStatus).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as LifecycleExpirationPolicyRuleCondition);
        }

        /// <summary>
        /// Returns true if LifecycleExpirationPolicyRuleCondition instances are equal
        /// </summary>
        /// <param name="input">Instance of LifecycleExpirationPolicyRuleCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LifecycleExpirationPolicyRuleCondition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LifecycleStatus == input.LifecycleStatus ||
                    (this.LifecycleStatus != null &&
                    this.LifecycleStatus.Equals(input.LifecycleStatus))
                ) && 
                (
                    this.Number == input.Number ||
                    this.Number.Equals(input.Number)
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                
                if (this.LifecycleStatus != null)
                {
                    hashCode = (hashCode * 59) + this.LifecycleStatus.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Number.GetHashCode();
                if (this.Unit != null)
                {
                    hashCode = (hashCode * 59) + this.Unit.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
