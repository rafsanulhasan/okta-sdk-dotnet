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
    /// Attributes used for processing AD Group membership update
    /// </summary>
    [DataContract(Name = "Parameters")]
    
    public partial class Parameters : IEquatable<Parameters>
    {
        /// <summary>
        /// The update action to take
        /// </summary>
        /// <value>The update action to take</value>
        [JsonConverter(typeof(StringEnumSerializingConverter))]
        public sealed class ActionEnum : StringEnum
        {
            /// <summary>
            /// StringEnum ADD for value: ADD
            /// </summary>
            
            public static ActionEnum ADD = new ActionEnum("ADD");

            /// <summary>
            /// StringEnum REMOVE for value: REMOVE
            /// </summary>
            
            public static ActionEnum REMOVE = new ActionEnum("REMOVE");


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
        /// The update action to take
        /// </summary>
        /// <value>The update action to take</value>
        [DataMember(Name = "action", EmitDefaultValue = true)]
        
        public ActionEnum Action { get; set; }
        
        /// <summary>
        /// The attribute that tracks group memberships in AD. This should be &#x60;member&#x60; for AD.
        /// </summary>
        /// <value>The attribute that tracks group memberships in AD. This should be &#x60;member&#x60; for AD.</value>
        [DataMember(Name = "attribute", EmitDefaultValue = true)]
        public string Attribute { get; set; }

        /// <summary>
        /// List of user IDs whose group memberships to update
        /// </summary>
        /// <value>List of user IDs whose group memberships to update</value>
        [DataMember(Name = "values", EmitDefaultValue = true)]
        public List<string> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Parameters {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Attribute: ").Append(Attribute).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as Parameters);
        }

        /// <summary>
        /// Returns true if Parameters instances are equal
        /// </summary>
        /// <param name="input">Instance of Parameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Parameters input)
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
                    this.Attribute == input.Attribute ||
                    (this.Attribute != null &&
                    this.Attribute.Equals(input.Attribute))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                if (this.Attribute != null)
                {
                    hashCode = (hashCode * 59) + this.Attribute.GetHashCode();
                }
                if (this.Values != null)
                {
                    hashCode = (hashCode * 59) + this.Values.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
