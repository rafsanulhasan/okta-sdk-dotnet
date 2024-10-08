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
    /// OINApplication
    /// </summary>
    [DataContract(Name = "OINApplication")]
    
    public partial class OINApplication : IEquatable<OINApplication>
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        
        public ApplicationLifecycleStatus Status { get; set; }
        
        /// <summary>
        /// Gets or Sets Accessibility
        /// </summary>
        [DataMember(Name = "accessibility", EmitDefaultValue = true)]
        public ApplicationAccessibility Accessibility { get; set; }

        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name = "credentials", EmitDefaultValue = true)]
        public SchemeApplicationCredentials Credentials { get; set; }

        /// <summary>
        /// User-defined display name for app
        /// </summary>
        /// <value>User-defined display name for app</value>
        [DataMember(Name = "label", EmitDefaultValue = true)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Licensing
        /// </summary>
        [DataMember(Name = "licensing", EmitDefaultValue = true)]
        public ApplicationLicensing Licensing { get; set; }

        /// <summary>
        /// The key name for the OIN app definition
        /// </summary>
        /// <value>The key name for the OIN app definition</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Contains any valid JSON schema for specifying properties that can be referenced from a request (only available to OAuth 2.0 client apps)
        /// </summary>
        /// <value>Contains any valid JSON schema for specifying properties that can be referenced from a request (only available to OAuth 2.0 client apps)</value>
        [DataMember(Name = "profile", EmitDefaultValue = true)]
        public Dictionary<string, Object> Profile { get; set; }

        /// <summary>
        /// Authentication mode for the app
        /// </summary>
        /// <value>Authentication mode for the app</value>
        [DataMember(Name = "signOnMode", EmitDefaultValue = true)]
        public string SignOnMode { get; set; }

        /// <summary>
        /// Gets or Sets Visibility
        /// </summary>
        [DataMember(Name = "visibility", EmitDefaultValue = true)]
        public ApplicationVisibility Visibility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OINApplication {\n");
            sb.Append("  Accessibility: ").Append(Accessibility).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Licensing: ").Append(Licensing).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  SignOnMode: ").Append(SignOnMode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
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
            return this.Equals(input as OINApplication);
        }

        /// <summary>
        /// Returns true if OINApplication instances are equal
        /// </summary>
        /// <param name="input">Instance of OINApplication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OINApplication input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Accessibility == input.Accessibility ||
                    (this.Accessibility != null &&
                    this.Accessibility.Equals(input.Accessibility))
                ) && 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Licensing == input.Licensing ||
                    (this.Licensing != null &&
                    this.Licensing.Equals(input.Licensing))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Profile == input.Profile ||
                    this.Profile != null &&
                    input.Profile != null &&
                    this.Profile.SequenceEqual(input.Profile)
                ) && 
                (
                    this.SignOnMode == input.SignOnMode ||
                    (this.SignOnMode != null &&
                    this.SignOnMode.Equals(input.SignOnMode))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    (this.Visibility != null &&
                    this.Visibility.Equals(input.Visibility))
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
                
                if (this.Accessibility != null)
                {
                    hashCode = (hashCode * 59) + this.Accessibility.GetHashCode();
                }
                if (this.Credentials != null)
                {
                    hashCode = (hashCode * 59) + this.Credentials.GetHashCode();
                }
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                if (this.Licensing != null)
                {
                    hashCode = (hashCode * 59) + this.Licensing.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Profile != null)
                {
                    hashCode = (hashCode * 59) + this.Profile.GetHashCode();
                }
                if (this.SignOnMode != null)
                {
                    hashCode = (hashCode * 59) + this.SignOnMode.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Visibility != null)
                {
                    hashCode = (hashCode * 59) + this.Visibility.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
