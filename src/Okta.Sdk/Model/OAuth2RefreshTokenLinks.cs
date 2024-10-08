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
    /// OAuth2RefreshTokenLinks
    /// </summary>
    [DataContract(Name = "OAuth2RefreshToken__links")]
    
    public partial class OAuth2RefreshTokenLinks : IEquatable<OAuth2RefreshTokenLinks>
    {
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name = "self", EmitDefaultValue = true)]
        public HrefObjectSelfLink Self { get; set; }

        /// <summary>
        /// Gets or Sets App
        /// </summary>
        [DataMember(Name = "app", EmitDefaultValue = true)]
        public OAuth2RefreshTokenLinksAllOfApp App { get; set; }

        /// <summary>
        /// Gets or Sets Revoke
        /// </summary>
        [DataMember(Name = "revoke", EmitDefaultValue = true)]
        public OAuth2RefreshTokenLinksAllOfRevoke Revoke { get; set; }

        /// <summary>
        /// Gets or Sets _Client
        /// </summary>
        [DataMember(Name = "client", EmitDefaultValue = true)]
        public OAuth2RefreshTokenLinksAllOfClient _Client { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = true)]
        public OAuth2RefreshTokenLinksAllOfUser User { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizationServer
        /// </summary>
        [DataMember(Name = "authorizationServer", EmitDefaultValue = true)]
        public OAuth2RefreshTokenLinksAllOfAuthorizationServer AuthorizationServer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OAuth2RefreshTokenLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  App: ").Append(App).Append("\n");
            sb.Append("  Revoke: ").Append(Revoke).Append("\n");
            sb.Append("  _Client: ").Append(_Client).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  AuthorizationServer: ").Append(AuthorizationServer).Append("\n");
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
            return this.Equals(input as OAuth2RefreshTokenLinks);
        }

        /// <summary>
        /// Returns true if OAuth2RefreshTokenLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of OAuth2RefreshTokenLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuth2RefreshTokenLinks input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
                (
                    this.App == input.App ||
                    (this.App != null &&
                    this.App.Equals(input.App))
                ) && 
                (
                    this.Revoke == input.Revoke ||
                    (this.Revoke != null &&
                    this.Revoke.Equals(input.Revoke))
                ) && 
                (
                    this._Client == input._Client ||
                    (this._Client != null &&
                    this._Client.Equals(input._Client))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.AuthorizationServer == input.AuthorizationServer ||
                    (this.AuthorizationServer != null &&
                    this.AuthorizationServer.Equals(input.AuthorizationServer))
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
                
                if (this.Self != null)
                {
                    hashCode = (hashCode * 59) + this.Self.GetHashCode();
                }
                if (this.App != null)
                {
                    hashCode = (hashCode * 59) + this.App.GetHashCode();
                }
                if (this.Revoke != null)
                {
                    hashCode = (hashCode * 59) + this.Revoke.GetHashCode();
                }
                if (this._Client != null)
                {
                    hashCode = (hashCode * 59) + this._Client.GetHashCode();
                }
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
                }
                if (this.AuthorizationServer != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorizationServer.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
