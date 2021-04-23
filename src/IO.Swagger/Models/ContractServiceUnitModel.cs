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
    public partial class ContractServiceUnitModel : IEquatable<ContractServiceUnitModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets ApproveAndPostDate
        /// </summary>
        [DataMember(Name="approveAndPostDate")]
        public DateTime? ApproveAndPostDate { get; set; }

        /// <summary>
        /// Gets or Sets ContractID
        /// </summary>
        [DataMember(Name="contractID")]
        public int? ContractID { get; set; }

        /// <summary>
        /// Gets or Sets ContractServiceID
        /// </summary>
        [DataMember(Name="contractServiceID")]
        public int? ContractServiceID { get; set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets InternalCurrencyPrice
        /// </summary>
        [DataMember(Name="internalCurrencyPrice")]
        public double? InternalCurrencyPrice { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationalLevelAssociationID
        /// </summary>
        [DataMember(Name="organizationalLevelAssociationID")]
        public int? OrganizationalLevelAssociationID { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price")]
        public double? Price { get; set; }

        /// <summary>
        /// Gets or Sets ServiceID
        /// </summary>
        [DataMember(Name="serviceID")]
        public int? ServiceID { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets Units
        /// </summary>
        [DataMember(Name="units")]
        public int? Units { get; set; }

        /// <summary>
        /// Gets or Sets VendorCompanyID
        /// </summary>
        [DataMember(Name="vendorCompanyID")]
        public int? VendorCompanyID { get; set; }

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
            sb.Append("class ContractServiceUnitModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ApproveAndPostDate: ").Append(ApproveAndPostDate).Append("\n");
            sb.Append("  ContractID: ").Append(ContractID).Append("\n");
            sb.Append("  ContractServiceID: ").Append(ContractServiceID).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  InternalCurrencyPrice: ").Append(InternalCurrencyPrice).Append("\n");
            sb.Append("  OrganizationalLevelAssociationID: ").Append(OrganizationalLevelAssociationID).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  ServiceID: ").Append(ServiceID).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  VendorCompanyID: ").Append(VendorCompanyID).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ContractServiceUnitModel)obj);
        }

        /// <summary>
        /// Returns true if ContractServiceUnitModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ContractServiceUnitModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractServiceUnitModel other)
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
                    ApproveAndPostDate == other.ApproveAndPostDate ||
                    ApproveAndPostDate != null &&
                    ApproveAndPostDate.Equals(other.ApproveAndPostDate)
                ) && 
                (
                    ContractID == other.ContractID ||
                    ContractID != null &&
                    ContractID.Equals(other.ContractID)
                ) && 
                (
                    ContractServiceID == other.ContractServiceID ||
                    ContractServiceID != null &&
                    ContractServiceID.Equals(other.ContractServiceID)
                ) && 
                (
                    Cost == other.Cost ||
                    Cost != null &&
                    Cost.Equals(other.Cost)
                ) && 
                (
                    EndDate == other.EndDate ||
                    EndDate != null &&
                    EndDate.Equals(other.EndDate)
                ) && 
                (
                    InternalCurrencyPrice == other.InternalCurrencyPrice ||
                    InternalCurrencyPrice != null &&
                    InternalCurrencyPrice.Equals(other.InternalCurrencyPrice)
                ) && 
                (
                    OrganizationalLevelAssociationID == other.OrganizationalLevelAssociationID ||
                    OrganizationalLevelAssociationID != null &&
                    OrganizationalLevelAssociationID.Equals(other.OrganizationalLevelAssociationID)
                ) && 
                (
                    Price == other.Price ||
                    Price != null &&
                    Price.Equals(other.Price)
                ) && 
                (
                    ServiceID == other.ServiceID ||
                    ServiceID != null &&
                    ServiceID.Equals(other.ServiceID)
                ) && 
                (
                    StartDate == other.StartDate ||
                    StartDate != null &&
                    StartDate.Equals(other.StartDate)
                ) && 
                (
                    Units == other.Units ||
                    Units != null &&
                    Units.Equals(other.Units)
                ) && 
                (
                    VendorCompanyID == other.VendorCompanyID ||
                    VendorCompanyID != null &&
                    VendorCompanyID.Equals(other.VendorCompanyID)
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
                    if (ApproveAndPostDate != null)
                    hashCode = hashCode * 59 + ApproveAndPostDate.GetHashCode();
                    if (ContractID != null)
                    hashCode = hashCode * 59 + ContractID.GetHashCode();
                    if (ContractServiceID != null)
                    hashCode = hashCode * 59 + ContractServiceID.GetHashCode();
                    if (Cost != null)
                    hashCode = hashCode * 59 + Cost.GetHashCode();
                    if (EndDate != null)
                    hashCode = hashCode * 59 + EndDate.GetHashCode();
                    if (InternalCurrencyPrice != null)
                    hashCode = hashCode * 59 + InternalCurrencyPrice.GetHashCode();
                    if (OrganizationalLevelAssociationID != null)
                    hashCode = hashCode * 59 + OrganizationalLevelAssociationID.GetHashCode();
                    if (Price != null)
                    hashCode = hashCode * 59 + Price.GetHashCode();
                    if (ServiceID != null)
                    hashCode = hashCode * 59 + ServiceID.GetHashCode();
                    if (StartDate != null)
                    hashCode = hashCode * 59 + StartDate.GetHashCode();
                    if (Units != null)
                    hashCode = hashCode * 59 + Units.GetHashCode();
                    if (VendorCompanyID != null)
                    hashCode = hashCode * 59 + VendorCompanyID.GetHashCode();
                    if (SoapParentPropertyId != null)
                    hashCode = hashCode * 59 + SoapParentPropertyId.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ContractServiceUnitModel left, ContractServiceUnitModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ContractServiceUnitModel left, ContractServiceUnitModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}