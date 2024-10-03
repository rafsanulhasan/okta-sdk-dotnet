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
    /// AuthorizationServerCredentialsSigningConfig
    /// </summary>
    [DataContract(Name = "AuthorizationServerCredentialsSigningConfig")]
    
    public partial class AuthorizationServerCredentialsSigningConfig : IEquatable<AuthorizationServerCredentialsSigningConfig>
    {

        /// <summary>
        /// Gets or Sets RotationMode
        /// </summary>
        [DataMember(Name = "rotationMode", EmitDefaultValue = true)]
        
        public AuthorizationServerCredentialsRotationMode RotationMode { get; set; }

        /// <summary>
        /// Gets or Sets Use
        /// </summary>
        [DataMember(Name = "use", EmitDefaultValue = true)]
        
        public AuthorizationServerCredentialsUse Use { get; set; }
        
        /// <summary>
        /// The ID of the JSON Web Key used for signing tokens issued by the authorization server
        /// </summary>
        /// <value>The ID of the JSON Web Key used for signing tokens issued by the authorization server</value>
        [DataMember(Name = "kid", EmitDefaultValue = true)]
        public string Kid { get; private set; }

        /// <summary>
        /// Returns false as Kid should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeKid()
        {
            return false;
        }
        /// <summary>
        /// The timestamp when the authorization server started using the &#x60;kid&#x60; for signing tokens
        /// </summary>
        /// <value>The timestamp when the authorization server started using the &#x60;kid&#x60; for signing tokens</value>
        [DataMember(Name = "lastRotated", EmitDefaultValue = true)]
        public DateTimeOffset LastRotated { get; private set; }

        /// <summary>
        /// Returns false as LastRotated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastRotated()
        {
            return false;
        }
        /// <summary>
        /// The timestamp when the authorization server changes the Key for signing tokens. This is only returned when &#x60;rotationMode&#x60; is set to &#x60;AUTO&#x60;.
        /// </summary>
        /// <value>The timestamp when the authorization server changes the Key for signing tokens. This is only returned when &#x60;rotationMode&#x60; is set to &#x60;AUTO&#x60;.</value>
        [DataMember(Name = "nextRotation", EmitDefaultValue = true)]
        public DateTimeOffset NextRotation { get; private set; }

        /// <summary>
        /// Returns false as NextRotation should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNextRotation()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthorizationServerCredentialsSigningConfig {\n");
            sb.Append("  Kid: ").Append(Kid).Append("\n");
            sb.Append("  LastRotated: ").Append(LastRotated).Append("\n");
            sb.Append("  NextRotation: ").Append(NextRotation).Append("\n");
            sb.Append("  RotationMode: ").Append(RotationMode).Append("\n");
            sb.Append("  Use: ").Append(Use).Append("\n");
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
            return this.Equals(input as AuthorizationServerCredentialsSigningConfig);
        }

        /// <summary>
        /// Returns true if AuthorizationServerCredentialsSigningConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorizationServerCredentialsSigningConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorizationServerCredentialsSigningConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Kid == input.Kid ||
                    (this.Kid != null &&
                    this.Kid.Equals(input.Kid))
                ) && 
                (
                    this.LastRotated == input.LastRotated ||
                    (this.LastRotated != null &&
                    this.LastRotated.Equals(input.LastRotated))
                ) && 
                (
                    this.NextRotation == input.NextRotation ||
                    (this.NextRotation != null &&
                    this.NextRotation.Equals(input.NextRotation))
                ) && 
                (
                    this.RotationMode == input.RotationMode ||
                    this.RotationMode.Equals(input.RotationMode)
                ) && 
                (
                    this.Use == input.Use ||
                    this.Use.Equals(input.Use)
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
                
                if (this.Kid != null)
                {
                    hashCode = (hashCode * 59) + this.Kid.GetHashCode();
                }
                if (this.LastRotated != null)
                {
                    hashCode = (hashCode * 59) + this.LastRotated.GetHashCode();
                }
                if (this.NextRotation != null)
                {
                    hashCode = (hashCode * 59) + this.NextRotation.GetHashCode();
                }
                if (this.RotationMode != null)
                {
                    hashCode = (hashCode * 59) + this.RotationMode.GetHashCode();
                }
                if (this.Use != null)
                {
                    hashCode = (hashCode * 59) + this.Use.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
