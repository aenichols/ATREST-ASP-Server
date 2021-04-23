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
    public partial class PriceListServiceModel : IEquatable<PriceListServiceModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyID
        /// </summary>
        [DataMember(Name="currencyID")]
        public int? CurrencyID { get; set; }

        /// <summary>
        /// Gets or Sets ServiceID
        /// </summary>
        [DataMember(Name="serviceID")]
        public int? ServiceID { get; set; }

        /// <summary>
        /// Gets or Sets UnitPrice
        /// </summary>
        [DataMember(Name="unitPrice")]
        public double? UnitPrice { get; set; }

        /// <summary>
        /// Gets or Sets UsesInternalCurrencyPrice
        /// </summary>
        [DataMember(Name="usesInternalCurrencyPrice")]
        public bool? UsesInternalCurrencyPrice { get; set; }

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
            sb.Append("class PriceListServiceModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CurrencyID: ").Append(CurrencyID).Append("\n");
            sb.Append("  ServiceID: ").Append(ServiceID).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  UsesInternalCurrencyPrice: ").Append(UsesInternalCurrencyPrice).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PriceListServiceModel)obj);
        }

        /// <summary>
        /// Returns true if PriceListServiceModel instances are equal
        /// </summary>
        /// <param name="other">Instance of PriceListServiceModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PriceListServiceModel other)
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
                    CurrencyID == other.CurrencyID ||
                    CurrencyID != null &&
                    CurrencyID.Equals(other.CurrencyID)
                ) && 
                (
                    ServiceID == other.ServiceID ||
                    ServiceID != null &&
                    ServiceID.Equals(other.ServiceID)
                ) && 
                (
                    UnitPrice == other.UnitPrice ||
                    UnitPrice != null &&
                    UnitPrice.Equals(other.UnitPrice)
                ) && 
                (
                    UsesInternalCurrencyPrice == other.UsesInternalCurrencyPrice ||
                    UsesInternalCurrencyPrice != null &&
                    UsesInternalCurrencyPrice.Equals(other.UsesInternalCurrencyPrice)
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
                    if (CurrencyID != null)
                    hashCode = hashCode * 59 + CurrencyID.GetHashCode();
                    if (ServiceID != null)
                    hashCode = hashCode * 59 + ServiceID.GetHashCode();
                    if (UnitPrice != null)
                    hashCode = hashCode * 59 + UnitPrice.GetHashCode();
                    if (UsesInternalCurrencyPrice != null)
                    hashCode = hashCode * 59 + UsesInternalCurrencyPrice.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PriceListServiceModel left, PriceListServiceModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PriceListServiceModel left, PriceListServiceModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
