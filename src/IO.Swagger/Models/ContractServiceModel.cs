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
    public partial class ContractServiceModel : IEquatable<ContractServiceModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets ContractID
        /// </summary>
        [DataMember(Name="contractID")]
        public int? ContractID { get; set; }

        /// <summary>
        /// Gets or Sets InternalCurrencyAdjustedPrice
        /// </summary>
        [DataMember(Name="internalCurrencyAdjustedPrice")]
        public double? InternalCurrencyAdjustedPrice { get; set; }

        /// <summary>
        /// Gets or Sets InternalCurrencyUnitPrice
        /// </summary>
        [DataMember(Name="internalCurrencyUnitPrice")]
        public double? InternalCurrencyUnitPrice { get; set; }

        /// <summary>
        /// Gets or Sets InternalDescription
        /// </summary>
        [DataMember(Name="internalDescription")]
        public string InternalDescription { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceDescription
        /// </summary>
        [DataMember(Name="invoiceDescription")]
        public string InvoiceDescription { get; set; }

        /// <summary>
        /// Gets or Sets QuoteItemID
        /// </summary>
        [DataMember(Name="quoteItemID")]
        public long? QuoteItemID { get; set; }

        /// <summary>
        /// Gets or Sets ServiceID
        /// </summary>
        [DataMember(Name="serviceID")]
        public int? ServiceID { get; set; }

        /// <summary>
        /// Gets or Sets UnitCost
        /// </summary>
        [DataMember(Name="unitCost")]
        public double? UnitCost { get; set; }

        /// <summary>
        /// Gets or Sets UnitPrice
        /// </summary>
        [DataMember(Name="unitPrice")]
        public double? UnitPrice { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId")]
        public ExpressionFuncContractServiceInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class ContractServiceModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContractID: ").Append(ContractID).Append("\n");
            sb.Append("  InternalCurrencyAdjustedPrice: ").Append(InternalCurrencyAdjustedPrice).Append("\n");
            sb.Append("  InternalCurrencyUnitPrice: ").Append(InternalCurrencyUnitPrice).Append("\n");
            sb.Append("  InternalDescription: ").Append(InternalDescription).Append("\n");
            sb.Append("  InvoiceDescription: ").Append(InvoiceDescription).Append("\n");
            sb.Append("  QuoteItemID: ").Append(QuoteItemID).Append("\n");
            sb.Append("  ServiceID: ").Append(ServiceID).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ContractServiceModel)obj);
        }

        /// <summary>
        /// Returns true if ContractServiceModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ContractServiceModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractServiceModel other)
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
                    ContractID == other.ContractID ||
                    ContractID != null &&
                    ContractID.Equals(other.ContractID)
                ) && 
                (
                    InternalCurrencyAdjustedPrice == other.InternalCurrencyAdjustedPrice ||
                    InternalCurrencyAdjustedPrice != null &&
                    InternalCurrencyAdjustedPrice.Equals(other.InternalCurrencyAdjustedPrice)
                ) && 
                (
                    InternalCurrencyUnitPrice == other.InternalCurrencyUnitPrice ||
                    InternalCurrencyUnitPrice != null &&
                    InternalCurrencyUnitPrice.Equals(other.InternalCurrencyUnitPrice)
                ) && 
                (
                    InternalDescription == other.InternalDescription ||
                    InternalDescription != null &&
                    InternalDescription.Equals(other.InternalDescription)
                ) && 
                (
                    InvoiceDescription == other.InvoiceDescription ||
                    InvoiceDescription != null &&
                    InvoiceDescription.Equals(other.InvoiceDescription)
                ) && 
                (
                    QuoteItemID == other.QuoteItemID ||
                    QuoteItemID != null &&
                    QuoteItemID.Equals(other.QuoteItemID)
                ) && 
                (
                    ServiceID == other.ServiceID ||
                    ServiceID != null &&
                    ServiceID.Equals(other.ServiceID)
                ) && 
                (
                    UnitCost == other.UnitCost ||
                    UnitCost != null &&
                    UnitCost.Equals(other.UnitCost)
                ) && 
                (
                    UnitPrice == other.UnitPrice ||
                    UnitPrice != null &&
                    UnitPrice.Equals(other.UnitPrice)
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
                    if (ContractID != null)
                    hashCode = hashCode * 59 + ContractID.GetHashCode();
                    if (InternalCurrencyAdjustedPrice != null)
                    hashCode = hashCode * 59 + InternalCurrencyAdjustedPrice.GetHashCode();
                    if (InternalCurrencyUnitPrice != null)
                    hashCode = hashCode * 59 + InternalCurrencyUnitPrice.GetHashCode();
                    if (InternalDescription != null)
                    hashCode = hashCode * 59 + InternalDescription.GetHashCode();
                    if (InvoiceDescription != null)
                    hashCode = hashCode * 59 + InvoiceDescription.GetHashCode();
                    if (QuoteItemID != null)
                    hashCode = hashCode * 59 + QuoteItemID.GetHashCode();
                    if (ServiceID != null)
                    hashCode = hashCode * 59 + ServiceID.GetHashCode();
                    if (UnitCost != null)
                    hashCode = hashCode * 59 + UnitCost.GetHashCode();
                    if (UnitPrice != null)
                    hashCode = hashCode * 59 + UnitPrice.GetHashCode();
                    if (SoapParentPropertyId != null)
                    hashCode = hashCode * 59 + SoapParentPropertyId.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ContractServiceModel left, ContractServiceModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ContractServiceModel left, ContractServiceModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
