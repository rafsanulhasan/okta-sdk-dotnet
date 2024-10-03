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
    /// PageRootLinks
    /// </summary>
    [DataContract(Name = "PageRoot__links")]
    
    public partial class PageRootLinks : IEquatable<PageRootLinks>
    {
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name = "self", EmitDefaultValue = true)]
        public HrefObjectSelfLink Self { get; set; }

        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name = "default", EmitDefaultValue = true)]
        public HrefObject Default { get; set; }

        /// <summary>
        /// Gets or Sets Customized
        /// </summary>
        [DataMember(Name = "customized", EmitDefaultValue = true)]
        public HrefObject Customized { get; set; }

        /// <summary>
        /// Gets or Sets Preview
        /// </summary>
        [DataMember(Name = "preview", EmitDefaultValue = true)]
        public HrefObject Preview { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PageRootLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Customized: ").Append(Customized).Append("\n");
            sb.Append("  Preview: ").Append(Preview).Append("\n");
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
            return this.Equals(input as PageRootLinks);
        }

        /// <summary>
        /// Returns true if PageRootLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of PageRootLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageRootLinks input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && 
                (
                    this.Customized == input.Customized ||
                    (this.Customized != null &&
                    this.Customized.Equals(input.Customized))
                ) && 
                (
                    this.Preview == input.Preview ||
                    (this.Preview != null &&
                    this.Preview.Equals(input.Preview))
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
                
                if (this.Self != null)
                {
                    hashCode = (hashCode * 59) + this.Self.GetHashCode();
                }
                if (this.Default != null)
                {
                    hashCode = (hashCode * 59) + this.Default.GetHashCode();
                }
                if (this.Customized != null)
                {
                    hashCode = (hashCode * 59) + this.Customized.GetHashCode();
                }
                if (this.Preview != null)
                {
                    hashCode = (hashCode * 59) + this.Preview.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
