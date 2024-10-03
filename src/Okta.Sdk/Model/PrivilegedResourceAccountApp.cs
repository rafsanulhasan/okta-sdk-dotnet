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
    /// PrivilegedResourceAccountApp
    /// </summary>
    [DataContract(Name = "PrivilegedResourceAccountApp")]
    [JsonConverter(typeof(JsonSubtypes), "ResourceType")]
    [JsonSubtypes.KnownSubType(typeof(PrivilegedResourceAccountApp), "APP_ACCOUNT")]
    [JsonSubtypes.KnownSubType(typeof(PrivilegedResourceAccountOkta), "OKTA_USER_ACCOUNT")]
    
    public partial class PrivilegedResourceAccountApp : PrivilegedResource, IEquatable<PrivilegedResourceAccountApp>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivilegedResourceAccountApp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PrivilegedResourceAccountApp() { }
        
        /// <summary>
        /// Gets or Sets ContainerDetails
        /// </summary>
        [DataMember(Name = "containerDetails", EmitDefaultValue = true)]
        public AppAccountContainerDetails ContainerDetails { get; set; }

        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name = "credentials", EmitDefaultValue = true)]
        public PrivilegedResourceCredentials Credentials { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PrivilegedResourceAccountApp {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ContainerDetails: ").Append(ContainerDetails).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
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
            return this.Equals(input as PrivilegedResourceAccountApp);
        }

        /// <summary>
        /// Returns true if PrivilegedResourceAccountApp instances are equal
        /// </summary>
        /// <param name="input">Instance of PrivilegedResourceAccountApp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrivilegedResourceAccountApp input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.ContainerDetails == input.ContainerDetails ||
                    (this.ContainerDetails != null &&
                    this.ContainerDetails.Equals(input.ContainerDetails))
                ) && base.Equals(input) && 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
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
                
                if (this.ContainerDetails != null)
                {
                    hashCode = (hashCode * 59) + this.ContainerDetails.GetHashCode();
                }
                if (this.Credentials != null)
                {
                    hashCode = (hashCode * 59) + this.Credentials.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
