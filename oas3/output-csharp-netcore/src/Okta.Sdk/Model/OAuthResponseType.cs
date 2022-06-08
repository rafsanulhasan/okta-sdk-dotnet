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
    /// Defines OAuthResponseType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OAuthResponseType
    {
        /// <summary>
        /// Enum Code for value: code
        /// </summary>
        [EnumMember(Value = "code")]
        Code = 1,

        /// <summary>
        /// Enum IdToken for value: id_token
        /// </summary>
        [EnumMember(Value = "id_token")]
        IdToken = 2,

        /// <summary>
        /// Enum Token for value: token
        /// </summary>
        [EnumMember(Value = "token")]
        Token = 3

    }

}