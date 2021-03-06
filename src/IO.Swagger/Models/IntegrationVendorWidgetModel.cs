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
    public partial class IntegrationVendorWidgetModel : IEquatable<IntegrationVendorWidgetModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets CreateDateTime
        /// </summary>
        [DataMember(Name="createDateTime")]
        public DateTime? CreateDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="lastModifiedDateTime")]
        public DateTime? LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceUrl
        /// </summary>
        [DataMember(Name="referenceUrl")]
        public string ReferenceUrl { get; set; }

        /// <summary>
        /// Gets or Sets Secret
        /// </summary>
        [DataMember(Name="secret")]
        public string Secret { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets VendorSuppliedID
        /// </summary>
        [DataMember(Name="vendorSuppliedID")]
        public string VendorSuppliedID { get; set; }

        /// <summary>
        /// Gets or Sets WidgetKey
        /// </summary>
        [DataMember(Name="widgetKey")]
        public string WidgetKey { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name="width")]
        public int? Width { get; set; }

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
            sb.Append("class IntegrationVendorWidgetModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDateTime: ").Append(CreateDateTime).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  ReferenceUrl: ").Append(ReferenceUrl).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  VendorSuppliedID: ").Append(VendorSuppliedID).Append("\n");
            sb.Append("  WidgetKey: ").Append(WidgetKey).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
            return obj.GetType() == GetType() && Equals((IntegrationVendorWidgetModel)obj);
        }

        /// <summary>
        /// Returns true if IntegrationVendorWidgetModel instances are equal
        /// </summary>
        /// <param name="other">Instance of IntegrationVendorWidgetModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationVendorWidgetModel other)
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
                    CreateDateTime == other.CreateDateTime ||
                    CreateDateTime != null &&
                    CreateDateTime.Equals(other.CreateDateTime)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    IsActive == other.IsActive ||
                    IsActive != null &&
                    IsActive.Equals(other.IsActive)
                ) && 
                (
                    LastModifiedDateTime == other.LastModifiedDateTime ||
                    LastModifiedDateTime != null &&
                    LastModifiedDateTime.Equals(other.LastModifiedDateTime)
                ) && 
                (
                    ReferenceUrl == other.ReferenceUrl ||
                    ReferenceUrl != null &&
                    ReferenceUrl.Equals(other.ReferenceUrl)
                ) && 
                (
                    Secret == other.Secret ||
                    Secret != null &&
                    Secret.Equals(other.Secret)
                ) && 
                (
                    Title == other.Title ||
                    Title != null &&
                    Title.Equals(other.Title)
                ) && 
                (
                    VendorSuppliedID == other.VendorSuppliedID ||
                    VendorSuppliedID != null &&
                    VendorSuppliedID.Equals(other.VendorSuppliedID)
                ) && 
                (
                    WidgetKey == other.WidgetKey ||
                    WidgetKey != null &&
                    WidgetKey.Equals(other.WidgetKey)
                ) && 
                (
                    Width == other.Width ||
                    Width != null &&
                    Width.Equals(other.Width)
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
                    if (CreateDateTime != null)
                    hashCode = hashCode * 59 + CreateDateTime.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (IsActive != null)
                    hashCode = hashCode * 59 + IsActive.GetHashCode();
                    if (LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + LastModifiedDateTime.GetHashCode();
                    if (ReferenceUrl != null)
                    hashCode = hashCode * 59 + ReferenceUrl.GetHashCode();
                    if (Secret != null)
                    hashCode = hashCode * 59 + Secret.GetHashCode();
                    if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                    if (VendorSuppliedID != null)
                    hashCode = hashCode * 59 + VendorSuppliedID.GetHashCode();
                    if (WidgetKey != null)
                    hashCode = hashCode * 59 + WidgetKey.GetHashCode();
                    if (Width != null)
                    hashCode = hashCode * 59 + Width.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(IntegrationVendorWidgetModel left, IntegrationVendorWidgetModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IntegrationVendorWidgetModel left, IntegrationVendorWidgetModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
