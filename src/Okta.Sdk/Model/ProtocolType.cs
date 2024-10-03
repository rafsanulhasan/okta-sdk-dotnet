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
    /// Defines ProtocolType
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class ProtocolType : StringEnum
    {
        /// <summary>
        /// StringEnum ProtocolType for value: MTLS
        /// </summary>
        public static ProtocolType MTLS = new ProtocolType("MTLS");
        /// <summary>
        /// StringEnum ProtocolType for value: OAUTH2
        /// </summary>
        public static ProtocolType OAUTH2 = new ProtocolType("OAUTH2");
        /// <summary>
        /// StringEnum ProtocolType for value: OIDC
        /// </summary>
        public static ProtocolType OIDC = new ProtocolType("OIDC");
        /// <summary>
        /// StringEnum ProtocolType for value: SAML2
        /// </summary>
        public static ProtocolType SAML2 = new ProtocolType("SAML2");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="ProtocolType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator ProtocolType(string value) => new ProtocolType(value);

        /// <summary>
        /// Creates a new <see cref="ProtocolType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public ProtocolType(string value)
            : base(value)
        {
        }
    }


}
