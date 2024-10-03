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
    /// BehaviorRuleVelocity
    /// </summary>
    [DataContract(Name = "BehaviorRuleVelocity")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(BehaviorRuleAnomalousDevice), "ANOMALOUS_DEVICE")]
    [JsonSubtypes.KnownSubType(typeof(BehaviorRuleAnomalousIP), "ANOMALOUS_IP")]
    [JsonSubtypes.KnownSubType(typeof(BehaviorRuleAnomalousLocation), "ANOMALOUS_LOCATION")]
    [JsonSubtypes.KnownSubType(typeof(BehaviorRuleVelocity), "VELOCITY")]
    
    public partial class BehaviorRuleVelocity : BehaviorRule, IEquatable<BehaviorRuleVelocity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BehaviorRuleVelocity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public BehaviorRuleVelocity() { }
        
        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name = "settings", EmitDefaultValue = true)]
        public BehaviorRuleSettingsVelocity Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BehaviorRuleVelocity {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as BehaviorRuleVelocity);
        }

        /// <summary>
        /// Returns true if BehaviorRuleVelocity instances are equal
        /// </summary>
        /// <param name="input">Instance of BehaviorRuleVelocity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BehaviorRuleVelocity input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
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
                int hashCode = base.GetHashCode();
                
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
