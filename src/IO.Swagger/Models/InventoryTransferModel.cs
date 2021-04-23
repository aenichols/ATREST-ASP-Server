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
    public partial class InventoryTransferModel : IEquatable<InventoryTransferModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets FromLocationID
        /// </summary>
        [DataMember(Name="fromLocationID")]
        public long? FromLocationID { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets ProductID
        /// </summary>
        [DataMember(Name="productID")]
        public long? ProductID { get; set; }

        /// <summary>
        /// Gets or Sets QuantityTransferred
        /// </summary>
        [DataMember(Name="quantityTransferred")]
        public int? QuantityTransferred { get; set; }

        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name="serialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets ToLocationID
        /// </summary>
        [DataMember(Name="toLocationID")]
        public long? ToLocationID { get; set; }

        /// <summary>
        /// Gets or Sets TransferByResourceID
        /// </summary>
        [DataMember(Name="transferByResourceID")]
        public int? TransferByResourceID { get; set; }

        /// <summary>
        /// Gets or Sets TransferDate
        /// </summary>
        [DataMember(Name="transferDate")]
        public DateTime? TransferDate { get; set; }

        /// <summary>
        /// Gets or Sets UpdateNote
        /// </summary>
        [DataMember(Name="updateNote")]
        public string UpdateNote { get; set; }

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
            sb.Append("class InventoryTransferModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FromLocationID: ").Append(FromLocationID).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  ProductID: ").Append(ProductID).Append("\n");
            sb.Append("  QuantityTransferred: ").Append(QuantityTransferred).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  ToLocationID: ").Append(ToLocationID).Append("\n");
            sb.Append("  TransferByResourceID: ").Append(TransferByResourceID).Append("\n");
            sb.Append("  TransferDate: ").Append(TransferDate).Append("\n");
            sb.Append("  UpdateNote: ").Append(UpdateNote).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InventoryTransferModel)obj);
        }

        /// <summary>
        /// Returns true if InventoryTransferModel instances are equal
        /// </summary>
        /// <param name="other">Instance of InventoryTransferModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryTransferModel other)
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
                    FromLocationID == other.FromLocationID ||
                    FromLocationID != null &&
                    FromLocationID.Equals(other.FromLocationID)
                ) && 
                (
                    Notes == other.Notes ||
                    Notes != null &&
                    Notes.Equals(other.Notes)
                ) && 
                (
                    ProductID == other.ProductID ||
                    ProductID != null &&
                    ProductID.Equals(other.ProductID)
                ) && 
                (
                    QuantityTransferred == other.QuantityTransferred ||
                    QuantityTransferred != null &&
                    QuantityTransferred.Equals(other.QuantityTransferred)
                ) && 
                (
                    SerialNumber == other.SerialNumber ||
                    SerialNumber != null &&
                    SerialNumber.Equals(other.SerialNumber)
                ) && 
                (
                    ToLocationID == other.ToLocationID ||
                    ToLocationID != null &&
                    ToLocationID.Equals(other.ToLocationID)
                ) && 
                (
                    TransferByResourceID == other.TransferByResourceID ||
                    TransferByResourceID != null &&
                    TransferByResourceID.Equals(other.TransferByResourceID)
                ) && 
                (
                    TransferDate == other.TransferDate ||
                    TransferDate != null &&
                    TransferDate.Equals(other.TransferDate)
                ) && 
                (
                    UpdateNote == other.UpdateNote ||
                    UpdateNote != null &&
                    UpdateNote.Equals(other.UpdateNote)
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
                    if (FromLocationID != null)
                    hashCode = hashCode * 59 + FromLocationID.GetHashCode();
                    if (Notes != null)
                    hashCode = hashCode * 59 + Notes.GetHashCode();
                    if (ProductID != null)
                    hashCode = hashCode * 59 + ProductID.GetHashCode();
                    if (QuantityTransferred != null)
                    hashCode = hashCode * 59 + QuantityTransferred.GetHashCode();
                    if (SerialNumber != null)
                    hashCode = hashCode * 59 + SerialNumber.GetHashCode();
                    if (ToLocationID != null)
                    hashCode = hashCode * 59 + ToLocationID.GetHashCode();
                    if (TransferByResourceID != null)
                    hashCode = hashCode * 59 + TransferByResourceID.GetHashCode();
                    if (TransferDate != null)
                    hashCode = hashCode * 59 + TransferDate.GetHashCode();
                    if (UpdateNote != null)
                    hashCode = hashCode * 59 + UpdateNote.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InventoryTransferModel left, InventoryTransferModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InventoryTransferModel left, InventoryTransferModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}