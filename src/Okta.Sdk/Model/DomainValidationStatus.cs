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
    /// Status of the domain
    /// </summary>
    /// <value>Status of the domain</value>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class DomainValidationStatus : StringEnum
    {
        /// <summary>
        /// StringEnum DomainValidationStatus for value: COMPLETED
        /// </summary>
        public static DomainValidationStatus COMPLETED = new DomainValidationStatus("COMPLETED");
        /// <summary>
        /// StringEnum DomainValidationStatus for value: IN_PROGRESS
        /// </summary>
        public static DomainValidationStatus INPROGRESS = new DomainValidationStatus("IN_PROGRESS");
        /// <summary>
        /// StringEnum DomainValidationStatus for value: NOT_STARTED
        /// </summary>
        public static DomainValidationStatus NOTSTARTED = new DomainValidationStatus("NOT_STARTED");
        /// <summary>
        /// StringEnum DomainValidationStatus for value: VERIFIED
        /// </summary>
        public static DomainValidationStatus VERIFIED = new DomainValidationStatus("VERIFIED");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="DomainValidationStatus"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator DomainValidationStatus(string value) => new DomainValidationStatus(value);

        /// <summary>
        /// Creates a new <see cref="DomainValidationStatus"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public DomainValidationStatus(string value)
            : base(value)
        {
        }
    }


}
