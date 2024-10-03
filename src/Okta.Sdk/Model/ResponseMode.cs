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
    /// Defines ResponseMode
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class ResponseMode : StringEnum
    {
        /// <summary>
        /// StringEnum ResponseMode for value: form_post
        /// </summary>
        public static ResponseMode FormPost = new ResponseMode("form_post");
        /// <summary>
        /// StringEnum ResponseMode for value: fragment
        /// </summary>
        public static ResponseMode Fragment = new ResponseMode("fragment");
        /// <summary>
        /// StringEnum ResponseMode for value: okta_post_message
        /// </summary>
        public static ResponseMode OktaPostMessage = new ResponseMode("okta_post_message");
        /// <summary>
        /// StringEnum ResponseMode for value: query
        /// </summary>
        public static ResponseMode Query = new ResponseMode("query");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="ResponseMode"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator ResponseMode(string value) => new ResponseMode(value);

        /// <summary>
        /// Creates a new <see cref="ResponseMode"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public ResponseMode(string value)
            : base(value)
        {
        }
    }


}
