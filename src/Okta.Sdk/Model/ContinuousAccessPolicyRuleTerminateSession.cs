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
    /// ContinuousAccessPolicyRuleTerminateSession
    /// </summary>
    [DataContract(Name = "ContinuousAccessPolicyRuleTerminateSession")]
    
    public partial class ContinuousAccessPolicyRuleTerminateSession : IEquatable<ContinuousAccessPolicyRuleTerminateSession>
    {
        /// <summary>
        /// The action to take when Continuous Access evaluation detects a failure.
        /// </summary>
        /// <value>The action to take when Continuous Access evaluation detects a failure.</value>
        [JsonConverter(typeof(StringEnumSerializingConverter))]
        public sealed class ActionEnum : StringEnum
        {
            /// <summary>
            /// StringEnum TERMINATESESSION for value: TERMINATE_SESSION
            /// </summary>
            
            public static ActionEnum TERMINATESESSION = new ActionEnum("TERMINATE_SESSION");


            /// <summary>
            /// Implicit operator declaration to accept and convert a string value as a <see cref="ActionEnum"/>
            /// </summary>
            /// <param name="value">The value to use</param>
            public static implicit operator ActionEnum(string value) => new ActionEnum(value);

            /// <summary>
            /// Creates a new <see cref="Action"/> instance.
            /// </summary>
            /// <param name="value">The value to use.</param>
            public ActionEnum(string value)
                : base(value)
            {
            }
        }


        /// <summary>
        /// The action to take when Continuous Access evaluation detects a failure.
        /// </summary>
        /// <value>The action to take when Continuous Access evaluation detects a failure.</value>
        [DataMember(Name = "action", EmitDefaultValue = true)]
        
        public ActionEnum Action { get; set; }
        
        /// <summary>
        /// Gets or Sets Slo
        /// </summary>
        [DataMember(Name = "slo", EmitDefaultValue = true)]
        public ContinuousAccessPolicyRuleTerminateSessionSlo Slo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContinuousAccessPolicyRuleTerminateSession {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Slo: ").Append(Slo).Append("\n");
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
            return this.Equals(input as ContinuousAccessPolicyRuleTerminateSession);
        }

        /// <summary>
        /// Returns true if ContinuousAccessPolicyRuleTerminateSession instances are equal
        /// </summary>
        /// <param name="input">Instance of ContinuousAccessPolicyRuleTerminateSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContinuousAccessPolicyRuleTerminateSession input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.Slo == input.Slo ||
                    (this.Slo != null &&
                    this.Slo.Equals(input.Slo))
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
                
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                if (this.Slo != null)
                {
                    hashCode = (hashCode * 59) + this.Slo.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
