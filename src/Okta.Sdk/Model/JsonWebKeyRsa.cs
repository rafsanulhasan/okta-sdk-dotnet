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
    /// JsonWebKeyRsa
    /// </summary>
    [DataContract(Name = "JsonWebKeyRsa")]
    [JsonConverter(typeof(JsonSubtypes), "Kty")]
    [JsonSubtypes.KnownSubType(typeof(JsonWebKeyEC), "EC")]
    [JsonSubtypes.KnownSubType(typeof(JsonWebKeyRsa), "RSA")]
    
    public partial class JsonWebKeyRsa : SchemasJsonWebKey, IEquatable<JsonWebKeyRsa>
    {
        
        /// <summary>
        /// The key exponent of a RSA key
        /// </summary>
        /// <value>The key exponent of a RSA key</value>
        [DataMember(Name = "e", EmitDefaultValue = true)]
        public string E { get; set; }

        /// <summary>
        /// The modulus of the RSA key
        /// </summary>
        /// <value>The modulus of the RSA key</value>
        [DataMember(Name = "n", EmitDefaultValue = true)]
        public string N { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JsonWebKeyRsa {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  E: ").Append(E).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
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
            return this.Equals(input as JsonWebKeyRsa);
        }

        /// <summary>
        /// Returns true if JsonWebKeyRsa instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonWebKeyRsa to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonWebKeyRsa input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.E == input.E ||
                    (this.E != null &&
                    this.E.Equals(input.E))
                ) && base.Equals(input) && 
                (
                    this.N == input.N ||
                    (this.N != null &&
                    this.N.Equals(input.N))
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
                
                if (this.E != null)
                {
                    hashCode = (hashCode * 59) + this.E.GetHashCode();
                }
                if (this.N != null)
                {
                    hashCode = (hashCode * 59) + this.N.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
