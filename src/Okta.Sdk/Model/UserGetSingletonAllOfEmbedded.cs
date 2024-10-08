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
    /// The embedded resources related to the object if the &#x60;expand&#x60; query parameter is specified
    /// </summary>
    [DataContract(Name = "UserGetSingleton_allOf__embedded")]
    
    public partial class UserGetSingletonAllOfEmbedded : IEquatable<UserGetSingletonAllOfEmbedded>
    {
        
        /// <summary>
        /// A list of access block details for the user account
        /// </summary>
        /// <value>A list of access block details for the user account</value>
        [DataMember(Name = "blocks", EmitDefaultValue = true)]
        public List<UserBlock> Blocks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserGetSingletonAllOfEmbedded {\n");
            sb.Append("  Blocks: ").Append(Blocks).Append("\n");
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
            return this.Equals(input as UserGetSingletonAllOfEmbedded);
        }

        /// <summary>
        /// Returns true if UserGetSingletonAllOfEmbedded instances are equal
        /// </summary>
        /// <param name="input">Instance of UserGetSingletonAllOfEmbedded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserGetSingletonAllOfEmbedded input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Blocks == input.Blocks ||
                    this.Blocks != null &&
                    input.Blocks != null &&
                    this.Blocks.SequenceEqual(input.Blocks)
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
                
                if (this.Blocks != null)
                {
                    hashCode = (hashCode * 59) + this.Blocks.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
