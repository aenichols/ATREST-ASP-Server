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
    public partial class ContractRetainerModel : IEquatable<ContractRetainerModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Gets or Sets AmountApproved
        /// </summary>
        [DataMember(Name="amountApproved")]
        public double? AmountApproved { get; set; }

        /// <summary>
        /// Gets or Sets ContractID
        /// </summary>
        [DataMember(Name="contractID")]
        public int? ContractID { get; set; }

        /// <summary>
        /// Gets or Sets DatePurchased
        /// </summary>
        [DataMember(Name="datePurchased")]
        public DateTime? DatePurchased { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets InternalCurrencyAmount
        /// </summary>
        [DataMember(Name="internalCurrencyAmount")]
        public double? InternalCurrencyAmount { get; set; }

        /// <summary>
        /// Gets or Sets InternalCurrencyAmountApproved
        /// </summary>
        [DataMember(Name="internalCurrencyAmountApproved")]
        public double? InternalCurrencyAmountApproved { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceNumber
        /// </summary>
        [DataMember(Name="invoiceNumber")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Gets or Sets IsPaid
        /// </summary>
        [DataMember(Name="isPaid")]
        public bool? IsPaid { get; set; }

        /// <summary>
        /// Gets or Sets PaymentID
        /// </summary>
        [DataMember(Name="paymentID")]
        public int? PaymentID { get; set; }

        /// <summary>
        /// Gets or Sets PaymentNumber
        /// </summary>
        [DataMember(Name="paymentNumber")]
        public string PaymentNumber { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status")]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId")]
        public ExpressionFuncContractRetainerInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class ContractRetainerModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AmountApproved: ").Append(AmountApproved).Append("\n");
            sb.Append("  ContractID: ").Append(ContractID).Append("\n");
            sb.Append("  DatePurchased: ").Append(DatePurchased).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  InternalCurrencyAmount: ").Append(InternalCurrencyAmount).Append("\n");
            sb.Append("  InternalCurrencyAmountApproved: ").Append(InternalCurrencyAmountApproved).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  IsPaid: ").Append(IsPaid).Append("\n");
            sb.Append("  PaymentID: ").Append(PaymentID).Append("\n");
            sb.Append("  PaymentNumber: ").Append(PaymentNumber).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ContractRetainerModel)obj);
        }

        /// <summary>
        /// Returns true if ContractRetainerModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ContractRetainerModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractRetainerModel other)
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
                    Amount == other.Amount ||
                    Amount != null &&
                    Amount.Equals(other.Amount)
                ) && 
                (
                    AmountApproved == other.AmountApproved ||
                    AmountApproved != null &&
                    AmountApproved.Equals(other.AmountApproved)
                ) && 
                (
                    ContractID == other.ContractID ||
                    ContractID != null &&
                    ContractID.Equals(other.ContractID)
                ) && 
                (
                    DatePurchased == other.DatePurchased ||
                    DatePurchased != null &&
                    DatePurchased.Equals(other.DatePurchased)
                ) && 
                (
                    EndDate == other.EndDate ||
                    EndDate != null &&
                    EndDate.Equals(other.EndDate)
                ) && 
                (
                    InternalCurrencyAmount == other.InternalCurrencyAmount ||
                    InternalCurrencyAmount != null &&
                    InternalCurrencyAmount.Equals(other.InternalCurrencyAmount)
                ) && 
                (
                    InternalCurrencyAmountApproved == other.InternalCurrencyAmountApproved ||
                    InternalCurrencyAmountApproved != null &&
                    InternalCurrencyAmountApproved.Equals(other.InternalCurrencyAmountApproved)
                ) && 
                (
                    InvoiceNumber == other.InvoiceNumber ||
                    InvoiceNumber != null &&
                    InvoiceNumber.Equals(other.InvoiceNumber)
                ) && 
                (
                    IsPaid == other.IsPaid ||
                    IsPaid != null &&
                    IsPaid.Equals(other.IsPaid)
                ) && 
                (
                    PaymentID == other.PaymentID ||
                    PaymentID != null &&
                    PaymentID.Equals(other.PaymentID)
                ) && 
                (
                    PaymentNumber == other.PaymentNumber ||
                    PaymentNumber != null &&
                    PaymentNumber.Equals(other.PaymentNumber)
                ) && 
                (
                    StartDate == other.StartDate ||
                    StartDate != null &&
                    StartDate.Equals(other.StartDate)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
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
                    if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                    if (AmountApproved != null)
                    hashCode = hashCode * 59 + AmountApproved.GetHashCode();
                    if (ContractID != null)
                    hashCode = hashCode * 59 + ContractID.GetHashCode();
                    if (DatePurchased != null)
                    hashCode = hashCode * 59 + DatePurchased.GetHashCode();
                    if (EndDate != null)
                    hashCode = hashCode * 59 + EndDate.GetHashCode();
                    if (InternalCurrencyAmount != null)
                    hashCode = hashCode * 59 + InternalCurrencyAmount.GetHashCode();
                    if (InternalCurrencyAmountApproved != null)
                    hashCode = hashCode * 59 + InternalCurrencyAmountApproved.GetHashCode();
                    if (InvoiceNumber != null)
                    hashCode = hashCode * 59 + InvoiceNumber.GetHashCode();
                    if (IsPaid != null)
                    hashCode = hashCode * 59 + IsPaid.GetHashCode();
                    if (PaymentID != null)
                    hashCode = hashCode * 59 + PaymentID.GetHashCode();
                    if (PaymentNumber != null)
                    hashCode = hashCode * 59 + PaymentNumber.GetHashCode();
                    if (StartDate != null)
                    hashCode = hashCode * 59 + StartDate.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (SoapParentPropertyId != null)
                    hashCode = hashCode * 59 + SoapParentPropertyId.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ContractRetainerModel left, ContractRetainerModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ContractRetainerModel left, ContractRetainerModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}