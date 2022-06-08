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
    /// Defines SessionAuthenticationMethod
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SessionAuthenticationMethod
    {
        /// <summary>
        /// Enum Fpt for value: fpt
        /// </summary>
        [EnumMember(Value = "fpt")]
        Fpt = 1,

        /// <summary>
        /// Enum Geo for value: geo
        /// </summary>
        [EnumMember(Value = "geo")]
        Geo = 2,

        /// <summary>
        /// Enum Hwk for value: hwk
        /// </summary>
        [EnumMember(Value = "hwk")]
        Hwk = 3,

        /// <summary>
        /// Enum Kba for value: kba
        /// </summary>
        [EnumMember(Value = "kba")]
        Kba = 4,

        /// <summary>
        /// Enum Mfa for value: mfa
        /// </summary>
        [EnumMember(Value = "mfa")]
        Mfa = 5,

        /// <summary>
        /// Enum Otp for value: otp
        /// </summary>
        [EnumMember(Value = "otp")]
        Otp = 6,

        /// <summary>
        /// Enum Pwd for value: pwd
        /// </summary>
        [EnumMember(Value = "pwd")]
        Pwd = 7,

        /// <summary>
        /// Enum Sms for value: sms
        /// </summary>
        [EnumMember(Value = "sms")]
        Sms = 8,

        /// <summary>
        /// Enum Swk for value: swk
        /// </summary>
        [EnumMember(Value = "swk")]
        Swk = 9,

        /// <summary>
        /// Enum Tel for value: tel
        /// </summary>
        [EnumMember(Value = "tel")]
        Tel = 10

    }

}