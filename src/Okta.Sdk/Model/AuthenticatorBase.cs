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
    /// AuthenticatorBase
    /// </summary>
    [DataContract(Name = "AuthenticatorBase")]
    [JsonConverter(typeof(JsonSubtypes), "Key")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyCustomApp), "AuthenticatorKeyCustomApp")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyDuo), "AuthenticatorKeyDuo")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyEmail), "AuthenticatorKeyEmail")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyExternalIdp), "AuthenticatorKeyExternalIdp")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyGoogleOtp), "AuthenticatorKeyGoogleOtp")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyOktaVerify), "AuthenticatorKeyOktaVerify")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyOnprem), "AuthenticatorKeyOnprem")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyPassword), "AuthenticatorKeyPassword")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyPhone), "AuthenticatorKeyPhone")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeySecurityKey), "AuthenticatorKeySecurityKey")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeySecurityQuestion), "AuthenticatorKeySecurityQuestion")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeySmartCard), "AuthenticatorKeySmartCard")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeySymantecVip), "AuthenticatorKeySymantecVip")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyWebauthn), "AuthenticatorKeyWebauthn")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyYubikey), "AuthenticatorKeyYubikey")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorSimple), "AuthenticatorSimple")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyCustomApp), "custom_app")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyDuo), "duo")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyExternalIdp), "external_idp")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyGoogleOtp), "google_otp")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyEmail), "okta_email")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyPassword), "okta_password")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyOktaVerify), "okta_verify")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyOnprem), "onprem_mfa")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyPhone), "phone_number")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeySecurityKey), "security_key")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeySecurityQuestion), "security_question")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeySmartCard), "smart_card_idp")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeySymantecVip), "symantec_vip")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyWebauthn), "webauthn")]
    [JsonSubtypes.KnownSubType(typeof(AuthenticatorKeyYubikey), "yubikey_token")]
    
    public partial class AuthenticatorBase : IEquatable<AuthenticatorBase>
    {

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        
        public AuthenticatorKeyEnum Key { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        
        public LifecycleStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        
        public AuthenticatorType Type { get; set; }
        
        /// <summary>
        /// Timestamp when the Authenticator was created
        /// </summary>
        /// <value>Timestamp when the Authenticator was created</value>
        [DataMember(Name = "created", EmitDefaultValue = true)]
        public DateTimeOffset Created { get; private set; }

        /// <summary>
        /// Returns false as Created should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreated()
        {
            return false;
        }
        /// <summary>
        /// A unique identifier for the Authenticator
        /// </summary>
        /// <value>A unique identifier for the Authenticator</value>
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
        /// Timestamp when the Authenticator was last modified
        /// </summary>
        /// <value>Timestamp when the Authenticator was last modified</value>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = true)]
        public DateTimeOffset LastUpdated { get; private set; }

        /// <summary>
        /// Returns false as LastUpdated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastUpdated()
        {
            return false;
        }
        /// <summary>
        /// Display name of the Authenticator
        /// </summary>
        /// <value>Display name of the Authenticator</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = true)]
        public AuthenticatorLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthenticatorBase {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as AuthenticatorBase);
        }

        /// <summary>
        /// Returns true if AuthenticatorBase instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticatorBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticatorBase input)
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
                    this.Key == input.Key ||
                    this.Key.Equals(input.Key)
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
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.LastUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdated.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
