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
    /// ContinuousAccessFailureActionsObject
    /// </summary>
    [DataContract(Name = "ContinuousAccessFailureActionsObject")]
    [JsonConverter(typeof(JsonSubtypes), "Action")]
    [JsonSubtypes.KnownSubType(typeof(ContinuousAccessPolicyRuleRunWorkflow), "RUN_WORKFLOW")]
    [JsonSubtypes.KnownSubType(typeof(ContinuousAccessPolicyRuleTerminateSession), "TERMINATE_SESSION")]
    
    public partial class ContinuousAccessFailureActionsObject : IEquatable<ContinuousAccessFailureActionsObject>
    {
        /// <summary>
        /// Defines Action
        /// </summary>
        [JsonConverter(typeof(StringEnumSerializingConverter))]
        public sealed class ActionEnum : StringEnum
        {
            /// <summary>
            /// StringEnum RUNWORKFLOW for value: RUN_WORKFLOW
            /// </summary>
            
            public static ActionEnum RUNWORKFLOW = new ActionEnum("RUN_WORKFLOW");

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
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = true)]
        
        public ActionEnum Action { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContinuousAccessFailureActionsObject {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
            return this.Equals(input as ContinuousAccessFailureActionsObject);
        }

        /// <summary>
        /// Returns true if ContinuousAccessFailureActionsObject instances are equal
        /// </summary>
        /// <param name="input">Instance of ContinuousAccessFailureActionsObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContinuousAccessFailureActionsObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
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
                return hashCode;
            }
        }

    }

}
