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
using JsonSubTypes;
using OpenAPIDateConverter = Okta.Sdk.Client.OpenAPIDateConverter;

namespace Okta.Sdk.Model
{
    /// <summary>
    /// Template: ModelGeneric
    /// PolicyRule
    /// </summary>
    [DataContract(Name = "PolicyRule")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(AccessPolicyRule), "ACCESS_POLICY")]
    [JsonSubtypes.KnownSubType(typeof(AccessPolicyRule), "AccessPolicyRule")]
    [JsonSubtypes.KnownSubType(typeof(AuthorizationServerPolicyRule), "AuthorizationServerPolicyRule")]
    [JsonSubtypes.KnownSubType(typeof(ContinuousAccessPolicyRule), "CONTINUOUS_ACCESS")]
    [JsonSubtypes.KnownSubType(typeof(ContinuousAccessPolicyRule), "ContinuousAccessPolicyRule")]
    [JsonSubtypes.KnownSubType(typeof(EntityRiskPolicyRule), "ENTITY_RISK")]
    [JsonSubtypes.KnownSubType(typeof(EntityRiskPolicyRule), "EntityRiskPolicyRule")]
    [JsonSubtypes.KnownSubType(typeof(IdpDiscoveryPolicyRule), "IDP_DISCOVERY")]
    [JsonSubtypes.KnownSubType(typeof(IdpDiscoveryPolicyRule), "IdpDiscoveryPolicyRule")]
    [JsonSubtypes.KnownSubType(typeof(OktaSignOnPolicyRule), "OktaSignOnPolicyRule")]
    [JsonSubtypes.KnownSubType(typeof(PasswordPolicyRule), "PASSWORD")]
    [JsonSubtypes.KnownSubType(typeof(ProfileEnrollmentPolicyRule), "PROFILE_ENROLLMENT")]
    [JsonSubtypes.KnownSubType(typeof(PasswordPolicyRule), "PasswordPolicyRule")]
    [JsonSubtypes.KnownSubType(typeof(ProfileEnrollmentPolicyRule), "ProfileEnrollmentPolicyRule")]
    [JsonSubtypes.KnownSubType(typeof(AuthorizationServerPolicyRule), "RESOURCE_ACCESS")]
    [JsonSubtypes.KnownSubType(typeof(OktaSignOnPolicyRule), "SIGN_ON")]
    
    public partial class PolicyRule : IEquatable<PolicyRule>
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        
        public LifecycleStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        
        public PolicyRuleType Type { get; set; }
        
        /// <summary>
        /// Timestamp when the rule was created
        /// </summary>
        /// <value>Timestamp when the rule was created</value>
        [DataMember(Name = "created", EmitDefaultValue = true)]
        public DateTimeOffset? Created { get; private set; }

        /// <summary>
        /// Returns false as Created should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreated()
        {
            return false;
        }
        /// <summary>
        /// Identifier for the rule
        /// </summary>
        /// <value>Identifier for the rule</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Timestamp when the rule was last modified
        /// </summary>
        /// <value>Timestamp when the rule was last modified</value>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = true)]
        public DateTimeOffset? LastUpdated { get; private set; }

        /// <summary>
        /// Returns false as LastUpdated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastUpdated()
        {
            return false;
        }
        /// <summary>
        /// Name of the rule
        /// </summary>
        /// <value>Name of the rule</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Priority of the rule
        /// </summary>
        /// <value>Priority of the rule</value>
        [DataMember(Name = "priority", EmitDefaultValue = true)]
        public int? Priority { get; set; }

        /// <summary>
        /// Specifies whether Okta created the Policy Rule (&#x60;system&#x3D;true&#x60;). You can&#39;t delete Policy Rules that have &#x60;system&#x60; set to &#x60;true&#x60;.
        /// </summary>
        /// <value>Specifies whether Okta created the Policy Rule (&#x60;system&#x3D;true&#x60;). You can&#39;t delete Policy Rules that have &#x60;system&#x60; set to &#x60;true&#x60;.</value>
        [DataMember(Name = "system", EmitDefaultValue = true)]
        public bool System { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PolicyRule {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  System: ").Append(System).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as PolicyRule);
        }

        /// <summary>
        /// Returns true if PolicyRule instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyRule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.System == input.System ||
                    this.System.Equals(input.System)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.LastUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdated.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Priority != null)
                {
                    hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.System.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
