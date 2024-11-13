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
    /// The type of public key
    /// </summary>
    /// <value>The type of public key</value>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class JsonWebKeyType : StringEnum
    {
        /// <summary>
        /// StringEnum JsonWebKeyType for value: EC
        /// </summary>
        public static JsonWebKeyType EC = new JsonWebKeyType("EC");
        /// <summary>
        /// StringEnum JsonWebKeyType for value: RSA
        /// </summary>
        public static JsonWebKeyType RSA = new JsonWebKeyType("RSA");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="JsonWebKeyType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator JsonWebKeyType(string value) => new JsonWebKeyType(value);

        /// <summary>
        /// Creates a new <see cref="JsonWebKeyType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public JsonWebKeyType(string value)
            : base(value)
        {
        }
    }


}