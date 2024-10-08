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
    /// Metadata about Okta as a transmitter and relevant information for configuration.
    /// </summary>
    [DataContract(Name = "WellKnownSSFMetadata")]
    
    public partial class WellKnownSSFMetadata : IEquatable<WellKnownSSFMetadata>
    {
        
        /// <summary>
        /// The URL of the SSF Stream configuration endpoint
        /// </summary>
        /// <value>The URL of the SSF Stream configuration endpoint</value>
        [DataMember(Name = "configuration_endpoint", EmitDefaultValue = true)]
        public string ConfigurationEndpoint { get; set; }

        /// <summary>
        /// An array of supported SET delivery methods
        /// </summary>
        /// <value>An array of supported SET delivery methods</value>
        [DataMember(Name = "delivery_methods_supported", EmitDefaultValue = true)]
        public List<string> DeliveryMethodsSupported { get; set; }

        /// <summary>
        /// The issuer used in Security Event Tokens. This value is set as &#x60;iss&#x60; in the claim.
        /// </summary>
        /// <value>The issuer used in Security Event Tokens. This value is set as &#x60;iss&#x60; in the claim.</value>
        [DataMember(Name = "issuer", EmitDefaultValue = true)]
        public string Issuer { get; set; }

        /// <summary>
        /// The URL of the JSON Web Key Set (JWKS) that contains the signing keys for validating the signatures of Security Event Tokens (SETs)
        /// </summary>
        /// <value>The URL of the JSON Web Key Set (JWKS) that contains the signing keys for validating the signatures of Security Event Tokens (SETs)</value>
        [DataMember(Name = "jwks_uri", EmitDefaultValue = true)]
        public string JwksUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WellKnownSSFMetadata {\n");
            sb.Append("  ConfigurationEndpoint: ").Append(ConfigurationEndpoint).Append("\n");
            sb.Append("  DeliveryMethodsSupported: ").Append(DeliveryMethodsSupported).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  JwksUri: ").Append(JwksUri).Append("\n");
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
            return this.Equals(input as WellKnownSSFMetadata);
        }

        /// <summary>
        /// Returns true if WellKnownSSFMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of WellKnownSSFMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WellKnownSSFMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConfigurationEndpoint == input.ConfigurationEndpoint ||
                    (this.ConfigurationEndpoint != null &&
                    this.ConfigurationEndpoint.Equals(input.ConfigurationEndpoint))
                ) && 
                (
                    this.DeliveryMethodsSupported == input.DeliveryMethodsSupported ||
                    this.DeliveryMethodsSupported != null &&
                    input.DeliveryMethodsSupported != null &&
                    this.DeliveryMethodsSupported.SequenceEqual(input.DeliveryMethodsSupported)
                ) && 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) && 
                (
                    this.JwksUri == input.JwksUri ||
                    (this.JwksUri != null &&
                    this.JwksUri.Equals(input.JwksUri))
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
                
                if (this.ConfigurationEndpoint != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurationEndpoint.GetHashCode();
                }
                if (this.DeliveryMethodsSupported != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryMethodsSupported.GetHashCode();
                }
                if (this.Issuer != null)
                {
                    hashCode = (hashCode * 59) + this.Issuer.GetHashCode();
                }
                if (this.JwksUri != null)
                {
                    hashCode = (hashCode * 59) + this.JwksUri.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
