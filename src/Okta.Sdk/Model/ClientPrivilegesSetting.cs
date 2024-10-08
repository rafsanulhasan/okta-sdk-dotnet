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
    /// The org setting that assigns the super admin role by default to a public client app
    /// </summary>
    [DataContract(Name = "ClientPrivilegesSetting")]
    
    public partial class ClientPrivilegesSetting : IEquatable<ClientPrivilegesSetting>
    {
        
        /// <summary>
        /// Gets or Sets _ClientPrivilegesSetting
        /// </summary>
        [DataMember(Name = "clientPrivilegesSetting", EmitDefaultValue = true)]
        public bool _ClientPrivilegesSetting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientPrivilegesSetting {\n");
            sb.Append("  _ClientPrivilegesSetting: ").Append(_ClientPrivilegesSetting).Append("\n");
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
            return this.Equals(input as ClientPrivilegesSetting);
        }

        /// <summary>
        /// Returns true if ClientPrivilegesSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientPrivilegesSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientPrivilegesSetting input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._ClientPrivilegesSetting == input._ClientPrivilegesSetting ||
                    this._ClientPrivilegesSetting.Equals(input._ClientPrivilegesSetting)
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
                
                hashCode = (hashCode * 59) + this._ClientPrivilegesSetting.GetHashCode();
                return hashCode;
            }
        }

    }

}
