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
    /// LinksResend
    /// </summary>
    [DataContract(Name = "LinksResend")]
    
    public partial class LinksResend : IEquatable<LinksResend>
    {
        
        /// <summary>
        /// Gets or Sets Resend
        /// </summary>
        [DataMember(Name = "resend", EmitDefaultValue = true)]
        public LinksResendResend Resend { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LinksResend {\n");
            sb.Append("  Resend: ").Append(Resend).Append("\n");
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
            return this.Equals(input as LinksResend);
        }

        /// <summary>
        /// Returns true if LinksResend instances are equal
        /// </summary>
        /// <param name="input">Instance of LinksResend to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinksResend input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Resend == input.Resend ||
                    (this.Resend != null &&
                    this.Resend.Equals(input.Resend))
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
                
                if (this.Resend != null)
                {
                    hashCode = (hashCode * 59) + this.Resend.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
