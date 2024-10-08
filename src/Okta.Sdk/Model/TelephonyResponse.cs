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
    /// TelephonyResponse
    /// </summary>
    [DataContract(Name = "TelephonyResponse")]
    
    public partial class TelephonyResponse : IEquatable<TelephonyResponse>
    {
        
        /// <summary>
        /// The &#x60;commands&#x60; object specifies whether Okta accepts the end user&#39;s sign-in credentials as valid or not. For the Telephony inline hook, you typically only return one &#x60;commands&#x60; object with one array element in it.
        /// </summary>
        /// <value>The &#x60;commands&#x60; object specifies whether Okta accepts the end user&#39;s sign-in credentials as valid or not. For the Telephony inline hook, you typically only return one &#x60;commands&#x60; object with one array element in it.</value>
        [DataMember(Name = "commands", EmitDefaultValue = true)]
        public List<TelephonyResponseCommandsInner> Commands { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TelephonyResponse {\n");
            sb.Append("  Commands: ").Append(Commands).Append("\n");
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
            return this.Equals(input as TelephonyResponse);
        }

        /// <summary>
        /// Returns true if TelephonyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TelephonyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelephonyResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Commands == input.Commands ||
                    this.Commands != null &&
                    input.Commands != null &&
                    this.Commands.SequenceEqual(input.Commands)
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
                
                if (this.Commands != null)
                {
                    hashCode = (hashCode * 59) + this.Commands.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
