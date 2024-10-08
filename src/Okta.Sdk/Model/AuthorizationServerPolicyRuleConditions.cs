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
    /// AuthorizationServerPolicyRuleConditions
    /// </summary>
    [DataContract(Name = "AuthorizationServerPolicyRuleConditions")]
    
    public partial class AuthorizationServerPolicyRuleConditions : IEquatable<AuthorizationServerPolicyRuleConditions>
    {
        
        /// <summary>
        /// Gets or Sets GrantTypes
        /// </summary>
        [DataMember(Name = "grantTypes", EmitDefaultValue = true)]
        public GrantTypePolicyRuleCondition GrantTypes { get; set; }

        /// <summary>
        /// Gets or Sets People
        /// </summary>
        [DataMember(Name = "people", EmitDefaultValue = true)]
        public AuthorizationServerPolicyPeopleCondition People { get; set; }

        /// <summary>
        /// Gets or Sets Scopes
        /// </summary>
        [DataMember(Name = "scopes", EmitDefaultValue = true)]
        public OAuth2ScopesMediationPolicyRuleCondition Scopes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthorizationServerPolicyRuleConditions {\n");
            sb.Append("  GrantTypes: ").Append(GrantTypes).Append("\n");
            sb.Append("  People: ").Append(People).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
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
            return this.Equals(input as AuthorizationServerPolicyRuleConditions);
        }

        /// <summary>
        /// Returns true if AuthorizationServerPolicyRuleConditions instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorizationServerPolicyRuleConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorizationServerPolicyRuleConditions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GrantTypes == input.GrantTypes ||
                    (this.GrantTypes != null &&
                    this.GrantTypes.Equals(input.GrantTypes))
                ) && 
                (
                    this.People == input.People ||
                    (this.People != null &&
                    this.People.Equals(input.People))
                ) && 
                (
                    this.Scopes == input.Scopes ||
                    (this.Scopes != null &&
                    this.Scopes.Equals(input.Scopes))
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
                
                if (this.GrantTypes != null)
                {
                    hashCode = (hashCode * 59) + this.GrantTypes.GetHashCode();
                }
                if (this.People != null)
                {
                    hashCode = (hashCode * 59) + this.People.GetHashCode();
                }
                if (this.Scopes != null)
                {
                    hashCode = (hashCode * 59) + this.Scopes.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
