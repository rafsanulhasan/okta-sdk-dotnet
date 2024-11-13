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
    /// Fulfillment provider details
    /// </summary>
    [DataContract(Name = "FulfillmentData")]
    
    public partial class FulfillmentData : IEquatable<FulfillmentData>
    {
        
        /// <summary>
        /// ID for the set of custom configurations of the requested Factor
        /// </summary>
        /// <value>ID for the set of custom configurations of the requested Factor</value>
        [DataMember(Name = "customizationId", EmitDefaultValue = true)]
        public string CustomizationId { get; set; }

        /// <summary>
        /// ID for the specific inventory bucket of the requested Factor
        /// </summary>
        /// <value>ID for the specific inventory bucket of the requested Factor</value>
        [DataMember(Name = "inventoryProductId", EmitDefaultValue = true)]
        public string InventoryProductId { get; set; }

        /// <summary>
        /// ID for the make and model of the requested Factor
        /// </summary>
        /// <value>ID for the make and model of the requested Factor</value>
        [DataMember(Name = "productId", EmitDefaultValue = true)]
        public string ProductId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FulfillmentData {\n");
            sb.Append("  CustomizationId: ").Append(CustomizationId).Append("\n");
            sb.Append("  InventoryProductId: ").Append(InventoryProductId).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
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
            return this.Equals(input as FulfillmentData);
        }

        /// <summary>
        /// Returns true if FulfillmentData instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CustomizationId == input.CustomizationId ||
                    (this.CustomizationId != null &&
                    this.CustomizationId.Equals(input.CustomizationId))
                ) && 
                (
                    this.InventoryProductId == input.InventoryProductId ||
                    (this.InventoryProductId != null &&
                    this.InventoryProductId.Equals(input.InventoryProductId))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
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
                
                if (this.CustomizationId != null)
                {
                    hashCode = (hashCode * 59) + this.CustomizationId.GetHashCode();
                }
                if (this.InventoryProductId != null)
                {
                    hashCode = (hashCode * 59) + this.InventoryProductId.GetHashCode();
                }
                if (this.ProductId != null)
                {
                    hashCode = (hashCode * 59) + this.ProductId.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}