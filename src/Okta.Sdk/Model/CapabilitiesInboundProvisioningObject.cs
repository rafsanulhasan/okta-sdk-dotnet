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
    /// Defines the configuration for the INBOUND_PROVISIONING feature
    /// </summary>
    [DataContract(Name = "CapabilitiesInboundProvisioningObject")]
    
    public partial class CapabilitiesInboundProvisioningObject : IEquatable<CapabilitiesInboundProvisioningObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CapabilitiesInboundProvisioningObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public CapabilitiesInboundProvisioningObject() { }
        
        /// <summary>
        /// Gets or Sets ImportRules
        /// </summary>
        [DataMember(Name = "importRules", EmitDefaultValue = true)]
        public CapabilitiesImportRulesObject ImportRules { get; set; }

        /// <summary>
        /// Gets or Sets ImportSettings
        /// </summary>
        [DataMember(Name = "importSettings", EmitDefaultValue = true)]
        public CapabilitiesImportSettingsObject ImportSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CapabilitiesInboundProvisioningObject {\n");
            sb.Append("  ImportRules: ").Append(ImportRules).Append("\n");
            sb.Append("  ImportSettings: ").Append(ImportSettings).Append("\n");
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
            return this.Equals(input as CapabilitiesInboundProvisioningObject);
        }

        /// <summary>
        /// Returns true if CapabilitiesInboundProvisioningObject instances are equal
        /// </summary>
        /// <param name="input">Instance of CapabilitiesInboundProvisioningObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapabilitiesInboundProvisioningObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ImportRules == input.ImportRules ||
                    (this.ImportRules != null &&
                    this.ImportRules.Equals(input.ImportRules))
                ) && 
                (
                    this.ImportSettings == input.ImportSettings ||
                    (this.ImportSettings != null &&
                    this.ImportSettings.Equals(input.ImportSettings))
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
                
                if (this.ImportRules != null)
                {
                    hashCode = (hashCode * 59) + this.ImportRules.GetHashCode();
                }
                if (this.ImportSettings != null)
                {
                    hashCode = (hashCode * 59) + this.ImportSettings.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
