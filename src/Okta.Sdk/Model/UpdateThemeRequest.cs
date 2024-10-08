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
    /// UpdateThemeRequest
    /// </summary>
    [DataContract(Name = "UpdateThemeRequest")]
    
    public partial class UpdateThemeRequest : IEquatable<UpdateThemeRequest>
    {

        /// <summary>
        /// Gets or Sets EmailTemplateTouchPointVariant
        /// </summary>
        [DataMember(Name = "emailTemplateTouchPointVariant", EmitDefaultValue = true)]
        
        public EmailTemplateTouchPointVariant EmailTemplateTouchPointVariant { get; set; }

        /// <summary>
        /// Gets or Sets EndUserDashboardTouchPointVariant
        /// </summary>
        [DataMember(Name = "endUserDashboardTouchPointVariant", EmitDefaultValue = true)]
        
        public EndUserDashboardTouchPointVariant EndUserDashboardTouchPointVariant { get; set; }

        /// <summary>
        /// Gets or Sets ErrorPageTouchPointVariant
        /// </summary>
        [DataMember(Name = "errorPageTouchPointVariant", EmitDefaultValue = true)]
        
        public ErrorPageTouchPointVariant ErrorPageTouchPointVariant { get; set; }

        /// <summary>
        /// Gets or Sets LoadingPageTouchPointVariant
        /// </summary>
        [DataMember(Name = "loadingPageTouchPointVariant", EmitDefaultValue = true)]
        
        public LoadingPageTouchPointVariant LoadingPageTouchPointVariant { get; set; }

        /// <summary>
        /// Gets or Sets SignInPageTouchPointVariant
        /// </summary>
        [DataMember(Name = "signInPageTouchPointVariant", EmitDefaultValue = true)]
        
        public SignInPageTouchPointVariant SignInPageTouchPointVariant { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateThemeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public UpdateThemeRequest() { }
        
        /// <summary>
        /// Primary color contrast hex code
        /// </summary>
        /// <value>Primary color contrast hex code</value>
        [DataMember(Name = "primaryColorContrastHex", EmitDefaultValue = true)]
        public string PrimaryColorContrastHex { get; set; }

        /// <summary>
        /// Primary color hex code
        /// </summary>
        /// <value>Primary color hex code</value>
        [DataMember(Name = "primaryColorHex", EmitDefaultValue = true)]
        public string PrimaryColorHex { get; set; }

        /// <summary>
        /// Secondary color contrast hex code
        /// </summary>
        /// <value>Secondary color contrast hex code</value>
        [DataMember(Name = "secondaryColorContrastHex", EmitDefaultValue = true)]
        public string SecondaryColorContrastHex { get; set; }

        /// <summary>
        /// Secondary color hex code
        /// </summary>
        /// <value>Secondary color hex code</value>
        [DataMember(Name = "secondaryColorHex", EmitDefaultValue = true)]
        public string SecondaryColorHex { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = true)]
        public LinksSelf Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateThemeRequest {\n");
            sb.Append("  EmailTemplateTouchPointVariant: ").Append(EmailTemplateTouchPointVariant).Append("\n");
            sb.Append("  EndUserDashboardTouchPointVariant: ").Append(EndUserDashboardTouchPointVariant).Append("\n");
            sb.Append("  ErrorPageTouchPointVariant: ").Append(ErrorPageTouchPointVariant).Append("\n");
            sb.Append("  LoadingPageTouchPointVariant: ").Append(LoadingPageTouchPointVariant).Append("\n");
            sb.Append("  PrimaryColorContrastHex: ").Append(PrimaryColorContrastHex).Append("\n");
            sb.Append("  PrimaryColorHex: ").Append(PrimaryColorHex).Append("\n");
            sb.Append("  SecondaryColorContrastHex: ").Append(SecondaryColorContrastHex).Append("\n");
            sb.Append("  SecondaryColorHex: ").Append(SecondaryColorHex).Append("\n");
            sb.Append("  SignInPageTouchPointVariant: ").Append(SignInPageTouchPointVariant).Append("\n");
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
            return this.Equals(input as UpdateThemeRequest);
        }

        /// <summary>
        /// Returns true if UpdateThemeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateThemeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateThemeRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EmailTemplateTouchPointVariant == input.EmailTemplateTouchPointVariant ||
                    this.EmailTemplateTouchPointVariant.Equals(input.EmailTemplateTouchPointVariant)
                ) && 
                (
                    this.EndUserDashboardTouchPointVariant == input.EndUserDashboardTouchPointVariant ||
                    this.EndUserDashboardTouchPointVariant.Equals(input.EndUserDashboardTouchPointVariant)
                ) && 
                (
                    this.ErrorPageTouchPointVariant == input.ErrorPageTouchPointVariant ||
                    this.ErrorPageTouchPointVariant.Equals(input.ErrorPageTouchPointVariant)
                ) && 
                (
                    this.LoadingPageTouchPointVariant == input.LoadingPageTouchPointVariant ||
                    this.LoadingPageTouchPointVariant.Equals(input.LoadingPageTouchPointVariant)
                ) && 
                (
                    this.PrimaryColorContrastHex == input.PrimaryColorContrastHex ||
                    (this.PrimaryColorContrastHex != null &&
                    this.PrimaryColorContrastHex.Equals(input.PrimaryColorContrastHex))
                ) && 
                (
                    this.PrimaryColorHex == input.PrimaryColorHex ||
                    (this.PrimaryColorHex != null &&
                    this.PrimaryColorHex.Equals(input.PrimaryColorHex))
                ) && 
                (
                    this.SecondaryColorContrastHex == input.SecondaryColorContrastHex ||
                    (this.SecondaryColorContrastHex != null &&
                    this.SecondaryColorContrastHex.Equals(input.SecondaryColorContrastHex))
                ) && 
                (
                    this.SecondaryColorHex == input.SecondaryColorHex ||
                    (this.SecondaryColorHex != null &&
                    this.SecondaryColorHex.Equals(input.SecondaryColorHex))
                ) && 
                (
                    this.SignInPageTouchPointVariant == input.SignInPageTouchPointVariant ||
                    this.SignInPageTouchPointVariant.Equals(input.SignInPageTouchPointVariant)
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
                
                if (this.EmailTemplateTouchPointVariant != null)
                {
                    hashCode = (hashCode * 59) + this.EmailTemplateTouchPointVariant.GetHashCode();
                }
                if (this.EndUserDashboardTouchPointVariant != null)
                {
                    hashCode = (hashCode * 59) + this.EndUserDashboardTouchPointVariant.GetHashCode();
                }
                if (this.ErrorPageTouchPointVariant != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorPageTouchPointVariant.GetHashCode();
                }
                if (this.LoadingPageTouchPointVariant != null)
                {
                    hashCode = (hashCode * 59) + this.LoadingPageTouchPointVariant.GetHashCode();
                }
                if (this.PrimaryColorContrastHex != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryColorContrastHex.GetHashCode();
                }
                if (this.PrimaryColorHex != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryColorHex.GetHashCode();
                }
                if (this.SecondaryColorContrastHex != null)
                {
                    hashCode = (hashCode * 59) + this.SecondaryColorContrastHex.GetHashCode();
                }
                if (this.SecondaryColorHex != null)
                {
                    hashCode = (hashCode * 59) + this.SecondaryColorHex.GetHashCode();
                }
                if (this.SignInPageTouchPointVariant != null)
                {
                    hashCode = (hashCode * 59) + this.SignInPageTouchPointVariant.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
