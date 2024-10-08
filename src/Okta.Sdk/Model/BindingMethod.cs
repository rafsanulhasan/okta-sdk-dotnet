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
    /// The method used to bind the out-of-band channel with the primary channel.
    /// </summary>
    /// <value>The method used to bind the out-of-band channel with the primary channel.</value>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class BindingMethod : StringEnum
    {
        /// <summary>
        /// StringEnum BindingMethod for value: none
        /// </summary>
        public static BindingMethod None = new BindingMethod("none");
        /// <summary>
        /// StringEnum BindingMethod for value: prompt
        /// </summary>
        public static BindingMethod Prompt = new BindingMethod("prompt");
        /// <summary>
        /// StringEnum BindingMethod for value: transfer
        /// </summary>
        public static BindingMethod Transfer = new BindingMethod("transfer");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="BindingMethod"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator BindingMethod(string value) => new BindingMethod(value);

        /// <summary>
        /// Creates a new <see cref="BindingMethod"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public BindingMethod(string value)
            : base(value)
        {
        }
    }


}
