/*
 * Okta API
 *
 * Allows customers to easily access the Okta API
 *
 * The version of the OpenAPI document: 3.0.0
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
using JsonSubTypes;
using OpenAPIDateConverter = Okta.Sdk.Client.OpenAPIDateConverter;

namespace Okta.Sdk.Model
{
    /// <summary>
    /// Template: ModelGeneric
    /// AccessPolicyRule
    /// </summary>
    [DataContract(Name = "AccessPolicyRule")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(AccessPolicyRule), "ACCESS_POLICY")]
    [JsonSubtypes.KnownSubType(typeof(PasswordPolicyRule), "PASSWORD")]
    [JsonSubtypes.KnownSubType(typeof(ProfileEnrollmentPolicyRule), "PROFILE_ENROLLMENT")]
    [JsonSubtypes.KnownSubType(typeof(AuthorizationServerPolicyRule), "RESOURCE_ACCESS")]
    [JsonSubtypes.KnownSubType(typeof(OktaSignOnPolicyRule), "SIGN_ON")]
    public partial class AccessPolicyRule : PolicyRule, IEquatable<AccessPolicyRule>
    {
        
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name = "actions", EmitDefaultValue = false)]
        public AccessPolicyRuleActions Actions { get; set; }

        /// <summary>
        /// Gets or Sets Conditions
        /// </summary>
        [DataMember(Name = "conditions", EmitDefaultValue = false)]
        public AccessPolicyRuleConditions Conditions { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccessPolicyRule {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as AccessPolicyRule);
        }

        /// <summary>
        /// Returns true if AccessPolicyRule instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessPolicyRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessPolicyRule input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Actions == input.Actions ||
                    (this.Actions != null &&
                    this.Actions.Equals(input.Actions))
                ) && base.Equals(input) && 
                (
                    this.Conditions == input.Conditions ||
                    (this.Conditions != null &&
                    this.Conditions.Equals(input.Conditions))
                ) && base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                int hashCode = base.GetHashCode();
                if (this.Actions != null)
                {
                    hashCode = (hashCode * 59) + this.Actions.GetHashCode();
                }
                if (this.Conditions != null)
                {
                    hashCode = (hashCode * 59) + this.Conditions.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}