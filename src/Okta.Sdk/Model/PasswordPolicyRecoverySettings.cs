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
    /// PasswordPolicyRecoverySettings
    /// </summary>
    [DataContract(Name = "PasswordPolicyRecoverySettings")]
    
    public partial class PasswordPolicyRecoverySettings : IEquatable<PasswordPolicyRecoverySettings>
    {
        
        /// <summary>
        /// Gets or Sets Factors
        /// </summary>
        [DataMember(Name = "factors", EmitDefaultValue = true)]
        public PasswordPolicyRecoveryFactors Factors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PasswordPolicyRecoverySettings {\n");
            sb.Append("  Factors: ").Append(Factors).Append("\n");
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
            return this.Equals(input as PasswordPolicyRecoverySettings);
        }

        /// <summary>
        /// Returns true if PasswordPolicyRecoverySettings instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordPolicyRecoverySettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordPolicyRecoverySettings input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Factors == input.Factors ||
                    (this.Factors != null &&
                    this.Factors.Equals(input.Factors))
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
                
                if (this.Factors != null)
                {
                    hashCode = (hashCode * 59) + this.Factors.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
