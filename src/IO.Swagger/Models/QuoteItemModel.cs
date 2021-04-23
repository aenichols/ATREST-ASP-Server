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
    public partial class QuoteItemModel : IEquatable<QuoteItemModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets AverageCost
        /// </summary>
        [DataMember(Name="averageCost")]
        public double? AverageCost { get; set; }

        /// <summary>
        /// Gets or Sets ChargeID
        /// </summary>
        [DataMember(Name="chargeID")]
        public int? ChargeID { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseID
        /// </summary>
        [DataMember(Name="expenseID")]
        public int? ExpenseID { get; set; }

        /// <summary>
        /// Gets or Sets HighestCost
        /// </summary>
        [DataMember(Name="highestCost")]
        public double? HighestCost { get; set; }

        /// <summary>
        /// Gets or Sets InternalCurrencyLineDiscount
        /// </summary>
        [DataMember(Name="internalCurrencyLineDiscount")]
        public double? InternalCurrencyLineDiscount { get; set; }

        /// <summary>
        /// Gets or Sets InternalCurrencyUnitDiscount
        /// </summary>
        [DataMember(Name="internalCurrencyUnitDiscount")]
        public double? InternalCurrencyUnitDiscount { get; set; }

        /// <summary>
        /// Gets or Sets InternalCurrencyUnitPrice
        /// </summary>
        [DataMember(Name="internalCurrencyUnitPrice")]
        public double? InternalCurrencyUnitPrice { get; set; }

        /// <summary>
        /// Gets or Sets IsOptional
        /// </summary>
        [DataMember(Name="isOptional")]
        public bool? IsOptional { get; set; }

        /// <summary>
        /// Gets or Sets IsTaxable
        /// </summary>
        [DataMember(Name="isTaxable")]
        public bool? IsTaxable { get; set; }

        /// <summary>
        /// Gets or Sets LaborID
        /// </summary>
        [DataMember(Name="laborID")]
        public int? LaborID { get; set; }

        /// <summary>
        /// Gets or Sets LineDiscount
        /// </summary>
        [DataMember(Name="lineDiscount")]
        public double? LineDiscount { get; set; }

        /// <summary>
        /// Gets or Sets MarkupRate
        /// </summary>
        [DataMember(Name="markupRate")]
        public double? MarkupRate { get; set; }

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
        /// Gets or Sets ProductID
        /// </summary>
        [DataMember(Name="productID")]
        public int? ProductID { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets QuoteID
        /// </summary>
        [DataMember(Name="quoteID")]
        public int? QuoteID { get; set; }

        /// <summary>
        /// Gets or Sets QuoteItemType
        /// </summary>
        [DataMember(Name="quoteItemType")]
        public int? QuoteItemType { get; set; }

        /// <summary>
        /// Gets or Sets ServiceBundleID
        /// </summary>
        [DataMember(Name="serviceBundleID")]
        public int? ServiceBundleID { get; set; }

        /// <summary>
        /// Gets or Sets ServiceID
        /// </summary>
        [DataMember(Name="serviceID")]
        public int? ServiceID { get; set; }

        /// <summary>
        /// Gets or Sets ShippingID
        /// </summary>
        [DataMember(Name="shippingID")]
        public int? ShippingID { get; set; }

        /// <summary>
        /// Gets or Sets SortOrderID
        /// </summary>
        [DataMember(Name="sortOrderID")]
        public int? SortOrderID { get; set; }

        /// <summary>
        /// Gets or Sets TaxCategoryID
        /// </summary>
        [DataMember(Name="taxCategoryID")]
        public int? TaxCategoryID { get; set; }

        /// <summary>
        /// Gets or Sets TotalEffectiveTax
        /// </summary>
        [DataMember(Name="totalEffectiveTax")]
        public double? TotalEffectiveTax { get; set; }

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
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId")]
        public ExpressionFuncQuoteItemInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class QuoteItemModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AverageCost: ").Append(AverageCost).Append("\n");
            sb.Append("  ChargeID: ").Append(ChargeID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExpenseID: ").Append(ExpenseID).Append("\n");
            sb.Append("  HighestCost: ").Append(HighestCost).Append("\n");
            sb.Append("  InternalCurrencyLineDiscount: ").Append(InternalCurrencyLineDiscount).Append("\n");
            sb.Append("  InternalCurrencyUnitDiscount: ").Append(InternalCurrencyUnitDiscount).Append("\n");
            sb.Append("  InternalCurrencyUnitPrice: ").Append(InternalCurrencyUnitPrice).Append("\n");
            sb.Append("  IsOptional: ").Append(IsOptional).Append("\n");
            sb.Append("  IsTaxable: ").Append(IsTaxable).Append("\n");
            sb.Append("  LaborID: ").Append(LaborID).Append("\n");
            sb.Append("  LineDiscount: ").Append(LineDiscount).Append("\n");
            sb.Append("  MarkupRate: ").Append(MarkupRate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PercentageDiscount: ").Append(PercentageDiscount).Append("\n");
            sb.Append("  PeriodType: ").Append(PeriodType).Append("\n");
            sb.Append("  ProductID: ").Append(ProductID).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  QuoteID: ").Append(QuoteID).Append("\n");
            sb.Append("  QuoteItemType: ").Append(QuoteItemType).Append("\n");
            sb.Append("  ServiceBundleID: ").Append(ServiceBundleID).Append("\n");
            sb.Append("  ServiceID: ").Append(ServiceID).Append("\n");
            sb.Append("  ShippingID: ").Append(ShippingID).Append("\n");
            sb.Append("  SortOrderID: ").Append(SortOrderID).Append("\n");
            sb.Append("  TaxCategoryID: ").Append(TaxCategoryID).Append("\n");
            sb.Append("  TotalEffectiveTax: ").Append(TotalEffectiveTax).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
            sb.Append("  UnitDiscount: ").Append(UnitDiscount).Append("\n");
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
            return obj.GetType() == GetType() && Equals((QuoteItemModel)obj);
        }

        /// <summary>
        /// Returns true if QuoteItemModel instances are equal
        /// </summary>
        /// <param name="other">Instance of QuoteItemModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuoteItemModel other)
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
                    AverageCost == other.AverageCost ||
                    AverageCost != null &&
                    AverageCost.Equals(other.AverageCost)
                ) && 
                (
                    ChargeID == other.ChargeID ||
                    ChargeID != null &&
                    ChargeID.Equals(other.ChargeID)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    ExpenseID == other.ExpenseID ||
                    ExpenseID != null &&
                    ExpenseID.Equals(other.ExpenseID)
                ) && 
                (
                    HighestCost == other.HighestCost ||
                    HighestCost != null &&
                    HighestCost.Equals(other.HighestCost)
                ) && 
                (
                    InternalCurrencyLineDiscount == other.InternalCurrencyLineDiscount ||
                    InternalCurrencyLineDiscount != null &&
                    InternalCurrencyLineDiscount.Equals(other.InternalCurrencyLineDiscount)
                ) && 
                (
                    InternalCurrencyUnitDiscount == other.InternalCurrencyUnitDiscount ||
                    InternalCurrencyUnitDiscount != null &&
                    InternalCurrencyUnitDiscount.Equals(other.InternalCurrencyUnitDiscount)
                ) && 
                (
                    InternalCurrencyUnitPrice == other.InternalCurrencyUnitPrice ||
                    InternalCurrencyUnitPrice != null &&
                    InternalCurrencyUnitPrice.Equals(other.InternalCurrencyUnitPrice)
                ) && 
                (
                    IsOptional == other.IsOptional ||
                    IsOptional != null &&
                    IsOptional.Equals(other.IsOptional)
                ) && 
                (
                    IsTaxable == other.IsTaxable ||
                    IsTaxable != null &&
                    IsTaxable.Equals(other.IsTaxable)
                ) && 
                (
                    LaborID == other.LaborID ||
                    LaborID != null &&
                    LaborID.Equals(other.LaborID)
                ) && 
                (
                    LineDiscount == other.LineDiscount ||
                    LineDiscount != null &&
                    LineDiscount.Equals(other.LineDiscount)
                ) && 
                (
                    MarkupRate == other.MarkupRate ||
                    MarkupRate != null &&
                    MarkupRate.Equals(other.MarkupRate)
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
                    ProductID == other.ProductID ||
                    ProductID != null &&
                    ProductID.Equals(other.ProductID)
                ) && 
                (
                    Quantity == other.Quantity ||
                    Quantity != null &&
                    Quantity.Equals(other.Quantity)
                ) && 
                (
                    QuoteID == other.QuoteID ||
                    QuoteID != null &&
                    QuoteID.Equals(other.QuoteID)
                ) && 
                (
                    QuoteItemType == other.QuoteItemType ||
                    QuoteItemType != null &&
                    QuoteItemType.Equals(other.QuoteItemType)
                ) && 
                (
                    ServiceBundleID == other.ServiceBundleID ||
                    ServiceBundleID != null &&
                    ServiceBundleID.Equals(other.ServiceBundleID)
                ) && 
                (
                    ServiceID == other.ServiceID ||
                    ServiceID != null &&
                    ServiceID.Equals(other.ServiceID)
                ) && 
                (
                    ShippingID == other.ShippingID ||
                    ShippingID != null &&
                    ShippingID.Equals(other.ShippingID)
                ) && 
                (
                    SortOrderID == other.SortOrderID ||
                    SortOrderID != null &&
                    SortOrderID.Equals(other.SortOrderID)
                ) && 
                (
                    TaxCategoryID == other.TaxCategoryID ||
                    TaxCategoryID != null &&
                    TaxCategoryID.Equals(other.TaxCategoryID)
                ) && 
                (
                    TotalEffectiveTax == other.TotalEffectiveTax ||
                    TotalEffectiveTax != null &&
                    TotalEffectiveTax.Equals(other.TotalEffectiveTax)
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
                    if (AverageCost != null)
                    hashCode = hashCode * 59 + AverageCost.GetHashCode();
                    if (ChargeID != null)
                    hashCode = hashCode * 59 + ChargeID.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (ExpenseID != null)
                    hashCode = hashCode * 59 + ExpenseID.GetHashCode();
                    if (HighestCost != null)
                    hashCode = hashCode * 59 + HighestCost.GetHashCode();
                    if (InternalCurrencyLineDiscount != null)
                    hashCode = hashCode * 59 + InternalCurrencyLineDiscount.GetHashCode();
                    if (InternalCurrencyUnitDiscount != null)
                    hashCode = hashCode * 59 + InternalCurrencyUnitDiscount.GetHashCode();
                    if (InternalCurrencyUnitPrice != null)
                    hashCode = hashCode * 59 + InternalCurrencyUnitPrice.GetHashCode();
                    if (IsOptional != null)
                    hashCode = hashCode * 59 + IsOptional.GetHashCode();
                    if (IsTaxable != null)
                    hashCode = hashCode * 59 + IsTaxable.GetHashCode();
                    if (LaborID != null)
                    hashCode = hashCode * 59 + LaborID.GetHashCode();
                    if (LineDiscount != null)
                    hashCode = hashCode * 59 + LineDiscount.GetHashCode();
                    if (MarkupRate != null)
                    hashCode = hashCode * 59 + MarkupRate.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (PercentageDiscount != null)
                    hashCode = hashCode * 59 + PercentageDiscount.GetHashCode();
                    if (PeriodType != null)
                    hashCode = hashCode * 59 + PeriodType.GetHashCode();
                    if (ProductID != null)
                    hashCode = hashCode * 59 + ProductID.GetHashCode();
                    if (Quantity != null)
                    hashCode = hashCode * 59 + Quantity.GetHashCode();
                    if (QuoteID != null)
                    hashCode = hashCode * 59 + QuoteID.GetHashCode();
                    if (QuoteItemType != null)
                    hashCode = hashCode * 59 + QuoteItemType.GetHashCode();
                    if (ServiceBundleID != null)
                    hashCode = hashCode * 59 + ServiceBundleID.GetHashCode();
                    if (ServiceID != null)
                    hashCode = hashCode * 59 + ServiceID.GetHashCode();
                    if (ShippingID != null)
                    hashCode = hashCode * 59 + ShippingID.GetHashCode();
                    if (SortOrderID != null)
                    hashCode = hashCode * 59 + SortOrderID.GetHashCode();
                    if (TaxCategoryID != null)
                    hashCode = hashCode * 59 + TaxCategoryID.GetHashCode();
                    if (TotalEffectiveTax != null)
                    hashCode = hashCode * 59 + TotalEffectiveTax.GetHashCode();
                    if (UnitCost != null)
                    hashCode = hashCode * 59 + UnitCost.GetHashCode();
                    if (UnitDiscount != null)
                    hashCode = hashCode * 59 + UnitDiscount.GetHashCode();
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

        public static bool operator ==(QuoteItemModel left, QuoteItemModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(QuoteItemModel left, QuoteItemModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}