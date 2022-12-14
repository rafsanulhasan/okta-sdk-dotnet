/*
 * Okta Management
 *
 * Allows customers to easily access the Okta Management APIs
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
    /// The schedule of auto-update configured by admin.
    /// </summary>
    [DataContract(Name = "AutoUpdateSchedule")]
    
    public partial class AutoUpdateSchedule : IEquatable<AutoUpdateSchedule>
    {
        
        /// <summary>
        /// Gets or Sets Cron
        /// </summary>
        [DataMember(Name = "cron", EmitDefaultValue = false)]
        public string Cron { get; set; }

        /// <summary>
        /// delay in days
        /// </summary>
        /// <value>delay in days</value>
        [DataMember(Name = "delay", EmitDefaultValue = false)]
        public int Delay { get; set; }

        /// <summary>
        /// duration in minutes
        /// </summary>
        /// <value>duration in minutes</value>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        public int Duration { get; set; }

        /// <summary>
        /// last time when the updated finished (success or failed, exclude cancelled), null if job haven&#39;t finished once yet.
        /// </summary>
        /// <value>last time when the updated finished (success or failed, exclude cancelled), null if job haven&#39;t finished once yet.</value>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
        public DateTimeOffset LastUpdated { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name = "timezone", EmitDefaultValue = false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutoUpdateSchedule {\n");
            sb.Append("  Cron: ").Append(Cron).Append("\n");
            sb.Append("  Delay: ").Append(Delay).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
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
            return this.Equals(input as AutoUpdateSchedule);
        }

        /// <summary>
        /// Returns true if AutoUpdateSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoUpdateSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoUpdateSchedule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cron == input.Cron ||
                    (this.Cron != null &&
                    this.Cron.Equals(input.Cron))
                ) && 
                (
                    this.Delay == input.Delay ||
                    this.Delay.Equals(input.Delay)
                ) && 
                (
                    this.Duration == input.Duration ||
                    this.Duration.Equals(input.Duration)
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
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
                
                if (this.Cron != null)
                {
                    hashCode = (hashCode * 59) + this.Cron.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Delay.GetHashCode();
                hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                if (this.LastUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdated.GetHashCode();
                }
                if (this.Timezone != null)
                {
                    hashCode = (hashCode * 59) + this.Timezone.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}