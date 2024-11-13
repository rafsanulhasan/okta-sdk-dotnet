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
    /// Container details for resource type APP_ACCOUNT
    /// </summary>
    [DataContract(Name = "AppAccountContainerDetails")]
    
    public partial class AppAccountContainerDetails : IEquatable<AppAccountContainerDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppAccountContainerDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public AppAccountContainerDetails() { }
        
        /// <summary>
        /// The application name
        /// </summary>
        /// <value>The application name</value>
        [DataMember(Name = "appName", EmitDefaultValue = true)]
        public string AppName { get; private set; }

        /// <summary>
        /// Returns false as AppName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAppName()
        {
            return false;
        }
        /// <summary>
        /// The application ID associated with the privileged account
        /// </summary>
        /// <value>The application ID associated with the privileged account</value>
        [DataMember(Name = "containerId", EmitDefaultValue = true)]
        public string ContainerId { get; set; }

        /// <summary>
        /// Human-readable name of the container that owns the privileged resource
        /// </summary>
        /// <value>Human-readable name of the container that owns the privileged resource</value>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Returns false as DisplayName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDisplayName()
        {
            return false;
        }
        /// <summary>
        /// The application global ID
        /// </summary>
        /// <value>The application global ID</value>
        [DataMember(Name = "globalAppId", EmitDefaultValue = true)]
        public string GlobalAppId { get; private set; }

        /// <summary>
        /// Returns false as GlobalAppId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGlobalAppId()
        {
            return false;
        }
        /// <summary>
        /// Indicates if the application supports password push
        /// </summary>
        /// <value>Indicates if the application supports password push</value>
        [DataMember(Name = "passwordPushSupported", EmitDefaultValue = true)]
        public bool PasswordPushSupported { get; private set; }

        /// <summary>
        /// Returns false as PasswordPushSupported should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePasswordPushSupported()
        {
            return false;
        }
        /// <summary>
        /// Indicates if provisioning is enabled for this application
        /// </summary>
        /// <value>Indicates if provisioning is enabled for this application</value>
        [DataMember(Name = "provisioningEnabled", EmitDefaultValue = true)]
        public bool ProvisioningEnabled { get; private set; }

        /// <summary>
        /// Returns false as ProvisioningEnabled should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProvisioningEnabled()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = true)]
        public AppLink Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppAccountContainerDetails {\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  ContainerId: ").Append(ContainerId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  GlobalAppId: ").Append(GlobalAppId).Append("\n");
            sb.Append("  PasswordPushSupported: ").Append(PasswordPushSupported).Append("\n");
            sb.Append("  ProvisioningEnabled: ").Append(ProvisioningEnabled).Append("\n");
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
            return this.Equals(input as AppAccountContainerDetails);
        }

        /// <summary>
        /// Returns true if AppAccountContainerDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AppAccountContainerDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppAccountContainerDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.ContainerId == input.ContainerId ||
                    (this.ContainerId != null &&
                    this.ContainerId.Equals(input.ContainerId))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.GlobalAppId == input.GlobalAppId ||
                    (this.GlobalAppId != null &&
                    this.GlobalAppId.Equals(input.GlobalAppId))
                ) && 
                (
                    this.PasswordPushSupported == input.PasswordPushSupported ||
                    this.PasswordPushSupported.Equals(input.PasswordPushSupported)
                ) && 
                (
                    this.ProvisioningEnabled == input.ProvisioningEnabled ||
                    this.ProvisioningEnabled.Equals(input.ProvisioningEnabled)
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
                
                if (this.AppName != null)
                {
                    hashCode = (hashCode * 59) + this.AppName.GetHashCode();
                }
                if (this.ContainerId != null)
                {
                    hashCode = (hashCode * 59) + this.ContainerId.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.GlobalAppId != null)
                {
                    hashCode = (hashCode * 59) + this.GlobalAppId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PasswordPushSupported.GetHashCode();
                hashCode = (hashCode * 59) + this.ProvisioningEnabled.GetHashCode();
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}