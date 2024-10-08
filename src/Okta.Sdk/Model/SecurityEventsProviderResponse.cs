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
    /// The Security Events Provider response
    /// </summary>
    [DataContract(Name = "SecurityEventsProviderResponse")]
    
    public partial class SecurityEventsProviderResponse : IEquatable<SecurityEventsProviderResponse>
    {
        /// <summary>
        /// Indicates whether the Security Events Provider is active or not
        /// </summary>
        /// <value>Indicates whether the Security Events Provider is active or not</value>
        [JsonConverter(typeof(StringEnumSerializingConverter))]
        public sealed class StatusEnum : StringEnum
        {
            /// <summary>
            /// StringEnum ACTIVE for value: ACTIVE
            /// </summary>
            
            public static StatusEnum ACTIVE = new StatusEnum("ACTIVE");

            /// <summary>
            /// StringEnum INACTIVE for value: INACTIVE
            /// </summary>
            
            public static StatusEnum INACTIVE = new StatusEnum("INACTIVE");


            /// <summary>
            /// Implicit operator declaration to accept and convert a string value as a <see cref="StatusEnum"/>
            /// </summary>
            /// <param name="value">The value to use</param>
            public static implicit operator StatusEnum(string value) => new StatusEnum(value);

            /// <summary>
            /// Creates a new <see cref="Status"/> instance.
            /// </summary>
            /// <param name="value">The value to use.</param>
            public StatusEnum(string value)
                : base(value)
            {
            }
        }


        /// <summary>
        /// Indicates whether the Security Events Provider is active or not
        /// </summary>
        /// <value>Indicates whether the Security Events Provider is active or not</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        
        public StatusEnum Status { get; set; }

        /// <summary>
        /// Returns false as Status should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatus()
        {
            return false;
        }
        
        /// <summary>
        /// The unique identifier of this instance
        /// </summary>
        /// <value>The unique identifier of this instance</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// The name of the Security Events Provider instance
        /// </summary>
        /// <value>The name of the Security Events Provider instance</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name = "settings", EmitDefaultValue = true)]
        public SecurityEventsProviderSettingsResponse Settings { get; set; }

        /// <summary>
        /// The application type of the Security Events Provider
        /// </summary>
        /// <value>The application type of the Security Events Provider</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = true)]
        public LinksSelfAndLifecycle Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SecurityEventsProviderResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as SecurityEventsProviderResponse);
        }

        /// <summary>
        /// Returns true if SecurityEventsProviderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityEventsProviderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityEventsProviderResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
