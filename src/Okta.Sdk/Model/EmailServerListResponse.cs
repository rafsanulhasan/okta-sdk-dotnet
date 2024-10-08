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
    /// EmailServerListResponse
    /// </summary>
    [DataContract(Name = "EmailServerListResponse")]
    
    public partial class EmailServerListResponse : IEquatable<EmailServerListResponse>
    {
        
        /// <summary>
        /// Gets or Sets EmailServers
        /// </summary>
        [DataMember(Name = "email-servers", EmitDefaultValue = true)]
        public List<EmailServerResponse> EmailServers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailServerListResponse {\n");
            sb.Append("  EmailServers: ").Append(EmailServers).Append("\n");
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
            return this.Equals(input as EmailServerListResponse);
        }

        /// <summary>
        /// Returns true if EmailServerListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailServerListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailServerListResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EmailServers == input.EmailServers ||
                    this.EmailServers != null &&
                    input.EmailServers != null &&
                    this.EmailServers.SequenceEqual(input.EmailServers)
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
                
                if (this.EmailServers != null)
                {
                    hashCode = (hashCode * 59) + this.EmailServers.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
