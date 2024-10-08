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
    /// A human-readable string that identifies the Authenticator
    /// </summary>
    /// <value>A human-readable string that identifies the Authenticator</value>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class AuthenticatorKeyEnum : StringEnum
    {
        /// <summary>
        /// StringEnum AuthenticatorKeyEnum for value: custom_app
        /// </summary>
        public static AuthenticatorKeyEnum CustomApp = new AuthenticatorKeyEnum("custom_app");
        /// <summary>
        /// StringEnum AuthenticatorKeyEnum for value: duo
        /// </summary>
        public static AuthenticatorKeyEnum Duo = new AuthenticatorKeyEnum("duo");
        /// <summary>
        /// StringEnum AuthenticatorKeyEnum for value: external_idp
        /// </summary>
        public static AuthenticatorKeyEnum ExternalIdp = new AuthenticatorKeyEnum("external_idp");
        /// <summary>
        /// StringEnum AuthenticatorKeyEnum for value: google_otp
        /// </summary>
        public static AuthenticatorKeyEnum GoogleOtp = new AuthenticatorKeyEnum("google_otp");
        /// <summary>
        /// StringEnum AuthenticatorKeyEnum for value: okta_email
        /// </summary>
        public static AuthenticatorKeyEnum OktaEmail = new AuthenticatorKeyEnum("okta_email");
        /// <summary>
        /// StringEnum AuthenticatorKeyEnum for value: okta_password
        /// </summary>
        public static AuthenticatorKeyEnum OktaPassword = new AuthenticatorKeyEnum("okta_password");
        /// <summary>
        /// StringEnum AuthenticatorKeyEnum for value: okta_verify
        /// </summary>
        public static AuthenticatorKeyEnum OktaVerify = new AuthenticatorKeyEnum("okta_verify");
        /// <summary>
        /// StringEnum AuthenticatorKeyEnum for value: onprem_mfa
        /// </summary>
        public static AuthenticatorKeyEnum OnpremMfa = new AuthenticatorKeyEnum("onprem_mfa");
        /// <summary>
        /// StringEnum AuthenticatorKeyEnum for value: phone_number
        /// </summary>
        public static AuthenticatorKeyEnum PhoneNumber = new AuthenticatorKeyEnum("phone_number");
        /// <summary>
        /// StringEnum AuthenticatorKeyEnum for value: security_key
        /// </summary>
        public static AuthenticatorKeyEnum SecurityKey = new AuthenticatorKeyEnum("security_key");
        /// <summary>
        /// StringEnum AuthenticatorKeyEnum for value: security_question
        /// </summary>
        public static AuthenticatorKeyEnum SecurityQuestion = new AuthenticatorKeyEnum("security_question");
        /// <summary>
        /// StringEnum AuthenticatorKeyEnum for value: smart_card_idp
        /// </summary>
        public static AuthenticatorKeyEnum SmartCardIdp = new AuthenticatorKeyEnum("smart_card_idp");
        /// <summary>
        /// StringEnum AuthenticatorKeyEnum for value: symantec_vip
        /// </summary>
        public static AuthenticatorKeyEnum SymantecVip = new AuthenticatorKeyEnum("symantec_vip");
        /// <summary>
        /// StringEnum AuthenticatorKeyEnum for value: webauthn
        /// </summary>
        public static AuthenticatorKeyEnum Webauthn = new AuthenticatorKeyEnum("webauthn");
        /// <summary>
        /// StringEnum AuthenticatorKeyEnum for value: yubikey_token
        /// </summary>
        public static AuthenticatorKeyEnum YubikeyToken = new AuthenticatorKeyEnum("yubikey_token");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="AuthenticatorKeyEnum"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator AuthenticatorKeyEnum(string value) => new AuthenticatorKeyEnum(value);

        /// <summary>
        /// Creates a new <see cref="AuthenticatorKeyEnum"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public AuthenticatorKeyEnum(string value)
            : base(value)
        {
        }
    }


}
