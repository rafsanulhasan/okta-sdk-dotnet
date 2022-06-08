/*
 * Okta API
 *
 * Allows customers to easily access the Okta API
 *
 * The version of the OpenAPI document: 3.0.0
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
    /// PreRegistrationInlineHook
    /// </summary>
    [DataContract(Name = "PreRegistrationInlineHook")]
    public partial class PreRegistrationInlineHook : IEquatable<PreRegistrationInlineHook>
    {
        
        /// <summary>
        /// Gets or Sets InlineHookId
        /// </summary>
        [DataMember(Name = "inlineHookId", EmitDefaultValue = false)]
        public string InlineHookId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PreRegistrationInlineHook {\n");
            sb.Append("  InlineHookId: ").Append(InlineHookId).Append("\n");
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
            return this.Equals(input as PreRegistrationInlineHook);
        }

        /// <summary>
        /// Returns true if PreRegistrationInlineHook instances are equal
        /// </summary>
        /// <param name="input">Instance of PreRegistrationInlineHook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreRegistrationInlineHook input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InlineHookId == input.InlineHookId ||
                    (this.InlineHookId != null &&
                    this.InlineHookId.Equals(input.InlineHookId))
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
                if (this.InlineHookId != null)
                {
                    hashCode = (hashCode * 59) + this.InlineHookId.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}