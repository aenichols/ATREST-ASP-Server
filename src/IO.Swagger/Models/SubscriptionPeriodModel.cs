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
    public partial class SubscriptionPeriodModel : IEquatable<SubscriptionPeriodModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets PeriodCost
        /// </summary>
        [DataMember(Name="periodCost")]
        public double? PeriodCost { get; set; }

        /// <summary>
        /// Gets or Sets PeriodDate
        /// </summary>
        [DataMember(Name="periodDate")]
        public DateTime? PeriodDate { get; set; }

        /// <summary>
        /// Gets or Sets PeriodPrice
        /// </summary>
        [DataMember(Name="periodPrice")]
        public double? PeriodPrice { get; set; }

        /// <summary>
        /// Gets or Sets PostedDate
        /// </summary>
        [DataMember(Name="postedDate")]
        public DateTime? PostedDate { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseOrderNumber
        /// </summary>
        [DataMember(Name="purchaseOrderNumber")]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionID
        /// </summary>
        [DataMember(Name="subscriptionID")]
        public int? SubscriptionID { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId")]
        public long? SoapParentPropertyId { get; private set; }

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
            sb.Append("class SubscriptionPeriodModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PeriodCost: ").Append(PeriodCost).Append("\n");
            sb.Append("  PeriodDate: ").Append(PeriodDate).Append("\n");
            sb.Append("  PeriodPrice: ").Append(PeriodPrice).Append("\n");
            sb.Append("  PostedDate: ").Append(PostedDate).Append("\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  SubscriptionID: ").Append(SubscriptionID).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SubscriptionPeriodModel)obj);
        }

        /// <summary>
        /// Returns true if SubscriptionPeriodModel instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionPeriodModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPeriodModel other)
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
                    PeriodCost == other.PeriodCost ||
                    PeriodCost != null &&
                    PeriodCost.Equals(other.PeriodCost)
                ) && 
                (
                    PeriodDate == other.PeriodDate ||
                    PeriodDate != null &&
                    PeriodDate.Equals(other.PeriodDate)
                ) && 
                (
                    PeriodPrice == other.PeriodPrice ||
                    PeriodPrice != null &&
                    PeriodPrice.Equals(other.PeriodPrice)
                ) && 
                (
                    PostedDate == other.PostedDate ||
                    PostedDate != null &&
                    PostedDate.Equals(other.PostedDate)
                ) && 
                (
                    PurchaseOrderNumber == other.PurchaseOrderNumber ||
                    PurchaseOrderNumber != null &&
                    PurchaseOrderNumber.Equals(other.PurchaseOrderNumber)
                ) && 
                (
                    SubscriptionID == other.SubscriptionID ||
                    SubscriptionID != null &&
                    SubscriptionID.Equals(other.SubscriptionID)
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
                    if (PeriodCost != null)
                    hashCode = hashCode * 59 + PeriodCost.GetHashCode();
                    if (PeriodDate != null)
                    hashCode = hashCode * 59 + PeriodDate.GetHashCode();
                    if (PeriodPrice != null)
                    hashCode = hashCode * 59 + PeriodPrice.GetHashCode();
                    if (PostedDate != null)
                    hashCode = hashCode * 59 + PostedDate.GetHashCode();
                    if (PurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + PurchaseOrderNumber.GetHashCode();
                    if (SubscriptionID != null)
                    hashCode = hashCode * 59 + SubscriptionID.GetHashCode();
                    if (SoapParentPropertyId != null)
                    hashCode = hashCode * 59 + SoapParentPropertyId.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SubscriptionPeriodModel left, SubscriptionPeriodModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SubscriptionPeriodModel left, SubscriptionPeriodModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}