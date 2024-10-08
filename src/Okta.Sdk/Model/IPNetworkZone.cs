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
    /// IPNetworkZone
    /// </summary>
    [DataContract(Name = "IPNetworkZone")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(IPNetworkZone), "IP")]
    
    public partial class IPNetworkZone : NetworkZone, IEquatable<IPNetworkZone>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IPNetworkZone" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public IPNetworkZone() { }
        
        /// <summary>
        /// The IP addresses (range or CIDR form) for an IP Network Zone. The maximum array length is 150 entries for admin-created IP zones, 1000 entries for IP blocklist zones, and 5000 entries for the default system IP Zone.
        /// </summary>
        /// <value>The IP addresses (range or CIDR form) for an IP Network Zone. The maximum array length is 150 entries for admin-created IP zones, 1000 entries for IP blocklist zones, and 5000 entries for the default system IP Zone.</value>
        [DataMember(Name = "gateways", EmitDefaultValue = true)]
        public List<NetworkZoneAddress> Gateways { get; set; }

        /// <summary>
        /// The IP addresses (range or CIDR form) that are allowed to forward a request from gateway addresses for an IP Network Zone. These proxies are automatically trusted by Threat Insights and used to identify the client IP of a request. The maximum array length is 150 entries for admin-created zones and 5000 entries for the default system IP Zone.
        /// </summary>
        /// <value>The IP addresses (range or CIDR form) that are allowed to forward a request from gateway addresses for an IP Network Zone. These proxies are automatically trusted by Threat Insights and used to identify the client IP of a request. The maximum array length is 150 entries for admin-created zones and 5000 entries for the default system IP Zone.</value>
        [DataMember(Name = "proxies", EmitDefaultValue = true)]
        public List<NetworkZoneAddress> Proxies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IPNetworkZone {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Gateways: ").Append(Gateways).Append("\n");
            sb.Append("  Proxies: ").Append(Proxies).Append("\n");
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
            return this.Equals(input as IPNetworkZone);
        }

        /// <summary>
        /// Returns true if IPNetworkZone instances are equal
        /// </summary>
        /// <param name="input">Instance of IPNetworkZone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IPNetworkZone input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Gateways == input.Gateways ||
                    this.Gateways != null &&
                    input.Gateways != null &&
                    this.Gateways.SequenceEqual(input.Gateways)
                ) && base.Equals(input) && 
                (
                    this.Proxies == input.Proxies ||
                    this.Proxies != null &&
                    input.Proxies != null &&
                    this.Proxies.SequenceEqual(input.Proxies)
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
                
                if (this.Gateways != null)
                {
                    hashCode = (hashCode * 59) + this.Gateways.GetHashCode();
                }
                if (this.Proxies != null)
                {
                    hashCode = (hashCode * 59) + this.Proxies.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
