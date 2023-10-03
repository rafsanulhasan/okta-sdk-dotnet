/*
 * Okta Admin Management
 *
 * Allows customers to easily access the Okta Management APIs
 *
 * The version of the OpenAPI document: 5.1.0
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
    /// Specifies the configuration for the &#x60;splunk_cloud_logstreaming&#x60; Log Stream type.
    /// </summary>
    [DataContract(Name = "LogStreamSettingsSplunkPut")]
    
    public partial class LogStreamSettingsSplunkPut : IEquatable<LogStreamSettingsSplunkPut>
    {

        /// <summary>
        /// Gets or Sets Edition
        /// </summary>
        [DataMember(Name = "edition", EmitDefaultValue = true)]
        
        public SplunkEdition Edition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LogStreamSettingsSplunkPut" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public LogStreamSettingsSplunkPut() { }
        
        /// <summary>
        /// The domain name for your Splunk Cloud instance. Don&#39;t include &#x60;http&#x60; or &#x60;https&#x60; in the string. For example: &#x60;acme.splunkcloud.com&#x60;
        /// </summary>
        /// <value>The domain name for your Splunk Cloud instance. Don&#39;t include &#x60;http&#x60; or &#x60;https&#x60; in the string. For example: &#x60;acme.splunkcloud.com&#x60;</value>
        [DataMember(Name = "host", EmitDefaultValue = true)]
        public string Host { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogStreamSettingsSplunkPut {\n");
            sb.Append("  Edition: ").Append(Edition).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
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
            return this.Equals(input as LogStreamSettingsSplunkPut);
        }

        /// <summary>
        /// Returns true if LogStreamSettingsSplunkPut instances are equal
        /// </summary>
        /// <param name="input">Instance of LogStreamSettingsSplunkPut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogStreamSettingsSplunkPut input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Edition == input.Edition ||
                    this.Edition.Equals(input.Edition)
                ) && 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
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
                
                if (this.Edition != null)
                {
                    hashCode = (hashCode * 59) + this.Edition.GetHashCode();
                }
                if (this.Host != null)
                {
                    hashCode = (hashCode * 59) + this.Host.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}