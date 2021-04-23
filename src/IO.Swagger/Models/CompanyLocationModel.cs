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
    public partial class CompanyLocationModel : IEquatable<CompanyLocationModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        [DataMember(Name="address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name="address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or Sets AlternatePhone1
        /// </summary>
        [DataMember(Name="alternatePhone1")]
        public string AlternatePhone1 { get; set; }

        /// <summary>
        /// Gets or Sets AlternatePhone2
        /// </summary>
        [DataMember(Name="alternatePhone2")]
        public string AlternatePhone2 { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets CompanyID
        /// </summary>
        [DataMember(Name="companyID")]
        public int? CompanyID { get; set; }

        /// <summary>
        /// Gets or Sets CountryID
        /// </summary>
        [DataMember(Name="countryID")]
        public int? CountryID { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Fax
        /// </summary>
        [DataMember(Name="fax")]
        public string Fax { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets IsPrimary
        /// </summary>
        [DataMember(Name="isPrimary")]
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// Gets or Sets IsTaxExempt
        /// </summary>
        [DataMember(Name="isTaxExempt")]
        public bool? IsTaxExempt { get; set; }

        /// <summary>
        /// Gets or Sets OverrideCompanyTaxSettings
        /// </summary>
        [DataMember(Name="overrideCompanyTaxSettings")]
        public bool? OverrideCompanyTaxSettings { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets RoundtripDistance
        /// </summary>
        [DataMember(Name="roundtripDistance")]
        public double? RoundtripDistance { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets TaxRegionID
        /// </summary>
        [DataMember(Name="taxRegionID")]
        public int? TaxRegionID { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId")]
        public ExpressionFuncAccountPhysicalLocationInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class CompanyLocationModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  AlternatePhone1: ").Append(AlternatePhone1).Append("\n");
            sb.Append("  AlternatePhone2: ").Append(AlternatePhone2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CompanyID: ").Append(CompanyID).Append("\n");
            sb.Append("  CountryID: ").Append(CountryID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsPrimary: ").Append(IsPrimary).Append("\n");
            sb.Append("  IsTaxExempt: ").Append(IsTaxExempt).Append("\n");
            sb.Append("  OverrideCompanyTaxSettings: ").Append(OverrideCompanyTaxSettings).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  RoundtripDistance: ").Append(RoundtripDistance).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TaxRegionID: ").Append(TaxRegionID).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CompanyLocationModel)obj);
        }

        /// <summary>
        /// Returns true if CompanyLocationModel instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyLocationModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyLocationModel other)
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
                    Address1 == other.Address1 ||
                    Address1 != null &&
                    Address1.Equals(other.Address1)
                ) && 
                (
                    Address2 == other.Address2 ||
                    Address2 != null &&
                    Address2.Equals(other.Address2)
                ) && 
                (
                    AlternatePhone1 == other.AlternatePhone1 ||
                    AlternatePhone1 != null &&
                    AlternatePhone1.Equals(other.AlternatePhone1)
                ) && 
                (
                    AlternatePhone2 == other.AlternatePhone2 ||
                    AlternatePhone2 != null &&
                    AlternatePhone2.Equals(other.AlternatePhone2)
                ) && 
                (
                    City == other.City ||
                    City != null &&
                    City.Equals(other.City)
                ) && 
                (
                    CompanyID == other.CompanyID ||
                    CompanyID != null &&
                    CompanyID.Equals(other.CompanyID)
                ) && 
                (
                    CountryID == other.CountryID ||
                    CountryID != null &&
                    CountryID.Equals(other.CountryID)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Fax == other.Fax ||
                    Fax != null &&
                    Fax.Equals(other.Fax)
                ) && 
                (
                    IsActive == other.IsActive ||
                    IsActive != null &&
                    IsActive.Equals(other.IsActive)
                ) && 
                (
                    IsPrimary == other.IsPrimary ||
                    IsPrimary != null &&
                    IsPrimary.Equals(other.IsPrimary)
                ) && 
                (
                    IsTaxExempt == other.IsTaxExempt ||
                    IsTaxExempt != null &&
                    IsTaxExempt.Equals(other.IsTaxExempt)
                ) && 
                (
                    OverrideCompanyTaxSettings == other.OverrideCompanyTaxSettings ||
                    OverrideCompanyTaxSettings != null &&
                    OverrideCompanyTaxSettings.Equals(other.OverrideCompanyTaxSettings)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Phone == other.Phone ||
                    Phone != null &&
                    Phone.Equals(other.Phone)
                ) && 
                (
                    PostalCode == other.PostalCode ||
                    PostalCode != null &&
                    PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    RoundtripDistance == other.RoundtripDistance ||
                    RoundtripDistance != null &&
                    RoundtripDistance.Equals(other.RoundtripDistance)
                ) && 
                (
                    State == other.State ||
                    State != null &&
                    State.Equals(other.State)
                ) && 
                (
                    TaxRegionID == other.TaxRegionID ||
                    TaxRegionID != null &&
                    TaxRegionID.Equals(other.TaxRegionID)
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
                    if (Address1 != null)
                    hashCode = hashCode * 59 + Address1.GetHashCode();
                    if (Address2 != null)
                    hashCode = hashCode * 59 + Address2.GetHashCode();
                    if (AlternatePhone1 != null)
                    hashCode = hashCode * 59 + AlternatePhone1.GetHashCode();
                    if (AlternatePhone2 != null)
                    hashCode = hashCode * 59 + AlternatePhone2.GetHashCode();
                    if (City != null)
                    hashCode = hashCode * 59 + City.GetHashCode();
                    if (CompanyID != null)
                    hashCode = hashCode * 59 + CompanyID.GetHashCode();
                    if (CountryID != null)
                    hashCode = hashCode * 59 + CountryID.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Fax != null)
                    hashCode = hashCode * 59 + Fax.GetHashCode();
                    if (IsActive != null)
                    hashCode = hashCode * 59 + IsActive.GetHashCode();
                    if (IsPrimary != null)
                    hashCode = hashCode * 59 + IsPrimary.GetHashCode();
                    if (IsTaxExempt != null)
                    hashCode = hashCode * 59 + IsTaxExempt.GetHashCode();
                    if (OverrideCompanyTaxSettings != null)
                    hashCode = hashCode * 59 + OverrideCompanyTaxSettings.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Phone != null)
                    hashCode = hashCode * 59 + Phone.GetHashCode();
                    if (PostalCode != null)
                    hashCode = hashCode * 59 + PostalCode.GetHashCode();
                    if (RoundtripDistance != null)
                    hashCode = hashCode * 59 + RoundtripDistance.GetHashCode();
                    if (State != null)
                    hashCode = hashCode * 59 + State.GetHashCode();
                    if (TaxRegionID != null)
                    hashCode = hashCode * 59 + TaxRegionID.GetHashCode();
                    if (SoapParentPropertyId != null)
                    hashCode = hashCode * 59 + SoapParentPropertyId.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CompanyLocationModel left, CompanyLocationModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CompanyLocationModel left, CompanyLocationModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
