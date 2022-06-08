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
    /// Defines FactorProvider
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FactorProvider
    {
        /// <summary>
        /// Enum CUSTOM for value: CUSTOM
        /// </summary>
        [EnumMember(Value = "CUSTOM")]
        CUSTOM = 1,

        /// <summary>
        /// Enum DUO for value: DUO
        /// </summary>
        [EnumMember(Value = "DUO")]
        DUO = 2,

        /// <summary>
        /// Enum FIDO for value: FIDO
        /// </summary>
        [EnumMember(Value = "FIDO")]
        FIDO = 3,

        /// <summary>
        /// Enum GOOGLE for value: GOOGLE
        /// </summary>
        [EnumMember(Value = "GOOGLE")]
        GOOGLE = 4,

        /// <summary>
        /// Enum OKTA for value: OKTA
        /// </summary>
        [EnumMember(Value = "OKTA")]
        OKTA = 5,

        /// <summary>
        /// Enum RSA for value: RSA
        /// </summary>
        [EnumMember(Value = "RSA")]
        RSA = 6,

        /// <summary>
        /// Enum SYMANTEC for value: SYMANTEC
        /// </summary>
        [EnumMember(Value = "SYMANTEC")]
        SYMANTEC = 7,

        /// <summary>
        /// Enum YUBICO for value: YUBICO
        /// </summary>
        [EnumMember(Value = "YUBICO")]
        YUBICO = 8

    }

}