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
    public partial class RoleModel : IEquatable<RoleModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets HourlyFactor
        /// </summary>
        [DataMember(Name="hourlyFactor")]
        public double? HourlyFactor { get; set; }

        /// <summary>
        /// Gets or Sets HourlyRate
        /// </summary>
        [DataMember(Name="hourlyRate")]
        public double? HourlyRate { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets IsExcludedFromNewContracts
        /// </summary>
        [DataMember(Name="isExcludedFromNewContracts")]
        public bool? IsExcludedFromNewContracts { get; set; }

        /// <summary>
        /// Gets or Sets IsSystemRole
        /// </summary>
        [DataMember(Name="isSystemRole")]
        public bool? IsSystemRole { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets QuoteItemDefaultTaxCategoryId
        /// </summary>
        [DataMember(Name="quoteItemDefaultTaxCategoryId")]
        public int? QuoteItemDefaultTaxCategoryId { get; set; }

        /// <summary>
        /// Gets or Sets RoleType
        /// </summary>
        [DataMember(Name="roleType")]
        public int? RoleType { get; set; }

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
            sb.Append("class RoleModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  HourlyFactor: ").Append(HourlyFactor).Append("\n");
            sb.Append("  HourlyRate: ").Append(HourlyRate).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsExcludedFromNewContracts: ").Append(IsExcludedFromNewContracts).Append("\n");
            sb.Append("  IsSystemRole: ").Append(IsSystemRole).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  QuoteItemDefaultTaxCategoryId: ").Append(QuoteItemDefaultTaxCategoryId).Append("\n");
            sb.Append("  RoleType: ").Append(RoleType).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RoleModel)obj);
        }

        /// <summary>
        /// Returns true if RoleModel instances are equal
        /// </summary>
        /// <param name="other">Instance of RoleModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleModel other)
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
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    HourlyFactor == other.HourlyFactor ||
                    HourlyFactor != null &&
                    HourlyFactor.Equals(other.HourlyFactor)
                ) && 
                (
                    HourlyRate == other.HourlyRate ||
                    HourlyRate != null &&
                    HourlyRate.Equals(other.HourlyRate)
                ) && 
                (
                    IsActive == other.IsActive ||
                    IsActive != null &&
                    IsActive.Equals(other.IsActive)
                ) && 
                (
                    IsExcludedFromNewContracts == other.IsExcludedFromNewContracts ||
                    IsExcludedFromNewContracts != null &&
                    IsExcludedFromNewContracts.Equals(other.IsExcludedFromNewContracts)
                ) && 
                (
                    IsSystemRole == other.IsSystemRole ||
                    IsSystemRole != null &&
                    IsSystemRole.Equals(other.IsSystemRole)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    QuoteItemDefaultTaxCategoryId == other.QuoteItemDefaultTaxCategoryId ||
                    QuoteItemDefaultTaxCategoryId != null &&
                    QuoteItemDefaultTaxCategoryId.Equals(other.QuoteItemDefaultTaxCategoryId)
                ) && 
                (
                    RoleType == other.RoleType ||
                    RoleType != null &&
                    RoleType.Equals(other.RoleType)
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
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (HourlyFactor != null)
                    hashCode = hashCode * 59 + HourlyFactor.GetHashCode();
                    if (HourlyRate != null)
                    hashCode = hashCode * 59 + HourlyRate.GetHashCode();
                    if (IsActive != null)
                    hashCode = hashCode * 59 + IsActive.GetHashCode();
                    if (IsExcludedFromNewContracts != null)
                    hashCode = hashCode * 59 + IsExcludedFromNewContracts.GetHashCode();
                    if (IsSystemRole != null)
                    hashCode = hashCode * 59 + IsSystemRole.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (QuoteItemDefaultTaxCategoryId != null)
                    hashCode = hashCode * 59 + QuoteItemDefaultTaxCategoryId.GetHashCode();
                    if (RoleType != null)
                    hashCode = hashCode * 59 + RoleType.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RoleModel left, RoleModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RoleModel left, RoleModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}