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
    public partial class ConfigurationItemCategoryUdfAssociationModel : IEquatable<ConfigurationItemCategoryUdfAssociationModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationItemCategoryID
        /// </summary>
        [DataMember(Name="configurationItemCategoryID")]
        public int? ConfigurationItemCategoryID { get; set; }

        /// <summary>
        /// Gets or Sets IsRequired
        /// </summary>
        [DataMember(Name="isRequired")]
        public bool? IsRequired { get; set; }

        /// <summary>
        /// Gets or Sets UserDefinedFieldDefinitionID
        /// </summary>
        [DataMember(Name="userDefinedFieldDefinitionID")]
        public int? UserDefinedFieldDefinitionID { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId")]
        public ExpressionFuncInstalledProductCategoryUdfAssociationInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class ConfigurationItemCategoryUdfAssociationModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ConfigurationItemCategoryID: ").Append(ConfigurationItemCategoryID).Append("\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  UserDefinedFieldDefinitionID: ").Append(UserDefinedFieldDefinitionID).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ConfigurationItemCategoryUdfAssociationModel)obj);
        }

        /// <summary>
        /// Returns true if ConfigurationItemCategoryUdfAssociationModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfigurationItemCategoryUdfAssociationModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigurationItemCategoryUdfAssociationModel other)
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
                    ConfigurationItemCategoryID == other.ConfigurationItemCategoryID ||
                    ConfigurationItemCategoryID != null &&
                    ConfigurationItemCategoryID.Equals(other.ConfigurationItemCategoryID)
                ) && 
                (
                    IsRequired == other.IsRequired ||
                    IsRequired != null &&
                    IsRequired.Equals(other.IsRequired)
                ) && 
                (
                    UserDefinedFieldDefinitionID == other.UserDefinedFieldDefinitionID ||
                    UserDefinedFieldDefinitionID != null &&
                    UserDefinedFieldDefinitionID.Equals(other.UserDefinedFieldDefinitionID)
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
                    if (ConfigurationItemCategoryID != null)
                    hashCode = hashCode * 59 + ConfigurationItemCategoryID.GetHashCode();
                    if (IsRequired != null)
                    hashCode = hashCode * 59 + IsRequired.GetHashCode();
                    if (UserDefinedFieldDefinitionID != null)
                    hashCode = hashCode * 59 + UserDefinedFieldDefinitionID.GetHashCode();
                    if (SoapParentPropertyId != null)
                    hashCode = hashCode * 59 + SoapParentPropertyId.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ConfigurationItemCategoryUdfAssociationModel left, ConfigurationItemCategoryUdfAssociationModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ConfigurationItemCategoryUdfAssociationModel left, ConfigurationItemCategoryUdfAssociationModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
