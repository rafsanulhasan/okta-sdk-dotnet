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
    /// OAuth2Scope
    /// </summary>
    [DataContract(Name = "OAuth2Scope")]
    
    public partial class OAuth2Scope : IEquatable<OAuth2Scope>
    {

        /// <summary>
        /// Gets or Sets Consent
        /// </summary>
        [DataMember(Name = "consent", EmitDefaultValue = true)]
        
        public OAuth2ScopeConsentType Consent { get; set; }

        /// <summary>
        /// Gets or Sets MetadataPublish
        /// </summary>
        [DataMember(Name = "metadataPublish", EmitDefaultValue = true)]
        
        public OAuth2ScopeMetadataPublish MetadataPublish { get; set; }
        
        /// <summary>
        /// Indicates if this Scope is a default scope
        /// </summary>
        /// <value>Indicates if this Scope is a default scope</value>
        [DataMember(Name = "default", EmitDefaultValue = true)]
        public bool Default { get; set; }

        /// <summary>
        /// Description of the Scope
        /// </summary>
        /// <value>Description of the Scope</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Name of the end user displayed in a consent dialog
        /// </summary>
        /// <value>Name of the end user displayed in a consent dialog</value>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Scope object ID
        /// </summary>
        /// <value>Scope object ID</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Scope name
        /// </summary>
        /// <value>Scope name</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Optional
        /// </summary>
        [DataMember(Name = "optional", EmitDefaultValue = true)]
        public bool Optional { get; set; }

        /// <summary>
        /// Indicates if Okta created the Scope
        /// </summary>
        /// <value>Indicates if Okta created the Scope</value>
        [DataMember(Name = "system", EmitDefaultValue = true)]
        public bool System { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OAuth2Scope {\n");
            sb.Append("  Consent: ").Append(Consent).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MetadataPublish: ").Append(MetadataPublish).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
            sb.Append("  System: ").Append(System).Append("\n");
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
            return this.Equals(input as OAuth2Scope);
        }

        /// <summary>
        /// Returns true if OAuth2Scope instances are equal
        /// </summary>
        /// <param name="input">Instance of OAuth2Scope to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuth2Scope input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Consent == input.Consent ||
                    this.Consent.Equals(input.Consent)
                ) && 
                (
                    this.Default == input.Default ||
                    this.Default.Equals(input.Default)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MetadataPublish == input.MetadataPublish ||
                    this.MetadataPublish.Equals(input.MetadataPublish)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Optional == input.Optional ||
                    this.Optional.Equals(input.Optional)
                ) && 
                (
                    this.System == input.System ||
                    this.System.Equals(input.System)
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
                
                if (this.Consent != null)
                {
                    hashCode = (hashCode * 59) + this.Consent.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Default.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.MetadataPublish != null)
                {
                    hashCode = (hashCode * 59) + this.MetadataPublish.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Optional.GetHashCode();
                hashCode = (hashCode * 59) + this.System.GetHashCode();
                return hashCode;
            }
        }

    }

}
