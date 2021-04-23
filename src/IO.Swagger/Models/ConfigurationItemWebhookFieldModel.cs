/*
 * Datto|Autotask PSA Rest API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ConfigurationItemWebhookFieldModel : IEquatable<ConfigurationItemWebhookFieldModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets FieldID
        /// </summary>
        [DataMember(Name="fieldID")]
        public int? FieldID { get; set; }

        /// <summary>
        /// Gets or Sets IsDisplayAlwaysField
        /// </summary>
        [DataMember(Name="isDisplayAlwaysField")]
        public bool? IsDisplayAlwaysField { get; set; }

        /// <summary>
        /// Gets or Sets IsSubscribedField
        /// </summary>
        [DataMember(Name="isSubscribedField")]
        public bool? IsSubscribedField { get; set; }

        /// <summary>
        /// Gets or Sets WebhookID
        /// </summary>
        [DataMember(Name="webhookID")]
        public int? WebhookID { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId")]
        public ExpressionFuncInstalledProductWebhookFieldInt64 SoapParentPropertyId { get; private set; }

        /// <summary>
        /// Gets or Sets UserDefinedFields
        /// </summary>
        [DataMember(Name="userDefinedFields")]
        public List<UserDefinedField> UserDefinedFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationItemWebhookFieldModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FieldID: ").Append(FieldID).Append("\n");
            sb.Append("  IsDisplayAlwaysField: ").Append(IsDisplayAlwaysField).Append("\n");
            sb.Append("  IsSubscribedField: ").Append(IsSubscribedField).Append("\n");
            sb.Append("  WebhookID: ").Append(WebhookID).Append("\n");
            sb.Append("  SoapParentPropertyId: ").Append(SoapParentPropertyId).Append("\n");
            sb.Append("  UserDefinedFields: ").Append(UserDefinedFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ConfigurationItemWebhookFieldModel)obj);
        }

        /// <summary>
        /// Returns true if ConfigurationItemWebhookFieldModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfigurationItemWebhookFieldModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigurationItemWebhookFieldModel other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    FieldID == other.FieldID ||
                    FieldID != null &&
                    FieldID.Equals(other.FieldID)
                ) && 
                (
                    IsDisplayAlwaysField == other.IsDisplayAlwaysField ||
                    IsDisplayAlwaysField != null &&
                    IsDisplayAlwaysField.Equals(other.IsDisplayAlwaysField)
                ) && 
                (
                    IsSubscribedField == other.IsSubscribedField ||
                    IsSubscribedField != null &&
                    IsSubscribedField.Equals(other.IsSubscribedField)
                ) && 
                (
                    WebhookID == other.WebhookID ||
                    WebhookID != null &&
                    WebhookID.Equals(other.WebhookID)
                ) && 
                (
                    SoapParentPropertyId == other.SoapParentPropertyId ||
                    SoapParentPropertyId != null &&
                    SoapParentPropertyId.Equals(other.SoapParentPropertyId)
                ) && 
                (
                    UserDefinedFields == other.UserDefinedFields ||
                    UserDefinedFields != null &&
                    UserDefinedFields.SequenceEqual(other.UserDefinedFields)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (FieldID != null)
                    hashCode = hashCode * 59 + FieldID.GetHashCode();
                    if (IsDisplayAlwaysField != null)
                    hashCode = hashCode * 59 + IsDisplayAlwaysField.GetHashCode();
                    if (IsSubscribedField != null)
                    hashCode = hashCode * 59 + IsSubscribedField.GetHashCode();
                    if (WebhookID != null)
                    hashCode = hashCode * 59 + WebhookID.GetHashCode();
                    if (SoapParentPropertyId != null)
                    hashCode = hashCode * 59 + SoapParentPropertyId.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ConfigurationItemWebhookFieldModel left, ConfigurationItemWebhookFieldModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ConfigurationItemWebhookFieldModel left, ConfigurationItemWebhookFieldModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
