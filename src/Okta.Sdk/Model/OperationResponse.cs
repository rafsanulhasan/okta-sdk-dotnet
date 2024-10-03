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
    /// Template: ModelGeneric
    /// OperationResponse
    /// </summary>
    [DataContract(Name = "OperationResponse")]
    
    public partial class OperationResponse : IEquatable<OperationResponse>
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumSerializingConverter))]
        public sealed class StatusEnum : StringEnum
        {
            /// <summary>
            /// StringEnum COMPLETED for value: COMPLETED
            /// </summary>
            
            public static StatusEnum COMPLETED = new StatusEnum("COMPLETED");

            /// <summary>
            /// StringEnum SCHEDULED for value: SCHEDULED
            /// </summary>
            
            public static StatusEnum SCHEDULED = new StatusEnum("SCHEDULED");

            /// <summary>
            /// StringEnum INPROGRESS for value: IN_PROGRESS
            /// </summary>
            
            public static StatusEnum INPROGRESS = new StatusEnum("IN_PROGRESS");

            /// <summary>
            /// StringEnum FAILED for value: FAILED
            /// </summary>
            
            public static StatusEnum FAILED = new StatusEnum("FAILED");


            /// <summary>
            /// Implicit operator declaration to accept and convert a string value as a <see cref="StatusEnum"/>
            /// </summary>
            /// <param name="value">The value to use</param>
            public static implicit operator StatusEnum(string value) => new StatusEnum(value);

            /// <summary>
            /// Creates a new <see cref="Status"/> instance.
            /// </summary>
            /// <param name="value">The value to use.</param>
            public StatusEnum(string value)
                : base(value)
            {
            }
        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        
        public StatusEnum Status { get; set; }

        /// <summary>
        /// Returns false as Status should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatus()
        {
            return false;
        }
        
        /// <summary>
        /// Gets or Sets AssignmentOperation
        /// </summary>
        [DataMember(Name = "assignmentOperation", EmitDefaultValue = true)]
        public OperationResponseAssignmentOperation AssignmentOperation { get; set; }

        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name = "completed", EmitDefaultValue = true)]
        public DateTimeOffset Completed { get; private set; }

        /// <summary>
        /// Returns false as Completed should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCompleted()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = true)]
        public DateTimeOffset Created { get; private set; }

        /// <summary>
        /// Returns false as Created should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreated()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets NumUserMoved
        /// </summary>
        [DataMember(Name = "numUserMoved", EmitDefaultValue = true)]
        public decimal NumUserMoved { get; private set; }

        /// <summary>
        /// Returns false as NumUserMoved should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNumUserMoved()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets RealmId
        /// </summary>
        [DataMember(Name = "realmId", EmitDefaultValue = true)]
        public string RealmId { get; private set; }

        /// <summary>
        /// Returns false as RealmId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRealmId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets RealmName
        /// </summary>
        [DataMember(Name = "realmName", EmitDefaultValue = true)]
        public string RealmName { get; private set; }

        /// <summary>
        /// Returns false as RealmName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRealmName()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Started
        /// </summary>
        [DataMember(Name = "started", EmitDefaultValue = true)]
        public DateTimeOffset Started { get; private set; }

        /// <summary>
        /// Returns false as Started should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStarted()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; private set; }

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = true)]
        public LinksSelf Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OperationResponse {\n");
            sb.Append("  AssignmentOperation: ").Append(AssignmentOperation).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NumUserMoved: ").Append(NumUserMoved).Append("\n");
            sb.Append("  RealmId: ").Append(RealmId).Append("\n");
            sb.Append("  RealmName: ").Append(RealmName).Append("\n");
            sb.Append("  Started: ").Append(Started).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperationResponse);
        }

        /// <summary>
        /// Returns true if OperationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OperationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AssignmentOperation == input.AssignmentOperation ||
                    (this.AssignmentOperation != null &&
                    this.AssignmentOperation.Equals(input.AssignmentOperation))
                ) && 
                (
                    this.Completed == input.Completed ||
                    (this.Completed != null &&
                    this.Completed.Equals(input.Completed))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.NumUserMoved == input.NumUserMoved ||
                    this.NumUserMoved.Equals(input.NumUserMoved)
                ) && 
                (
                    this.RealmId == input.RealmId ||
                    (this.RealmId != null &&
                    this.RealmId.Equals(input.RealmId))
                ) && 
                (
                    this.RealmName == input.RealmName ||
                    (this.RealmName != null &&
                    this.RealmName.Equals(input.RealmName))
                ) && 
                (
                    this.Started == input.Started ||
                    (this.Started != null &&
                    this.Started.Equals(input.Started))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                );
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
                
                if (this.AssignmentOperation != null)
                {
                    hashCode = (hashCode * 59) + this.AssignmentOperation.GetHashCode();
                }
                if (this.Completed != null)
                {
                    hashCode = (hashCode * 59) + this.Completed.GetHashCode();
                }
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NumUserMoved.GetHashCode();
                if (this.RealmId != null)
                {
                    hashCode = (hashCode * 59) + this.RealmId.GetHashCode();
                }
                if (this.RealmName != null)
                {
                    hashCode = (hashCode * 59) + this.RealmName.GetHashCode();
                }
                if (this.Started != null)
                {
                    hashCode = (hashCode * 59) + this.Started.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
