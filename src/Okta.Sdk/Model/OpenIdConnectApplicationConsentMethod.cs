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
    /// Defines OpenIdConnectApplicationConsentMethod
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class OpenIdConnectApplicationConsentMethod : StringEnum
    {
        /// <summary>
        /// StringEnum OpenIdConnectApplicationConsentMethod for value: REQUIRED
        /// </summary>
        public static OpenIdConnectApplicationConsentMethod REQUIRED = new OpenIdConnectApplicationConsentMethod("REQUIRED");
        /// <summary>
        /// StringEnum OpenIdConnectApplicationConsentMethod for value: TRUSTED
        /// </summary>
        public static OpenIdConnectApplicationConsentMethod TRUSTED = new OpenIdConnectApplicationConsentMethod("TRUSTED");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="OpenIdConnectApplicationConsentMethod"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator OpenIdConnectApplicationConsentMethod(string value) => new OpenIdConnectApplicationConsentMethod(value);

        /// <summary>
        /// Creates a new <see cref="OpenIdConnectApplicationConsentMethod"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public OpenIdConnectApplicationConsentMethod(string value)
            : base(value)
        {
        }
    }


}
