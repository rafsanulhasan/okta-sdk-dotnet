/*
 * Okta Admin Management
 *
 * Allows customers to easily access the Okta Management APIs
 *
 * The version of the OpenAPI document: 5.1.0
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
    /// Edition of the Splunk Cloud instance
    /// </summary>
    /// <value>Edition of the Splunk Cloud instance</value>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class SplunkEdition : StringEnum
    {
        /// <summary>
        /// StringEnum SplunkEdition for value: aws
        /// </summary>
        public static SplunkEdition Aws = new SplunkEdition("aws");
        /// <summary>
        /// StringEnum SplunkEdition for value: aws_govcloud
        /// </summary>
        public static SplunkEdition AwsGovcloud = new SplunkEdition("aws_govcloud");
        /// <summary>
        /// StringEnum SplunkEdition for value: gcp
        /// </summary>
        public static SplunkEdition Gcp = new SplunkEdition("gcp");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="SplunkEdition"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator SplunkEdition(string value) => new SplunkEdition(value);

        /// <summary>
        /// Creates a new <see cref="SplunkEdition"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public SplunkEdition(string value)
            : base(value)
        {
        }
    }


}