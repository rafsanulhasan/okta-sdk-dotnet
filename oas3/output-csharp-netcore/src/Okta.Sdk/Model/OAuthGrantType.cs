/*
 * Okta API
 *
 * Allows customers to easily access the Okta API
 *
 * The version of the OpenAPI document: 3.0.0
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
    /// Defines OAuthGrantType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OAuthGrantType
    {
        /// <summary>
        /// Enum AuthorizationCode for value: authorization_code
        /// </summary>
        [EnumMember(Value = "authorization_code")]
        AuthorizationCode = 1,

        /// <summary>
        /// Enum ClientCredentials for value: client_credentials
        /// </summary>
        [EnumMember(Value = "client_credentials")]
        ClientCredentials = 2,

        /// <summary>
        /// Enum Implicit for value: implicit
        /// </summary>
        [EnumMember(Value = "implicit")]
        Implicit = 3,

        /// <summary>
        /// Enum InteractionCode for value: interaction_code
        /// </summary>
        [EnumMember(Value = "interaction_code")]
        InteractionCode = 4,

        /// <summary>
        /// Enum Password for value: password
        /// </summary>
        [EnumMember(Value = "password")]
        Password = 5,

        /// <summary>
        /// Enum RefreshToken for value: refresh_token
        /// </summary>
        [EnumMember(Value = "refresh_token")]
        RefreshToken = 6

    }

}