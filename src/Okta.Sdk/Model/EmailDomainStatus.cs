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
    /// Defines EmailDomainStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class EmailDomainStatus : StringEnum
    {
        /// <summary>
        /// StringEnum EmailDomainStatus for value: DELETED
        /// </summary>
        public static EmailDomainStatus DELETED = new EmailDomainStatus("DELETED");
        /// <summary>
        /// StringEnum EmailDomainStatus for value: ERROR
        /// </summary>
        public static EmailDomainStatus ERROR = new EmailDomainStatus("ERROR");
        /// <summary>
        /// StringEnum EmailDomainStatus for value: NOT_STARTED
        /// </summary>
        public static EmailDomainStatus NOTSTARTED = new EmailDomainStatus("NOT_STARTED");
        /// <summary>
        /// StringEnum EmailDomainStatus for value: POLLING
        /// </summary>
        public static EmailDomainStatus POLLING = new EmailDomainStatus("POLLING");
        /// <summary>
        /// StringEnum EmailDomainStatus for value: VERIFIED
        /// </summary>
        public static EmailDomainStatus VERIFIED = new EmailDomainStatus("VERIFIED");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="EmailDomainStatus"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator EmailDomainStatus(string value) => new EmailDomainStatus(value);

        /// <summary>
        /// Creates a new <see cref="EmailDomainStatus"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public EmailDomainStatus(string value)
            : base(value)
        {
        }
    }


}
