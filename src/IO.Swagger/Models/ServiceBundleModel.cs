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
    public partial class ServiceBundleModel : IEquatable<ServiceBundleModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets BillingCodeID
        /// </summary>
        [DataMember(Name="billingCodeID")]
        public int? BillingCodeID { get; set; }

        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate")]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatorResourceID
        /// </summary>
        [DataMember(Name="creatorResourceID")]
        public int? CreatorResourceID { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceDescription
        /// </summary>
        [DataMember(Name="invoiceDescription")]
        public string InvoiceDescription { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDate
        /// </summary>
        [DataMember(Name="lastModifiedDate")]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PercentageDiscount
        /// </summary>
        [DataMember(Name="percentageDiscount")]
        public double? PercentageDiscount { get; set; }

        /// <summary>
        /// Gets or Sets PeriodType
        /// </summary>
        [DataMember(Name="periodType")]
        public int? PeriodType { get; set; }

        /// <summary>
        /// Gets or Sets ServiceLevelAgreementID
        /// </summary>
        [DataMember(Name="serviceLevelAgreementID")]
        public long? ServiceLevelAgreementID { get; set; }

        /// <summary>
        /// Gets or Sets UnitCost
        /// </summary>
        [DataMember(Name="unitCost")]
        public double? UnitCost { get; set; }

        /// <summary>
        /// Gets or Sets UnitDiscount
        /// </summary>
        [DataMember(Name="unitDiscount")]
        public double? UnitDiscount { get; set; }

        /// <summary>
        /// Gets or Sets UnitPrice
        /// </summary>
        [DataMember(Name="unitPrice")]
        public double? UnitPrice { get; set; }

        /// <summary>
        /// Gets or Sets UpdateResourceID
        /// </summary>
        [DataMember(Name="updateResourceID")]
        public int? UpdateResourceID { get; set; }

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
            sb.Append("class ServiceBundleModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BillingCodeID: ").Append(BillingCodeID).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  CreatorResourceID: ").Append(CreatorResourceID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  InvoiceDescription: ").Append(InvoiceDescription).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PercentageDiscount: ").Append(PercentageDiscount).Append("\n");
            sb.Append("  PeriodType: ").Append(PeriodType).Append("\n");
            sb.Append("  ServiceLevelAgreementID: ").Append(ServiceLevelAgreementID).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
            sb.Append("  UnitDiscount: ").Append(UnitDiscount).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  UpdateResourceID: ").Append(UpdateResourceID).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ServiceBundleModel)obj);
        }

        /// <summary>
        /// Returns true if ServiceBundleModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ServiceBundleModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceBundleModel other)
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
                    BillingCodeID == other.BillingCodeID ||
                    BillingCodeID != null &&
                    BillingCodeID.Equals(other.BillingCodeID)
                ) && 
                (
                    CreateDate == other.CreateDate ||
                    CreateDate != null &&
                    CreateDate.Equals(other.CreateDate)
                ) && 
                (
                    CreatorResourceID == other.CreatorResourceID ||
                    CreatorResourceID != null &&
                    CreatorResourceID.Equals(other.CreatorResourceID)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    InvoiceDescription == other.InvoiceDescription ||
                    InvoiceDescription != null &&
                    InvoiceDescription.Equals(other.InvoiceDescription)
                ) && 
                (
                    IsActive == other.IsActive ||
                    IsActive != null &&
                    IsActive.Equals(other.IsActive)
                ) && 
                (
                    LastModifiedDate == other.LastModifiedDate ||
                    LastModifiedDate != null &&
                    LastModifiedDate.Equals(other.LastModifiedDate)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    PercentageDiscount == other.PercentageDiscount ||
                    PercentageDiscount != null &&
                    PercentageDiscount.Equals(other.PercentageDiscount)
                ) && 
                (
                    PeriodType == other.PeriodType ||
                    PeriodType != null &&
                    PeriodType.Equals(other.PeriodType)
                ) && 
                (
                    ServiceLevelAgreementID == other.ServiceLevelAgreementID ||
                    ServiceLevelAgreementID != null &&
                    ServiceLevelAgreementID.Equals(other.ServiceLevelAgreementID)
                ) && 
                (
                    UnitCost == other.UnitCost ||
                    UnitCost != null &&
                    UnitCost.Equals(other.UnitCost)
                ) && 
                (
                    UnitDiscount == other.UnitDiscount ||
                    UnitDiscount != null &&
                    UnitDiscount.Equals(other.UnitDiscount)
                ) && 
                (
                    UnitPrice == other.UnitPrice ||
                    UnitPrice != null &&
                    UnitPrice.Equals(other.UnitPrice)
                ) && 
                (
                    UpdateResourceID == other.UpdateResourceID ||
                    UpdateResourceID != null &&
                    UpdateResourceID.Equals(other.UpdateResourceID)
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
                    if (BillingCodeID != null)
                    hashCode = hashCode * 59 + BillingCodeID.GetHashCode();
                    if (CreateDate != null)
                    hashCode = hashCode * 59 + CreateDate.GetHashCode();
                    if (CreatorResourceID != null)
                    hashCode = hashCode * 59 + CreatorResourceID.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (InvoiceDescription != null)
                    hashCode = hashCode * 59 + InvoiceDescription.GetHashCode();
                    if (IsActive != null)
                    hashCode = hashCode * 59 + IsActive.GetHashCode();
                    if (LastModifiedDate != null)
                    hashCode = hashCode * 59 + LastModifiedDate.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (PercentageDiscount != null)
                    hashCode = hashCode * 59 + PercentageDiscount.GetHashCode();
                    if (PeriodType != null)
                    hashCode = hashCode * 59 + PeriodType.GetHashCode();
                    if (ServiceLevelAgreementID != null)
                    hashCode = hashCode * 59 + ServiceLevelAgreementID.GetHashCode();
                    if (UnitCost != null)
                    hashCode = hashCode * 59 + UnitCost.GetHashCode();
                    if (UnitDiscount != null)
                    hashCode = hashCode * 59 + UnitDiscount.GetHashCode();
                    if (UnitPrice != null)
                    hashCode = hashCode * 59 + UnitPrice.GetHashCode();
                    if (UpdateResourceID != null)
                    hashCode = hashCode * 59 + UpdateResourceID.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ServiceBundleModel left, ServiceBundleModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ServiceBundleModel left, ServiceBundleModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
