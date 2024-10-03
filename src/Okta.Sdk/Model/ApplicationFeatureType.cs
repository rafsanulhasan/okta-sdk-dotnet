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
    /// Identifying name of the feature  | Value | Description   | | - -- -- -- -- | - -- -- -- -- -- -- | | USER_PROVISIONING  | Represents the **To App** provisioning feature setting in the Admin Console | | INBOUND_PROVISIONING | Represents the **To Okta** provisioning feature setting in the Admin Console | 
    /// </summary>
    /// <value>Identifying name of the feature  | Value | Description   | | - -- -- -- -- | - -- -- -- -- -- -- | | USER_PROVISIONING  | Represents the **To App** provisioning feature setting in the Admin Console | | INBOUND_PROVISIONING | Represents the **To Okta** provisioning feature setting in the Admin Console | </value>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class ApplicationFeatureType : StringEnum
    {
        /// <summary>
        /// StringEnum ApplicationFeatureType for value: USER_PROVISIONING
        /// </summary>
        public static ApplicationFeatureType USERPROVISIONING = new ApplicationFeatureType("USER_PROVISIONING");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="ApplicationFeatureType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator ApplicationFeatureType(string value) => new ApplicationFeatureType(value);

        /// <summary>
        /// Creates a new <see cref="ApplicationFeatureType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public ApplicationFeatureType(string value)
            : base(value)
        {
        }
    }


}
