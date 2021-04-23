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
    public partial class ProductVendorModel : IEquatable<ProductVendorModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name="isDefault")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Gets or Sets ProductID
        /// </summary>
        [DataMember(Name="productID")]
        public int? ProductID { get; set; }

        /// <summary>
        /// Gets or Sets VendorCost
        /// </summary>
        [DataMember(Name="vendorCost")]
        public double? VendorCost { get; set; }

        /// <summary>
        /// Gets or Sets VendorID
        /// </summary>
        [DataMember(Name="vendorID")]
        public int? VendorID { get; set; }

        /// <summary>
        /// Gets or Sets VendorPartNumber
        /// </summary>
        [DataMember(Name="vendorPartNumber")]
        public string VendorPartNumber { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId")]
        public ExpressionFuncProductVendorInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class ProductVendorModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  ProductID: ").Append(ProductID).Append("\n");
            sb.Append("  VendorCost: ").Append(VendorCost).Append("\n");
            sb.Append("  VendorID: ").Append(VendorID).Append("\n");
            sb.Append("  VendorPartNumber: ").Append(VendorPartNumber).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ProductVendorModel)obj);
        }

        /// <summary>
        /// Returns true if ProductVendorModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductVendorModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductVendorModel other)
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
                    IsActive == other.IsActive ||
                    IsActive != null &&
                    IsActive.Equals(other.IsActive)
                ) && 
                (
                    IsDefault == other.IsDefault ||
                    IsDefault != null &&
                    IsDefault.Equals(other.IsDefault)
                ) && 
                (
                    ProductID == other.ProductID ||
                    ProductID != null &&
                    ProductID.Equals(other.ProductID)
                ) && 
                (
                    VendorCost == other.VendorCost ||
                    VendorCost != null &&
                    VendorCost.Equals(other.VendorCost)
                ) && 
                (
                    VendorID == other.VendorID ||
                    VendorID != null &&
                    VendorID.Equals(other.VendorID)
                ) && 
                (
                    VendorPartNumber == other.VendorPartNumber ||
                    VendorPartNumber != null &&
                    VendorPartNumber.Equals(other.VendorPartNumber)
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
                    if (IsActive != null)
                    hashCode = hashCode * 59 + IsActive.GetHashCode();
                    if (IsDefault != null)
                    hashCode = hashCode * 59 + IsDefault.GetHashCode();
                    if (ProductID != null)
                    hashCode = hashCode * 59 + ProductID.GetHashCode();
                    if (VendorCost != null)
                    hashCode = hashCode * 59 + VendorCost.GetHashCode();
                    if (VendorID != null)
                    hashCode = hashCode * 59 + VendorID.GetHashCode();
                    if (VendorPartNumber != null)
                    hashCode = hashCode * 59 + VendorPartNumber.GetHashCode();
                    if (SoapParentPropertyId != null)
                    hashCode = hashCode * 59 + SoapParentPropertyId.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ProductVendorModel left, ProductVendorModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProductVendorModel left, ProductVendorModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
