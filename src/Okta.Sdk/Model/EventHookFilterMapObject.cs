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
    /// EventHookFilterMapObject
    /// </summary>
    [DataContract(Name = "EventHookFilterMapObject")]
    
    public partial class EventHookFilterMapObject : IEquatable<EventHookFilterMapObject>
    {
        
        /// <summary>
        /// Gets or Sets Condition
        /// </summary>
        [DataMember(Name = "condition", EmitDefaultValue = true)]
        public EventHookFilterMapObjectCondition Condition { get; set; }

        /// <summary>
        /// The filtered event type
        /// </summary>
        /// <value>The filtered event type</value>
        [DataMember(Name = "event", EmitDefaultValue = true)]
        public string Event { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EventHookFilterMapObject {\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
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
            return this.Equals(input as EventHookFilterMapObject);
        }

        /// <summary>
        /// Returns true if EventHookFilterMapObject instances are equal
        /// </summary>
        /// <param name="input">Instance of EventHookFilterMapObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventHookFilterMapObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Condition == input.Condition ||
                    (this.Condition != null &&
                    this.Condition.Equals(input.Condition))
                ) && 
                (
                    this.Event == input.Event ||
                    (this.Event != null &&
                    this.Event.Equals(input.Event))
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
                
                if (this.Condition != null)
                {
                    hashCode = (hashCode * 59) + this.Condition.GetHashCode();
                }
                if (this.Event != null)
                {
                    hashCode = (hashCode * 59) + this.Event.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
