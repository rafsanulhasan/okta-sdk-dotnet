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
    /// LogStreamDeactivateLink
    /// </summary>
    [DataContract(Name = "LogStreamDeactivateLink")]
    
    public partial class LogStreamDeactivateLink : IEquatable<LogStreamDeactivateLink>
    {
        /// <summary>
        /// HTTP method allowed for the resource
        /// </summary>
        /// <value>HTTP method allowed for the resource</value>
        [JsonConverter(typeof(StringEnumSerializingConverter))]
        public sealed class MethodEnum : StringEnum
        {
            /// <summary>
            /// StringEnum GET for value: GET
            /// </summary>
            
            public static MethodEnum GET = new MethodEnum("GET");

            /// <summary>
            /// StringEnum POST for value: POST
            /// </summary>
            
            public static MethodEnum POST = new MethodEnum("POST");


            /// <summary>
            /// Implicit operator declaration to accept and convert a string value as a <see cref="MethodEnum"/>
            /// </summary>
            /// <param name="value">The value to use</param>
            public static implicit operator MethodEnum(string value) => new MethodEnum(value);

            /// <summary>
            /// Creates a new <see cref="Method"/> instance.
            /// </summary>
            /// <param name="value">The value to use.</param>
            public MethodEnum(string value)
                : base(value)
            {
            }
        }


        /// <summary>
        /// HTTP method allowed for the resource
        /// </summary>
        /// <value>HTTP method allowed for the resource</value>
        [DataMember(Name = "method", EmitDefaultValue = true)]
        
        public MethodEnum Method { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LogStreamDeactivateLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public LogStreamDeactivateLink() { }
        
        /// <summary>
        /// The URI of the resource
        /// </summary>
        /// <value>The URI of the resource</value>
        [DataMember(Name = "href", EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogStreamDeactivateLink {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
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
            return this.Equals(input as LogStreamDeactivateLink);
        }

        /// <summary>
        /// Returns true if LogStreamDeactivateLink instances are equal
        /// </summary>
        /// <param name="input">Instance of LogStreamDeactivateLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogStreamDeactivateLink input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Method == input.Method ||
                    this.Method.Equals(input.Method)
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
                
                if (this.Href != null)
                {
                    hashCode = (hashCode * 59) + this.Href.GetHashCode();
                }
                if (this.Method != null)
                {
                    hashCode = (hashCode * 59) + this.Method.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
