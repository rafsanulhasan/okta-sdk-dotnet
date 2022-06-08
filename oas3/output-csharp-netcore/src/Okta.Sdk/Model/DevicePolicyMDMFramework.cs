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
    /// Defines DevicePolicyMDMFramework
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DevicePolicyMDMFramework
    {
        /// <summary>
        /// Enum AFW for value: AFW
        /// </summary>
        [EnumMember(Value = "AFW")]
        AFW = 1,

        /// <summary>
        /// Enum NATIVE for value: NATIVE
        /// </summary>
        [EnumMember(Value = "NATIVE")]
        NATIVE = 2,

        /// <summary>
        /// Enum SAFE for value: SAFE
        /// </summary>
        [EnumMember(Value = "SAFE")]
        SAFE = 3

    }

}