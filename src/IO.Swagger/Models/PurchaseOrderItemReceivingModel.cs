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
    public partial class PurchaseOrderItemReceivingModel : IEquatable<PurchaseOrderItemReceivingModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseOrderItemID
        /// </summary>
        [DataMember(Name="purchaseOrderItemID")]
        public long? PurchaseOrderItemID { get; set; }

        /// <summary>
        /// Gets or Sets QuantityBackOrdered
        /// </summary>
        [DataMember(Name="quantityBackOrdered")]
        public int? QuantityBackOrdered { get; set; }

        /// <summary>
        /// Gets or Sets QuantityNowReceiving
        /// </summary>
        [DataMember(Name="quantityNowReceiving")]
        public int? QuantityNowReceiving { get; set; }

        /// <summary>
        /// Gets or Sets QuantityPreviouslyReceived
        /// </summary>
        [DataMember(Name="quantityPreviouslyReceived")]
        public int? QuantityPreviouslyReceived { get; set; }

        /// <summary>
        /// Gets or Sets ReceiveDate
        /// </summary>
        [DataMember(Name="receiveDate")]
        public DateTime? ReceiveDate { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedByResourceID
        /// </summary>
        [DataMember(Name="receivedByResourceID")]
        public int? ReceivedByResourceID { get; set; }

        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name="serialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId")]
        public ExpressionFuncPurchaseOrderReceiveInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class PurchaseOrderItemReceivingModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PurchaseOrderItemID: ").Append(PurchaseOrderItemID).Append("\n");
            sb.Append("  QuantityBackOrdered: ").Append(QuantityBackOrdered).Append("\n");
            sb.Append("  QuantityNowReceiving: ").Append(QuantityNowReceiving).Append("\n");
            sb.Append("  QuantityPreviouslyReceived: ").Append(QuantityPreviouslyReceived).Append("\n");
            sb.Append("  ReceiveDate: ").Append(ReceiveDate).Append("\n");
            sb.Append("  ReceivedByResourceID: ").Append(ReceivedByResourceID).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PurchaseOrderItemReceivingModel)obj);
        }

        /// <summary>
        /// Returns true if PurchaseOrderItemReceivingModel instances are equal
        /// </summary>
        /// <param name="other">Instance of PurchaseOrderItemReceivingModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseOrderItemReceivingModel other)
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
                    PurchaseOrderItemID == other.PurchaseOrderItemID ||
                    PurchaseOrderItemID != null &&
                    PurchaseOrderItemID.Equals(other.PurchaseOrderItemID)
                ) && 
                (
                    QuantityBackOrdered == other.QuantityBackOrdered ||
                    QuantityBackOrdered != null &&
                    QuantityBackOrdered.Equals(other.QuantityBackOrdered)
                ) && 
                (
                    QuantityNowReceiving == other.QuantityNowReceiving ||
                    QuantityNowReceiving != null &&
                    QuantityNowReceiving.Equals(other.QuantityNowReceiving)
                ) && 
                (
                    QuantityPreviouslyReceived == other.QuantityPreviouslyReceived ||
                    QuantityPreviouslyReceived != null &&
                    QuantityPreviouslyReceived.Equals(other.QuantityPreviouslyReceived)
                ) && 
                (
                    ReceiveDate == other.ReceiveDate ||
                    ReceiveDate != null &&
                    ReceiveDate.Equals(other.ReceiveDate)
                ) && 
                (
                    ReceivedByResourceID == other.ReceivedByResourceID ||
                    ReceivedByResourceID != null &&
                    ReceivedByResourceID.Equals(other.ReceivedByResourceID)
                ) && 
                (
                    SerialNumber == other.SerialNumber ||
                    SerialNumber != null &&
                    SerialNumber.Equals(other.SerialNumber)
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
                    if (PurchaseOrderItemID != null)
                    hashCode = hashCode * 59 + PurchaseOrderItemID.GetHashCode();
                    if (QuantityBackOrdered != null)
                    hashCode = hashCode * 59 + QuantityBackOrdered.GetHashCode();
                    if (QuantityNowReceiving != null)
                    hashCode = hashCode * 59 + QuantityNowReceiving.GetHashCode();
                    if (QuantityPreviouslyReceived != null)
                    hashCode = hashCode * 59 + QuantityPreviouslyReceived.GetHashCode();
                    if (ReceiveDate != null)
                    hashCode = hashCode * 59 + ReceiveDate.GetHashCode();
                    if (ReceivedByResourceID != null)
                    hashCode = hashCode * 59 + ReceivedByResourceID.GetHashCode();
                    if (SerialNumber != null)
                    hashCode = hashCode * 59 + SerialNumber.GetHashCode();
                    if (SoapParentPropertyId != null)
                    hashCode = hashCode * 59 + SoapParentPropertyId.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PurchaseOrderItemReceivingModel left, PurchaseOrderItemReceivingModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PurchaseOrderItemReceivingModel left, PurchaseOrderItemReceivingModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
