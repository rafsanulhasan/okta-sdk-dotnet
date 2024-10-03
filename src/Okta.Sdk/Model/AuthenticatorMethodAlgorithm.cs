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
    /// Defines AuthenticatorMethodAlgorithm
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class AuthenticatorMethodAlgorithm : StringEnum
    {
        /// <summary>
        /// StringEnum AuthenticatorMethodAlgorithm for value: ES256
        /// </summary>
        public static AuthenticatorMethodAlgorithm ES256 = new AuthenticatorMethodAlgorithm("ES256");
        /// <summary>
        /// StringEnum AuthenticatorMethodAlgorithm for value: RS256
        /// </summary>
        public static AuthenticatorMethodAlgorithm RS256 = new AuthenticatorMethodAlgorithm("RS256");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="AuthenticatorMethodAlgorithm"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator AuthenticatorMethodAlgorithm(string value) => new AuthenticatorMethodAlgorithm(value);

        /// <summary>
        /// Creates a new <see cref="AuthenticatorMethodAlgorithm"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public AuthenticatorMethodAlgorithm(string value)
            : base(value)
        {
        }
    }


}
