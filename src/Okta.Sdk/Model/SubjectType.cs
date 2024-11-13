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
    /// Defines SubjectType
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class SubjectType : StringEnum
    {
        /// <summary>
        /// StringEnum SubjectType for value: pairwise
        /// </summary>
        public static SubjectType Pairwise = new SubjectType("pairwise");
        /// <summary>
        /// StringEnum SubjectType for value: public
        /// </summary>
        public static SubjectType Public = new SubjectType("public");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="SubjectType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator SubjectType(string value) => new SubjectType(value);

        /// <summary>
        /// Creates a new <see cref="SubjectType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public SubjectType(string value)
            : base(value)
        {
        }
    }


}