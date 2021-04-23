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
    public partial class ServiceBundleServiceModel : IEquatable<ServiceBundleServiceModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets ServiceBundleID
        /// </summary>
        [DataMember(Name="serviceBundleID")]
        public long? ServiceBundleID { get; set; }

        /// <summary>
        /// Gets or Sets ServiceID
        /// </summary>
        [DataMember(Name="serviceID")]
        public long? ServiceID { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId")]
        public ExpressionFuncServiceBundleServiceInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class ServiceBundleServiceModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ServiceBundleID: ").Append(ServiceBundleID).Append("\n");
            sb.Append("  ServiceID: ").Append(ServiceID).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ServiceBundleServiceModel)obj);
        }

        /// <summary>
        /// Returns true if ServiceBundleServiceModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ServiceBundleServiceModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceBundleServiceModel other)
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
                    if (ServiceBundleID != null)
                    hashCode = hashCode * 59 + ServiceBundleID.GetHashCode();
                    if (ServiceID != null)
                    hashCode = hashCode * 59 + ServiceID.GetHashCode();
                    if (SoapParentPropertyId != null)
                    hashCode = hashCode * 59 + SoapParentPropertyId.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ServiceBundleServiceModel left, ServiceBundleServiceModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ServiceBundleServiceModel left, ServiceBundleServiceModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
