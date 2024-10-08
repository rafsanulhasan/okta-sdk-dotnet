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
using System.Reflection;

namespace Okta.Sdk.Model
{
    /// <summary>
    /// Template" ModelOneOf
    /// ListSubscriptionsRoleRoleRefParameter
    /// </summary>
    [JsonConverter(typeof(ListSubscriptionsRoleRoleRefParameterJsonConverter))]
    [DataContract(Name = "listSubscriptionsRole_roleRef_parameter")]
    public partial class ListSubscriptionsRoleRoleRefParameter : AbstractOpenAPISchema, IEquatable<ListSubscriptionsRoleRoleRefParameter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionsRoleRoleRefParameter" /> class
        /// with the <see cref="RoleType" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of RoleType.</param>
        public ListSubscriptionsRoleRoleRefParameter(RoleType actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionsRoleRoleRefParameter" /> class
        /// with the <see cref="string" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of string.</param>
        public ListSubscriptionsRoleRoleRefParameter(string actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(RoleType))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(string))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: RoleType, string");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `RoleType`. If the actual instance is not `RoleType`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of RoleType</returns>
        public RoleType GetRoleType()
        {
            return (RoleType)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `string`. If the actual instance is not `string`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of string</returns>
        public string GetString()
        {
            return (string)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubscriptionsRoleRoleRefParameter {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, ListSubscriptionsRoleRoleRefParameter.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ListSubscriptionsRoleRoleRefParameter
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ListSubscriptionsRoleRoleRefParameter</returns>
        public static ListSubscriptionsRoleRoleRefParameter FromJson(string jsonString)
        {
            ListSubscriptionsRoleRoleRefParameter newListSubscriptionsRoleRoleRefParameter = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newListSubscriptionsRoleRoleRefParameter;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(RoleType).GetProperty("AdditionalProperties") == null)
                {
                    newListSubscriptionsRoleRoleRefParameter = new ListSubscriptionsRoleRoleRefParameter(JsonConvert.DeserializeObject<RoleType>(jsonString, ListSubscriptionsRoleRoleRefParameter.SerializerSettings));
                }
                else
                {
                    newListSubscriptionsRoleRoleRefParameter = new ListSubscriptionsRoleRoleRefParameter(JsonConvert.DeserializeObject<RoleType>(jsonString, ListSubscriptionsRoleRoleRefParameter.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("RoleType");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into RoleType: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(string).GetProperty("AdditionalProperties") == null)
                {
                    newListSubscriptionsRoleRoleRefParameter = new ListSubscriptionsRoleRoleRefParameter(JsonConvert.DeserializeObject<string>(jsonString, ListSubscriptionsRoleRoleRefParameter.SerializerSettings));
                }
                else
                {
                    newListSubscriptionsRoleRoleRefParameter = new ListSubscriptionsRoleRoleRefParameter(JsonConvert.DeserializeObject<string>(jsonString, ListSubscriptionsRoleRoleRefParameter.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("string");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into string: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newListSubscriptionsRoleRoleRefParameter;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubscriptionsRoleRoleRefParameter);
        }

        /// <summary>
        /// Returns true if ListSubscriptionsRoleRoleRefParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of ListSubscriptionsRoleRoleRefParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListSubscriptionsRoleRoleRefParameter input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

    }

    /// <summary>
    /// Custom JSON converter for ListSubscriptionsRoleRoleRefParameter
    /// </summary>
    public class ListSubscriptionsRoleRoleRefParameterJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ListSubscriptionsRoleRoleRefParameter).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return ListSubscriptionsRoleRoleRefParameter.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
