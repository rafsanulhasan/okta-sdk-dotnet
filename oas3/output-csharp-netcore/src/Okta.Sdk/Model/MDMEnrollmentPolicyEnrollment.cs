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
    /// Defines MDMEnrollmentPolicyEnrollment
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MDMEnrollmentPolicyEnrollment
    {
        /// <summary>
        /// Enum ANYORNONE for value: ANY_OR_NONE
        /// </summary>
        [EnumMember(Value = "ANY_OR_NONE")]
        ANYORNONE = 1,

        /// <summary>
        /// Enum OMM for value: OMM
        /// </summary>
        [EnumMember(Value = "OMM")]
        OMM = 2

    }

}