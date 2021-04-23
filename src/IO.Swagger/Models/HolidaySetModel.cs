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
    public partial class HolidaySetModel : IEquatable<HolidaySetModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets HolidaySetDescription
        /// </summary>
        [DataMember(Name="holidaySetDescription")]
        public string HolidaySetDescription { get; set; }

        /// <summary>
        /// Gets or Sets HolidaySetName
        /// </summary>
        [DataMember(Name="holidaySetName")]
        public string HolidaySetName { get; set; }

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
            sb.Append("class HolidaySetModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  HolidaySetDescription: ").Append(HolidaySetDescription).Append("\n");
            sb.Append("  HolidaySetName: ").Append(HolidaySetName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((HolidaySetModel)obj);
        }

        /// <summary>
        /// Returns true if HolidaySetModel instances are equal
        /// </summary>
        /// <param name="other">Instance of HolidaySetModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HolidaySetModel other)
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
                    HolidaySetDescription == other.HolidaySetDescription ||
                    HolidaySetDescription != null &&
                    HolidaySetDescription.Equals(other.HolidaySetDescription)
                ) && 
                (
                    HolidaySetName == other.HolidaySetName ||
                    HolidaySetName != null &&
                    HolidaySetName.Equals(other.HolidaySetName)
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
                    if (HolidaySetDescription != null)
                    hashCode = hashCode * 59 + HolidaySetDescription.GetHashCode();
                    if (HolidaySetName != null)
                    hashCode = hashCode * 59 + HolidaySetName.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(HolidaySetModel left, HolidaySetModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HolidaySetModel left, HolidaySetModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
