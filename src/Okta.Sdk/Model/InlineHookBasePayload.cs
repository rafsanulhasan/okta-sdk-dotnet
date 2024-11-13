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
    /// InlineHookBasePayload
    /// </summary>
    [DataContract(Name = "InlineHookBasePayload")]
    
    public partial class InlineHookBasePayload : IEquatable<InlineHookBasePayload>
    {
        
        /// <summary>
        /// The inline hook cloud version
        /// </summary>
        /// <value>The inline hook cloud version</value>
        [DataMember(Name = "cloudEventVersion", EmitDefaultValue = true)]
        public string CloudEventVersion { get; set; }

        /// <summary>
        /// The inline hook request header content
        /// </summary>
        /// <value>The inline hook request header content</value>
        [DataMember(Name = "contentType", EmitDefaultValue = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// The individual inline hook request ID
        /// </summary>
        /// <value>The individual inline hook request ID</value>
        [DataMember(Name = "eventId", EmitDefaultValue = true)]
        public string EventId { get; set; }

        /// <summary>
        /// The time the inline hook request was sent
        /// </summary>
        /// <value>The time the inline hook request was sent</value>
        [DataMember(Name = "eventTime", EmitDefaultValue = true)]
        public string EventTime { get; set; }

        /// <summary>
        /// The inline hook version
        /// </summary>
        /// <value>The inline hook version</value>
        [DataMember(Name = "eventTypeVersion", EmitDefaultValue = true)]
        public string EventTypeVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InlineHookBasePayload {\n");
            sb.Append("  CloudEventVersion: ").Append(CloudEventVersion).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  EventTypeVersion: ").Append(EventTypeVersion).Append("\n");
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
            return this.Equals(input as InlineHookBasePayload);
        }

        /// <summary>
        /// Returns true if InlineHookBasePayload instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineHookBasePayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineHookBasePayload input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CloudEventVersion == input.CloudEventVersion ||
                    (this.CloudEventVersion != null &&
                    this.CloudEventVersion.Equals(input.CloudEventVersion))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.EventTime == input.EventTime ||
                    (this.EventTime != null &&
                    this.EventTime.Equals(input.EventTime))
                ) && 
                (
                    this.EventTypeVersion == input.EventTypeVersion ||
                    (this.EventTypeVersion != null &&
                    this.EventTypeVersion.Equals(input.EventTypeVersion))
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
                
                if (this.CloudEventVersion != null)
                {
                    hashCode = (hashCode * 59) + this.CloudEventVersion.GetHashCode();
                }
                if (this.ContentType != null)
                {
                    hashCode = (hashCode * 59) + this.ContentType.GetHashCode();
                }
                if (this.EventId != null)
                {
                    hashCode = (hashCode * 59) + this.EventId.GetHashCode();
                }
                if (this.EventTime != null)
                {
                    hashCode = (hashCode * 59) + this.EventTime.GetHashCode();
                }
                if (this.EventTypeVersion != null)
                {
                    hashCode = (hashCode * 59) + this.EventTypeVersion.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}