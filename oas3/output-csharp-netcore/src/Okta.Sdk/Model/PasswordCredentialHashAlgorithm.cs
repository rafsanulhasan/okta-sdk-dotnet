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
    /// Defines PasswordCredentialHashAlgorithm
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PasswordCredentialHashAlgorithm
    {
        /// <summary>
        /// Enum BCRYPT for value: BCRYPT
        /// </summary>
        [EnumMember(Value = "BCRYPT")]
        BCRYPT = 1,

        /// <summary>
        /// Enum MD5 for value: MD5
        /// </summary>
        [EnumMember(Value = "MD5")]
        MD5 = 2,

        /// <summary>
        /// Enum SHA1 for value: SHA-1
        /// </summary>
        [EnumMember(Value = "SHA-1")]
        SHA1 = 3,

        /// <summary>
        /// Enum SHA256 for value: SHA-256
        /// </summary>
        [EnumMember(Value = "SHA-256")]
        SHA256 = 4,

        /// <summary>
        /// Enum SHA512 for value: SHA-512
        /// </summary>
        [EnumMember(Value = "SHA-512")]
        SHA512 = 5

    }

}